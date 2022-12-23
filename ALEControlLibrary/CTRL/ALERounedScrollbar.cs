using ALEControlLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEControlLibrary
{
    public class ALEScrollBar : UserControl
    {
        public enum EMode
        {
            Vertical,
            Horizontal
        }

        public event EventHandler ValueChanged;
        #region VARIABLES

        #region members
        private bool _isAllowClickGoTo = false;
        private bool _isOver = false;
        private bool _isMoving = false;

        private int _cornerRadius = 15;
        private int _borderSize = 5;
        private int _gapGapBoder = 2;
        private int _gripSize = 35;
        protected int _value = 0;
        protected int _min = 0;
        protected int _max = 100;

        private float _availableWidth;
        private float _availableHeight;
        private float _offsetRange;
        protected EMode _mode = EMode.Vertical;
        private ERoundedType _roundedType = ERoundedType.All;
        private ERoundedTag _roundedTags = ERoundedTag.None;

        private SolidBrush _foreBrush;
        private SolidBrush _backBrush;
        private Pen _forePen;
        private Pen _backPen;

        protected GraphicsPath _borderPath;
        protected GraphicsPath _gripPath;
        #endregion

        #region attributes
        public bool IsAllowClickGoTo { get => _isAllowClickGoTo; set => _isAllowClickGoTo = value; }
        public int Range => Maximum - Minimum;
        public int BorderSize { get => _borderSize; set { _borderSize = value; UpdateRegion(); } }
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; UpdateRegion(); } }
        public int GripSize { get => _gripSize; set { _gripSize = value; UpdateRegion(); } }
        public int GapBorderGrip { get => _gapGapBoder; set { _gapGapBoder = value; UpdateRegion(); } }

        public int Value { get => _value; set { _value = value; UpdateGraphicsPath(); ValueChanged?.Invoke(this, EventArgs.Empty); } }
        public int Minimum { get => _min; set { _min = value; UpdateGraphicsPath(); } }
        public int Maximum { get => _max; set { _max = value; UpdateGraphicsPath(); } }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; UpdateRegion(); } }
        public ERoundedTag RoundedTag { get => _roundedTags; set { _roundedTags = value; UpdateRegion(); } }
        public EMode Mode { get => _mode; set { _mode = value; UpdateRegion(); } }
        #endregion

        #endregion


        // constructor
        public ALEScrollBar()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.CacheText, false);
            SetStyle(ControlStyles.ContainerControl, false);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.Selectable, false);
            SetStyle(ControlStyles.StandardClick, true);
            SetStyle(ControlStyles.EnableNotifyMessage, false);
            SetStyle(ControlStyles.Opaque, false);

            _backBrush = new SolidBrush(ALEToolsUtility.AyoBackGray1);
            _backPen = new Pen(_backBrush, 1);
            _foreBrush = new SolidBrush(ALEToolsUtility.AyoLightGray);
            _forePen = new Pen(_foreBrush, 1);

            UpdateRegion();
        }

        #region METHODS

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.Clear(_backBrush.Color);

            if (Enabled)
                _foreBrush.Color = ALEToolsUtility.AyoLightGray;
            else
                _foreBrush.Color = ALEDrawingHelper.ComposeColors(Color.FromArgb(64, ALEToolsUtility.AyoLightGray), ALEToolsUtility.AyoBackGray1);
            g.FillPath(_foreBrush, _borderPath);


            if (Enabled && _isOver && !_isMoving)
                _foreBrush.Color = ALEToolsUtility.AyoHoverGray;
            else if (!Enabled)
                _foreBrush.Color = ALEDrawingHelper.ComposeColors(Color.FromArgb(64, ALEToolsUtility.AyoLightGray), ALEToolsUtility.AyoBackGray1);
            else
                _foreBrush.Color = ALEToolsUtility.AyoLightGray;

            g.FillPath(_foreBrush, _gripPath);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            Value = ALEToolsUtility.Clamp(_value - e.Delta / SystemInformation.MouseWheelScrollDelta, _min, _max);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (_isOver)
            {
                _isMoving = true;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isMoving)
            {
                SetValueWithPt(e.Location);
            }
            else if (Enabled)
            {
                _isOver = _gripPath.IsVisible(e.Location);
                Invalidate();
            }
            else
            {
                _isOver = false;
                Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (_isAllowClickGoTo)
                SetValueWithPt(e.Location);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isMoving = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (_isAllowClickGoTo)
                SetValueWithPt(this.PointToClient(Cursor.Position));
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected void UpdateRegion()
        {
            GraphicsPath temp = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _cornerRadius, DisplayRectangle, -2);
            Region = new Region(temp);
            temp.Dispose();

            Rectangle r = DisplayRectangle;
            r.Inflate(-1, -1);
            _borderPath = new GraphicsPath();
            _borderPath.AddPath(ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _cornerRadius, r, -2 * _borderSize), false);
            _borderPath.AddPath(ALEDrawingHelper.GenerateBorder(ERoundedType.All, _cornerRadius - 2 * _borderSize, r, 2 * _borderSize), false);

            _offsetRange = _borderSize + _gapGapBoder + 1;
            _availableWidth = Width - 2f * _offsetRange;
            _availableHeight = Height - 2 * _offsetRange;

            UpdateGraphicsPath();
        }

        protected void UpdateGraphicsPath()
        {

            RectangleF rect = new RectangleF();

            float pourcent = (float)Value / (float)Range;

            switch (_mode)
            {
                case EMode.Vertical:
                    rect.Width = _availableWidth;
                    rect.Height = _gripSize;
                    rect.X = (Width - rect.Width) / 2f;
                    rect.Y = _offsetRange + pourcent * (_availableHeight - _gripSize);
                    break;
                case EMode.Horizontal:
                    rect.Height = _availableHeight;
                    rect.Width = _gripSize;
                    rect.Y = (Height - rect.Height) / 2f;
                    rect.X = _offsetRange + pourcent * (_availableWidth - _gripSize);
                    break;

                default:
                    throw new Exception(GetType().ToString() + "  => Mode not recognized");
                    this.Enabled = false;
                    return;
            }

            _gripPath = ALEDrawingHelper.GenerateBorder(ERoundedType.All, _cornerRadius - _gapGapBoder - _borderSize, rect.ToRectangle(), 0);
            Invalidate();
        }

        protected void SetValueWithPt(Point pt)
        {
            switch (_mode)
            {
                case EMode.Vertical:
                    Value = ALEToolsUtility.Clamp((int)((float)(pt.Y - _offsetRange) / _availableHeight * (float)Range), _min, _max);
                    break;

                case EMode.Horizontal:
                    Value = ALEToolsUtility.Clamp((int)((float)(pt.X - _offsetRange) / _availableWidth * (float)Range), _min, _max);
                    break;


                default:
                    throw new Exception(GetType().ToString() + " => SetValueWithPt() call in unknown mode");
                    break;
            }
        }
        #endregion

    }
}
