using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary.CTRL
{
    public class ALEGridView : UserControl
    {

        private const int GRAB_SIZE = 10;
        private const int MIN_SIZE_COL = 20;
        //private const int GAP_ANTI_ALLIAS = 2;


        #region private member
        private bool _isMovingLine = false;
        private bool _isDebug = false;

        private int _indexLinColSelected = -1;
        private int _cornerRadius = 15;
        private int _gapYRow = 5;
        //private int _borderSize = 2;
        private int _lineSize = 1;

        //private ERoundedType _roundedType = ERoundedType.All;
        //private ERoundedTag _roundedTag = ERoundedTag.None;

        //private GraphicsPath _gpRegion;
        //private GraphicsPath _gpBorder;
        private SolidBrush _foreBrush;
        private SolidBrush _backBrush;
        private Pen _penGridLine;
        //private Pen _penBorder;

        private readonly ALERowDefinition _rowDefinition;
        private ALERowCollection _rowCollection;


        #endregion

        #region public attributes
        public bool IsDebug { get=> _isDebug; set {  _isDebug = value; Invalidate(); } }
        //public int BorderSize { get => _borderSize; set { _borderSize = value; RegenBrushes(); RegenRegion(); Invalidate(); } }
        public int GridLineSize { get => _lineSize; set { _lineSize = value; RegenBrushes(); Invalidate(); } }
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; RegenBrushes(); Invalidate(); } }
        public int GapRow { get => _gapYRow; set { _gapYRow = value; Invalidate(); } }
        //public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; RegenRegion(); Invalidate(); } }
        //public ERoundedTag RoundedTag { get => _roundedTag; set { _roundedTag = value; RegenRegion(); Invalidate(); } }

        public ALERowDefinition RowDefinition => _rowDefinition;
        public ALERowCollection RowCollection 
        {
            get => _rowCollection; 
            set 
            {
                _rowCollection.RowCollectionChanged -= RowCollection_RowChanged;
                _rowCollection.RefreshGrigView -= RowCollection_RefreshGrigView;
                _rowCollection = value; 
                _rowCollection.RowCollectionChanged += RowCollection_RowChanged;
                _rowCollection.RefreshGrigView += RowCollection_RefreshGrigView;


                ReBuildGridView(); 
            } 
        }


        #endregion



        // constructor
        public ALEGridView()
        {
            _rowDefinition= new ALERowDefinition(this.Controls);
            _rowDefinition.OnRebuild += RowDefinition_OnRebuild;
            _rowCollection = new ALERowCollection(_rowDefinition);

            _rowCollection.RowCollectionChanged += RowCollection_RowChanged;

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            ReBuildGridView();
        }


        private void RowCollection_RefreshGrigView(object? sender, EventArgs e) => Invalidate();

        private void RowCollection_RowChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RegenRowData();
            Invalidate();
        }

        private void RowDefinition_OnRebuild(object? sender, EventArgs e) => ReBuildGridView();

        public void ReBuildGridView()
        {
            RegenBrushes();
            RegenRowCol();
            RegenRowData();
            Invalidate();
        }

        private void RegenRowData()
        {
            for (int iRow = 0; iRow < _rowCollection.RowCount; iRow++)
            {
                ALERow row = _rowCollection.GetRow(iRow);
                for (int iCol = 0; iCol < _rowDefinition.Count; iCol++)
                {
                    Rectangle? rect = GetRect(iCol, iRow);
                    if (!rect.HasValue)
                        continue;
                    ALEColControl ctrl = row.GetCol(iCol);

                    if (ctrl == null)
                        continue;

                    ctrl.ControlSize = rect.Value.Size;
                    Point loc = rect.Value.Location;
                    loc.Offset((rect.Value.Width - ctrl.ControlSize.Width) / 2, (rect.Value.Height - ctrl.ControlSize.Height) / 2);
                    ctrl.ControlLocation = loc;
                    row.Invalidate();
                }
            }
        }

        #region utility regen

        private void RegenBrushes()
        {
            _foreBrush = new SolidBrush(ALEToolsUtility.AyoLightGray);
            _backBrush = new SolidBrush(ALEToolsUtility.AyoBackGray1);
            _penGridLine = new Pen(_foreBrush, _lineSize);
            //_penBorder = new Pen(_foreBrush, _borderSize);
        }

        private void RegenRowCol()
        {
            int posCol = 0;
            foreach (ALEColDefinitionBase colDef in _rowDefinition.ColDefinitions)
            {
                colDef.Position =  posCol;
                posCol += ConvertToThis(colDef.ColWidth, colDef.IsAbsolute);
            }

            int nbRow = Height / _rowDefinition.Height;
            _rowDefinition.RowLinePos.Clear();
            for (int iRow = 1; iRow <= nbRow; iRow++)
            {
                _rowDefinition.RowLinePos.Add(iRow * _rowDefinition.Height);
            }
            _rowCollection.SetMaxRow(_rowDefinition.RowLinePos.Count + 1);
        }

        #endregion



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ReBuildGridView();
            Invalidate();
        }

        // PAINTING
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            if (_isDebug)
                e.Graphics.Clear(Color.DarkBlue);
            else
                e.Graphics.Clear(ALEToolsUtility.AyoBackGray1);

            DrawCols(e.Graphics);

            DrawRows(e.Graphics);

            //e.Graphics.DrawPath(_penBorder, _gpBorder);
        }


        #region utility drawing

        private void DrawCols(Graphics g)
        {
            if (_rowDefinition.Count == 0)
                return;

            for (int i = 0; i < _rowDefinition.Count; i++)
            {
                ALEColDefinitionBase colDef = _rowDefinition.ColDefinitions[i];

                Rectangle rect = new Rectangle();
                rect.X = colDef.Position;
                rect.Width = ConvertToThis(colDef.ColWidth, colDef.IsAbsolute);
                rect.Y = 0;
                rect.Height = _rowDefinition.Height;

                g.DrawRectangle(_penGridLine, rect);
                Size size = colDef.Title.GetSize(Font);
                g.DrawString(colDef.Title, Font, _foreBrush, new PointF(rect.X + ((float)rect.Width-(float)size.Width)/2,rect.Y+ ((float)rect.Height-(float)size.Height)/2));
            }
            
        }

        private void DrawRows(Graphics g)
        {
            if (_rowCollection.RowCount == 0)
                return;

            for (int i = 0; i < _rowCollection.RowCount; i++)
            {
                ALERow row = _rowCollection.GetRow(i);
                if (row == null) continue;

                if (!row.IsVisible)
                    continue;

                Rectangle rect = new Rectangle();
                rect.X = 0;
                rect.Width = Width;
                rect.Y = (i+1) * _rowDefinition.Height+_gapYRow;
                rect.Height = _rowDefinition.Height-2*_gapYRow;
                GraphicsPath gpRow = ALEDrawingHelper.GenerateBorder(ERoundedType.All, _cornerRadius, rect, _lineSize);
                g.DrawPath(_penGridLine, gpRow);
            }
        }
        #endregion

        public Rectangle GetRect(int iCol, int iRow )
        {
            if (_rowDefinition.ColDefinitions.Length == 0)
                return Rectangle.Empty;

            if (_rowDefinition.RowLinePos.Count== 0)
                return Rectangle.Empty;

            if (iCol < 0 || iCol > _rowDefinition.ColDefinitions.Length)
                return Rectangle.Empty;

            if (iRow < 0 ||iCol > _rowDefinition.RowLinePos.Count)
                return Rectangle.Empty;

            Rectangle rect = new Rectangle();

            rect.X = _rowDefinition.ColDefinitions[iCol].Position;
            rect.Width = ConvertToThis(_rowDefinition.ColDefinitions[iCol].ColWidth, _rowDefinition.ColDefinitions[iCol].IsAbsolute);

            rect.Y = (iRow + 1) * ( _rowDefinition.Height );// + _borderSize + GAP_ANTI_ALLIAS;
            rect.Height = _rowDefinition.Height ;

            rect.Inflate(-_lineSize, -_lineSize - _gapYRow);

            return rect;
        }

        private int ConvertToThis(float value,bool isAbsolute)
        {
            if (isAbsolute)
                return (int)value;
            else
                return (int)((value / 100f) * (float) Width);
        }


        //private void CheckColIndex(MouseEventArgs e)
        //{
        //    for (int i = 0; i < _rowDefinition.ColLinePos.RowCount; i++)
        //    {


        //        if (e.Location.X >= _rowDefinition.ColLinePos[i] - (GRAB_SIZE / 2) && e.Location.X <= _rowDefinition.ColLinePos[i] + (GRAB_SIZE / 2))
        //        {
        //            _indexLinColSelected = i;
        //            Cursor = Cursors.VSplit;
        //            return;
        //        }
        //    }
        //    Cursor = Cursors.Default;
        //    _indexLinColSelected = -1;
        //}

        //private void MoveColIndex()
        //{
        //    if (_indexLinColSelected >= 0 && _indexLinColSelected < _rowDefinition.RowCount && _isMovingLine)
        //    {
        //        if (_isUpdatingControls)
        //            return;

        //        int value = this.PointToClient(Cursor.Position).X;

        //        if (_indexLinColSelected == 0)
        //        {
        //            value = value.Clamp(MIN_SIZE_COL, _rowDefinition.ColLinePos[_indexLinColSelected + 1] - MIN_SIZE_COL);
        //        }
        //        else if (_indexLinColSelected == _rowDefinition.RowCount - 1)
        //        {
        //            value = value.Clamp(_rowDefinition.ColLinePos[_indexLinColSelected - 1] + MIN_SIZE_COL, Width - MIN_SIZE_COL);
        //        }
        //        else
        //        {
        //            value = value.Clamp(_rowDefinition.ColLinePos[_indexLinColSelected - 1] + MIN_SIZE_COL, Width - MIN_SIZE_COL);
        //        }

        //        _rowDefinition.ColDefinitions[_indexLinColSelected].Position = value;


        //        for (int row = 0; row < _rowCollection.RowCount; row++)
        //        {
        //            Rectangle? a = GetRect(_indexLinColSelected, row);
        //            Rectangle? b = GetRect(_indexLinColSelected + 1, row);

        //            if (!(a.HasValue && b.HasValue))
        //                continue;

        //            //Control ctrlA = _txts[row *( _col.RowCount+1) + _indexLinColSelected];
        //            //Control ctrlB = _txts[row *( _col.RowCount+1) + _indexLinColSelected + 1];  
                    
        //            Control ctrlA = _rowCollection.GetRow(row).GetCol(_indexLinColSelected).Control;
        //            Control ctrlB = _rowCollection.GetRow(row).GetCol(_indexLinColSelected+1).Control;

        //            ctrlA.Size = a.Value.Size;
        //            ctrlA.Location = new Point(a.Value.X, a.Value.Y + (a.Value.Height - ctrlA.Height) / 2);

        //            ctrlB.Size = b.Value.Size;
        //            ctrlB.Location = new Point(b.Value.X, b.Value.Y + (b.Value.Height - ctrlB.Height) / 2);
        //        }

        //        Refresh();
        //        //UpdateControls();
        //    }
        //}

        #region interaction

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Location.Y <= _rowDefinition.Height && !_isMovingLine)
            {
                //CheckColIndex(e);
            }
            else if (_isMovingLine)
            {
                //MoveColIndex();
            }
            else
            {
                Cursor = Cursors.Default;
                _indexLinColSelected = -1;
            }



        }

        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (_indexLinColSelected >= 0 && _indexLinColSelected < _rowDefinition.Count )
                _isMovingLine = true;

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isMovingLine = false;
            base.OnMouseUp(e);
        }

        #endregion
    }
}
