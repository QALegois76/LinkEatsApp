using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary.CTRL
{
    public class ALERoundedButton : Button , IClickable , IActivable
    {
        private const int GAP_ANTI_ALLIAS = 1;

        public event EventHandler ActivStateChanged;

        protected bool _isDebug = false;
        protected bool _isOver;
        protected bool _isPressed;
        protected bool _isClickable = true;
        protected bool _isActivated = false;
        protected bool _isAutoActivable = false;

        private int _radius = 15;
        private int _borderSize = 5;
        private int _borderSizeActiv = 10;

        private float _pourcentBack = 1;

        protected ERoundedType _roundedType = ERoundedType.All;
        protected ERoundedTag _roundedTags =  ERoundedTag.None;

        private GraphicsPath _gpBorder;
        private GraphicsPath _gpActivBorder;
        private GraphicsPath _gpRegion;

        private Region _regionText;

        private SolidBrush _bFore;
        private SolidBrush _bBack;

        public bool IsDebug { get => _isDebug; set { _isDebug = value; UpdateRegion(); } }
        public bool IsClickable { get => _isClickable; set => _isClickable=value; }
        public bool IsActivate { get => _isActivated; set { _isActivated = value; Invalidate(); } }
        public bool IsAutoActivable { get => _isAutoActivable; set => _isAutoActivable = value; }

        public int  Radius { get => _radius; set { _radius = value; UpdateRegion(); } }
        public int BorderSize { get=> _borderSize; set { _borderSize = value; UpdateRegion(); } }
        public int BorderSizeActiv { get=> _borderSizeActiv; set { _borderSizeActiv = value; UpdateRegion(); } }

        public float PourcentBack { get => _pourcentBack; set { _pourcentBack = value; Invalidate(); } }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; UpdateRegion(); } }
        public ERoundedTag  RoundedTags { get => _roundedTags; set { _roundedTags = value; UpdateRegion(); } }



        // constructor
        public ALERoundedButton()
        {
            DoubleBuffered = true;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ContainerControl, false);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.StandardClick, true);
            this.SetStyle(ControlStyles.UserMouse, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.FixedWidth, false);
            this.SetStyle(ControlStyles.FixedHeight, false);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.CacheText, false);
            this.SetStyle(ControlStyles.EnableNotifyMessage, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UseTextForAccessibility, false);

            _bFore = new SolidBrush(ForeColor);
            _bBack = new SolidBrush(BackColor);

            UpdateRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected virtual void UpdateRegion()
        {
            Rectangle r = DisplayRectangle;
            r.Inflate(-GAP_ANTI_ALLIAS,-GAP_ANTI_ALLIAS);
            _gpRegion = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, DisplayRectangle,-GAP_ANTI_ALLIAS);

            _gpBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize);
            _gpActivBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSizeActiv);

            _regionText = new Region(ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize + _borderSizeActiv));

            Region = new Region(_gpRegion);

            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.CompositingMode = CompositingMode.SourceOver;
            pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            pevent.Graphics.Clear(BackColor);

            if (Enabled)
            {
                if (_isPressed)
                    _bBack.Color = ALEToolsUtility.AyoBackGray1;
                else if (_isOver)
                    _bBack.Color = ALEToolsUtility.AyoHoverGray;
                else
                    _bBack.Color = ALEToolsUtility.AyoBackGray1;

                if (_isActivated)
                    _bFore.Color = ALEToolsUtility.AyoYellow;
                else
                    _bFore.Color = ALEToolsUtility.AyoLightGray;
            }
            else
            {
                _bBack.Color = ALEToolsUtility.AyoHoverGray;
                _bFore.Color = ALEToolsUtility.AyoLightGray;
            }

            // back
            pevent.Graphics.FillPath(_bBack, _isActivated ? _gpActivBorder : _gpBorder);

            // image
            if (BackgroundImage != null && BackgroundImageLayout == ImageLayout.Zoom)
            {
                Size size = Size.GetBestFitSize(BackgroundImage.Size);
                Rectangle rImg = new Rectangle();
                rImg.Size = size;
                rImg.Offset((Width - rImg.Width) / 2, (Height - rImg.Height) / 2);
                rImg = this.ReZoom(rImg, _pourcentBack).ToRectangle();
                pevent.Graphics.DrawImage(BackgroundImage, rImg);
            }


            // text 
            pevent.Graphics.Clip = _regionText;
            Size s = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle r = DisplayRectangle;
            r.Inflate(-(_borderSizeActiv + _radius / 2),-( _borderSizeActiv + _radius / 2));
            if (_isDebug)
                pevent.Graphics.DrawRectangle(new Pen(Color.Magenta, 1), r);
            Point p = r.GetPointFromDisposition(this.Text, this.Font, TextAlign);
            pevent.Graphics.DrawString(this.Text, this.Font, _bFore, p);

            // border
            pevent.Graphics.Clip = new Region(DisplayRectangle);
            pevent.Graphics.DrawPath(new Pen(_bFore,_isActivated? _borderSizeActiv: _borderSize),_isActivated? _gpActivBorder: _gpBorder);
        }



        protected override void OnMouseEnter(EventArgs e)
        {
            _isOver = true;
            Invalidate();
            //base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isOver = false;
            Invalidate();
            //base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _isPressed = true;
            Invalidate();
            //base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _isPressed = false;
            if (_isClickable)
            {
                if (_isAutoActivable)
                {
                    _isActivated = !_isActivated;
                    ActivStateChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            Invalidate();
            base.OnMouseUp(mevent);
        }
    }
}
