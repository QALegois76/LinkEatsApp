using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary.CTRL
{
    public class ALEGridView : UserControl
    {

        private const int rowHeight = 50;
        private const int nbCol = 5;
        private const int GRAB_SIZE = 10;
        private const int MIN_SIZE_COL = 20;
        private const int GAP_ANTI_ALLIAS = 2;


        #region private member
        private bool _isUpdatingControls = false;
        private bool _isMovingLine = false;
        private bool _isDebug = false;

        private int _indexLinColSelected = -1;
        private int _indexHeaderSelected = -1;
        private int _cornerRadius = 15;
        private int _borderSize = 2;
        private int _lineSize = 1;

        private ERoundedType _roundedType = ERoundedType.All;
        private ERoundedTag _roundedTag = ERoundedTag.None;

        private GraphicsPath _gpRegion;
        private GraphicsPath _gpBorder;
        private SolidBrush _foreBrush;
        private SolidBrush _backBrush;
        private Pen _penGridLine;
        private Pen _penBorder;

        //private TextBox[] _txts;


        //private List<int> _col = new List<int>();
        //private List<int> _row = new List<int>();

        #endregion

        #region public attributes
        public bool IsDebug { get=> _isDebug; set {  _isDebug = value; Invalidate(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; RegenBrushes(); RegenRegion(); Invalidate(); } }
        public int GridLineSize { get => _lineSize; set { _lineSize = value; RegenBrushes(); Invalidate(); } }
        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; RegenRegion(); Invalidate(); } }
        public ERoundedTag RoundedTag { get => _roundedTag; set { _roundedTag = value; RegenRegion(); Invalidate(); } }

        #endregion
        // constructor
        public ALEGridView()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            RegenBrushes();
            RegenRowCol();
            RegenRegion();
            Invalidate();
        }

        #region utility regen

        private void RegenBrushes()
        {
            _foreBrush = new SolidBrush(ALEToolsUtility.AyoLightGray);
            _backBrush = new SolidBrush(ALEToolsUtility.AyoBackGray1);
            _penGridLine = new Pen(_foreBrush, _lineSize);
            _penBorder = new Pen(_foreBrush, _borderSize);
        }

        private void RegenRowCol()
        {
            _col.Clear();
            _row.Clear();

            int defualtGap = Width / (nbCol + 1);
            for (int i = 1; i < nbCol + 1; i++)
            {
                _col.Add(i * defualtGap);
            }

            int nbRow = Height / (rowHeight);
            nbRow++;
            for (int i = 1; i < nbRow + 1; i++)
            {
                _row.Add(i * rowHeight);
            }


            SuspendLayout();
            this.Controls.Clear();
            _txts = new TextBox[ (_col.Count+1) * (_row.Count)];

            for (int row = 0; row < _row.Count; row++)
            {
                for (int col = 0; col < _col.Count + 1; col++)
                {
                    int currentIndex = row * (_col.Count+1)+ col;
                    TextBox textBox = CreateTextBox();
                    textBox.Text = $" row{row} col{col}";
                    _txts[currentIndex] = textBox;
                }
            }
            UpdateControls();
            this.Controls.AddRange(_txts);
            ResumeLayout();
        }

        private void RegenRegion()
        {
            _gpRegion = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTag, _cornerRadius, DisplayRectangle, -GAP_ANTI_ALLIAS);
            _gpBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTag, _cornerRadius, DisplayRectangle, _borderSize +GAP_ANTI_ALLIAS);

            Region = new Region(_gpRegion);
        }


        private TextBox CreateTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.ForeColor = ALEToolsUtility.AyoLightGray;
            textBox.BackColor = ALEToolsUtility.AyoBackGray1;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = this.Font;
            textBox.WordWrap = true;
            return textBox;
        }

        private void UpdateControls()
        {
            if (_isUpdatingControls)
                return;

            _isUpdatingControls = true;
            //SuspendLayout();
            for (int row = 0; row < _row.Count ; row++)
            {
                for (int col = 0; col < _col.Count + 1; col++)
                {
                    int currentIndex = row * (_col.Count+1) + col;
                    TextBox textBox = _txts[currentIndex];

                    Rectangle rect = GetRect(col, row);

                    textBox.Size = rect.Size;
                    textBox.Location = new Point(rect.X,rect.Y + (rect.Height -textBox.Height)/2);

                    //Point pt = new Point();

                    ////int ptX = (row - 1 < 0) ? _lineSize : _col[row - 1];
                    //pt.Y = _borderSize + (row+1)*(rowHeight);

                    //if (col == 0)
                    //{
                    //    textBox.Width = _col[0]-_borderSize;
                    //    pt.X = _borderSize;
                    //}
                    //else if (col == _col.Count)
                    //{
                    //    textBox.Width = Width - _col[_col.Count - 1]-_borderSize;
                    //    pt.X = _col[col-1];
                    //}
                    //else
                    //{
                    //    textBox.Width = _col[col] - _col[col - 1];
                    //    pt.X = _col[col - 1];
                    //}

                    //textBox.Width -=2* _lineSize;
                    //pt.X += _lineSize;

                    //textBox.Location = pt;
                    ////int height = (row + 1);

                }
            }
           // ResumeLayout();

            _isUpdatingControls = false;
        }
        #endregion



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RegenRegion();
            RegenRowCol();
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

            e.Graphics.DrawPath(_penBorder, _gpBorder);
        }


        #region utility drawing

        private void DrawCols(Graphics g)
        {
            Point pa = new Point(0, GAP_ANTI_ALLIAS + _borderSize);
            Point pb = new Point(0, Height - GAP_ANTI_ALLIAS - _borderSize);
            _col.ForEach(c =>
            {
                pa.X = c;
                pb.X = c ;
                g.DrawLine(_penGridLine, pa, pb);
            });
        }

        private void DrawRows(Graphics g)
        {
            Point pa = new Point(GAP_ANTI_ALLIAS + _borderSize, 0);
            Point pb = new Point(Width-GAP_ANTI_ALLIAS-_borderSize, 0);
            _row.ForEach(c =>
            {
                if (c > Height - GAP_ANTI_ALLIAS - _borderSize)
                    return;
                pa.Y = c;
                pb.Y = c;
                g.DrawLine(_penGridLine, pa, pb);
            });
        }
        #endregion

        public Rectangle GetRect(int col, int row )
        {
            Rectangle rect = new Rectangle();

            if (col == 0)
            {
                rect.X = 0 + GAP_ANTI_ALLIAS+ _borderSize;
                rect.Width = _col[0]-GAP_ANTI_ALLIAS-_borderSize;
            }
            else if (col > _col.Count-1)
            {
                rect.X =_col[_col.Count - 1];
                rect.Width = Width - _borderSize -rect.X;
            }
            else
            {
                rect.X =_col[col-1];
                rect.Width = _col[col] - rect.X;
            }

            rect.Y = _row[row];
            if (row >= _row.Count - 1)
            {
                rect.Height = Height - rect.Y;
            }
            else
            {
                rect.Height = _row[row+1] - rect.Y;
            }

            rect.Inflate(-_lineSize, -_lineSize);

            return rect;
        }

        private void CheckColIndex(MouseEventArgs e)
        {
            for (int i = 0; i < _col.Count; i++)
            {
                int lineValue = _col[i];
                if (e.Location.X >= lineValue - (GRAB_SIZE / 2) && e.Location.X <= lineValue + (GRAB_SIZE / 2))
                {
                    _indexLinColSelected = i;
                    Cursor = Cursors.VSplit;
                    return;
                }
            }
            Cursor = Cursors.Default;
            _indexLinColSelected = -1;
        }

        private void MoveColIndex()
        {
            if (_indexLinColSelected >= 0 && _indexLinColSelected < _col.Count && _isMovingLine)
            {
                if (_isUpdatingControls)
                    return;

                int value = this.PointToClient(Cursor.Position).X;

                if (_indexLinColSelected == 0)
                {
                    value = value.Clamp(MIN_SIZE_COL, _col[_indexLinColSelected + 1] - MIN_SIZE_COL);
                }
                else if (_indexLinColSelected == _col.Count - 1)
                {
                    value = value.Clamp(_col[_indexLinColSelected - 1] + MIN_SIZE_COL, Width - MIN_SIZE_COL);
                }
                else
                {
                    value = value.Clamp(_col[_indexLinColSelected - 1] + MIN_SIZE_COL, Width - MIN_SIZE_COL);
                }


                _col[_indexLinColSelected] = value;

                for (int row = 0; row < _row.Count - 1; row++)
                {
                    Rectangle a = GetRect(_indexLinColSelected, row);
                    Rectangle b = GetRect(_indexLinColSelected + 1, row);

                    TextBox tba = _txts[row *( _col.Count+1) + _indexLinColSelected];
                    TextBox tbb = _txts[row *( _col.Count+1) + _indexLinColSelected + 1];

                    tba.Size = a.Size;
                    tba.Location = new Point(a.X, a.Y + (a.Height - tba.Height) / 2);

                    tbb.Size = b.Size;
                    tbb.Location = new Point(b.X, b.Y + (b.Height - tbb.Height) / 2);
                }

                Refresh();
                //UpdateControls();
            }
        }

        #region interaction

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);


            if (e.Location.Y <= rowHeight && !_isMovingLine)
            {
                CheckColIndex(e);
            }
            else if (_isMovingLine)
                MoveColIndex();
            else
            {
                Cursor = Cursors.Default;
                _indexLinColSelected = -1;
            }



        }

        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (_indexLinColSelected >= 0 && _indexLinColSelected < _col.Count )
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
