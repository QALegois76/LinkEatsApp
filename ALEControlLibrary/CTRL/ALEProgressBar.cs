using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary.CTRL
{
    public class ALEProgressBar : Control
    {
        public enum EDirection
        {
            Vertical,
            Horizontal
        }

        private const int GAP_ANTI_ALLIAS = 1;

        public event EventHandler ActivStateChanged;

        protected bool _isDebug = false;
        protected bool _isBorderVisible = true;
        /// <summary>
        /// will only use BackImage and FrontImage
        /// </summary>
        protected bool _isTextVisible = false;
        protected bool _isImgValueIsOver = false;

        private int _radius = 15;
        private int _borderSize = 5;

        private float _pourcentValue = 0.25f;
        private float _pourcentBack = 1;
        private float _pourcentFront = 1;

        protected ERoundedType _roundedType = ERoundedType.All;
        protected ERoundedTag _roundedTags = ERoundedTag.None;
        protected EDirection _direction = EDirection.Horizontal;

        protected Image _imgValue = null;
        protected Image _imgDecor = null;

        private GraphicsPath _gpBorder;
        private GraphicsPath _gpRegion;

        private Region _regionText;

        private SolidBrush _bFore;
        private SolidBrush _bBack;
        private Brush _bAccent;

        public bool IsDebug { get => _isDebug; set { _isDebug = value; UpdateRegion(); } }
        public bool IsBorderVisible { get => _isBorderVisible; set { _isBorderVisible= value; UpdateRegion(); } }
        public bool IsTextVisisble { get => _isTextVisible; set { _isTextVisible = value; Invalidate(); } }
        public bool IsImgValueIsOver { get => _isImgValueIsOver; set { _isImgValueIsOver= value; Invalidate(); } }

        public int Radius { get => _radius; set { _radius = value; UpdateRegion(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; UpdateRegion(); } }

        public float PourcentValue { get => _pourcentValue; set { _pourcentValue= value; Invalidate(); } }
        public float PourcentBack { get => _pourcentBack; set { _pourcentBack = value; Invalidate(); } }
        public float PourcentFront { get => _pourcentFront; set { _pourcentFront = value; Invalidate(); } }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; UpdateRegion(); } }
        public ERoundedTag RoundedTags { get => _roundedTags; set { _roundedTags = value; UpdateRegion(); } }
        public EDirection Direction { get => _direction; set { _direction = value; Invalidate(); } }

        /// <summary>
        /// this img will change over poucentValue
        /// </summary>
        public Image ImgValue { get => _imgValue; set { _imgValue = value; Invalidate(); } }
        /// <summary>
        /// this picture will not changed
        /// </summary>
        public Image ImgDecor { get => _imgDecor; set { _imgDecor = value; Invalidate(); } }

        // constructor
        public ALEProgressBar()
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

            _bFore = new SolidBrush(ALEToolsUtility.AyoLightGray);
            _bBack = new SolidBrush(ALEToolsUtility.AyoBackGray1);
            _bAccent = new SolidBrush(ALEToolsUtility.AyoYellow);

            UpdateRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected virtual void UpdateRegion()
        {
            if (_isBorderVisible)
            {
                Rectangle r = DisplayRectangle;
                r.Inflate(-GAP_ANTI_ALLIAS, -GAP_ANTI_ALLIAS);
                _gpRegion = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, DisplayRectangle, -GAP_ANTI_ALLIAS);
                _regionText = new Region(ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize));
                _gpBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize);

                Region = new Region(_gpRegion);
            }
            else
            {
                _regionText = new Region(DisplayRectangle);
                Region = new Region(DisplayRectangle);
            }
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

            // Back
            if (_imgDecor != null && _isImgValueIsOver)
            {
                SizeF size = Size.GetBestFitSize(_imgDecor.Size);
                RectangleF rImg = new RectangleF();
                rImg.Size = size;
                rImg.Location = new PointF((Width- size.Width)/2f,(Height- size.Height)/2f);
                rImg = this.ReZoom(rImg, _pourcentBack);
                pevent.Graphics.DrawImage(_imgDecor, rImg);
            }


            // calcul of the pourcent
            RectangleF rClip;
            if (_direction == EDirection.Horizontal)
            {
                rClip = this.ReZoom(DisplayRectangle, _pourcentValue, ESideResize.X);
                rClip.X= 0;
            }
            else
            {
                rClip = this.ReZoom(DisplayRectangle, _pourcentValue, ESideResize.Y);
                rClip.Y = 0;
            }
            pevent.Graphics.Clip = new Region(rClip);
             
            // draw value
            if (_imgValue != null)
            {
                SizeF size = Size.GetBestFitSize(_imgValue.Size);
                RectangleF rImg = new RectangleF();
                rImg.Size = size;
                rImg.Location = new PointF((Width - size.Width) / 2f, (Height - size.Height) / 2f);
                rImg = this.ReZoom(rImg, _pourcentBack);
                pevent.Graphics.DrawImage(_imgValue, rImg);
            }
            else
            {
                pevent.Graphics.FillPath(_bAccent, _gpBorder);
            }


            pevent.Graphics.ResetClip();


            // Back
            if (_imgDecor != null && !_isImgValueIsOver)
            {
                SizeF size = Size.GetBestFitSize(_imgDecor.Size);
                RectangleF rImg = new RectangleF();
                rImg.Size = size;
                rImg.Location = new PointF((Width - size.Width) / 2f, (Height - size.Height) / 2f);
                rImg = this.ReZoom(rImg, _pourcentBack);
                pevent.Graphics.DrawImage(_imgDecor, rImg);
            }


            // border
            if (_isBorderVisible)
            {
                pevent.Graphics.Clip = new Region(DisplayRectangle);
                pevent.Graphics.DrawPath(new Pen(_bFore, _borderSize), _gpBorder);
            }


            // text 
            if (_isTextVisible)
            {
                pevent.Graphics.Clip = _regionText;
                Size s = TextRenderer.MeasureText(this.Text, this.Font);
                Rectangle r = DisplayRectangle;
                if (_isBorderVisible)
                    r.Inflate(-(_borderSize + _radius / 2), -(_borderSize + _radius / 2));

                Point p = new Point((Width - s.Width) / 2, (Height - s.Height) / 2);
                pevent.Graphics.DrawString(this.Text, this.Font, _bFore, p);
            }
        }
    }
}
