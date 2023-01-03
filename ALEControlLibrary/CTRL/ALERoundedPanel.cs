using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ALEControlLibrary
{

    public class ALERoundedPanel : UserControl, IClickable, IActivable
    {
        #region VARRIABLES
        public const int PIX_GAP_ANTI_ALLIAS = 1;

        public event EventHandler<EventArgs<bool>> OnStateChanged;
        public event EventHandler ActivStateChanged;

        #region private
        private bool _isClickable = true;
        private bool _isAutoActivable = false;
        private bool _isHover = false;
        private bool _isDown = false;
        private bool _isActivate = false;
        private bool _isColorizeOverPicture = false;

        private int _radius = 15;
        private int _sizeBorder = 2;

        private float _multiplierAccentuation = 1f;
        private float _pourcentZoomBack = 1f;
        private float _pourcentAlphaDisable = 0.25f;

        protected ERoundedType _roundredType = ERoundedType.All;
        protected ERoundedTag? _roundedTags = null;

        private GraphicsPath _graphPathRegionCtrl = new GraphicsPath();
        private GraphicsPath _graphPathRegionPnl = new GraphicsPath();
        private GraphicsPath graphPath = new GraphicsPath();
        private Panel pnl;
        private GraphicsPath graphPathAccentuate = new GraphicsPath();

        #endregion

        #region public

        public bool IsClickable { get => _isClickable; set => _isClickable = value; }
        public bool IsAutoActivable { get => _isAutoActivable; set { _isAutoActivable = value; Invalidate(); } }
        public bool IsActivate { get => _isActivate; set { _isActivate = value; Invalidate(); } }
        public bool IsColorizeOverPicture { get => _isColorizeOverPicture; set { _isColorizeOverPicture = value; Invalidate(); } }
        public bool IsContainer { get => pnl.Visible; set => pnl.Visible = value; }

        public int Radius { get => _radius; set { _radius = value; Init(); } }
        public int BorderWidth { get => _sizeBorder; set { _sizeBorder = value; Init(); } }

        public float MultiplierAccentuationBorder { get => _multiplierAccentuation; set { _multiplierAccentuation = value; Invalidate(); } }
        public float PourcentZoomBack { get => _pourcentZoomBack; set { _pourcentZoomBack = value; Invalidate(); } }
        public float PourcentAlphaDisable { get => _pourcentAlphaDisable; set { _pourcentAlphaDisable = value; Invalidate(); } }

        public ERoundedType RoundedType { get => _roundredType; set { _roundredType = value; Init(); } }
        public ERoundedTag? RoundedTag { get => _roundedTags; set { _roundedTags = value; Init(); } }

        public new ControlCollection Controls { get => pnl.Controls; }



        #endregion

        #endregion

        // constructor
        public ALERoundedPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ContainerControl, true);
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

            Init();
        }

        #region METHODS

        #region override
        protected override void OnPaint(PaintEventArgs e)
        {
            // set quality setting
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;


            #region  back and border part

            if (_isColorizeOverPicture || !Enabled || BackgroundImage == null)
            {
                Brush brush = new SolidBrush(Color.FromArgb((int)(_pourcentAlphaDisable * byte.MaxValue), GetCurrentBackColor()));
                e.Graphics.FillPath(brush, graphPath);
            }


            Pen pen = new Pen(Color.FromArgb((Enabled) ? byte.MaxValue : (int)(byte.MaxValue * _pourcentAlphaDisable), GetCurrentBorderColor()), _sizeBorder * ((_isActivate) ? _multiplierAccentuation : 1f));

            if (!_isActivate)
                e.Graphics.DrawPath(pen, graphPath);
            else
                e.Graphics.DrawPath(pen, graphPathAccentuate);
            #endregion

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            e.Graphics.Clear(GetCurrentBackColor());

            if (BackgroundImage == null)
                return;

            SizeF sImg = this.Size.GetBestFitSize(BackgroundImage.Size);
            RectangleF rect = new RectangleF();
            rect.Size = sImg;
            rect.Location = new PointF(((float)Width - (float)rect.Width) / 2f, ((float)Height - (float)rect.Height) / 2f);
            rect = this.ReZoom(rect, _pourcentZoomBack);
            e.Graphics.DrawImage(BackgroundImage, rect);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Init();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Init();
        }
        #endregion

        #region utility
        private void Init()
        {
            _graphPathRegionCtrl = ALEDrawingHelper.GenerateBorder(_roundredType, _radius, DisplayRectangle,-2*PIX_GAP_ANTI_ALLIAS);
            graphPath = ALEDrawingHelper.GenerateBorder(_roundredType, _radius, DisplayRectangle, _sizeBorder);
            _graphPathRegionPnl = ALEDrawingHelper.GenerateBorder(_roundredType,_radius,pnl.DisplayRectangle,2*( _sizeBorder+PIX_GAP_ANTI_ALLIAS));
            graphPathAccentuate = ALEDrawingHelper.GenerateBorder(_roundredType, _radius, DisplayRectangle, (int)(_sizeBorder * _multiplierAccentuation));

            this.Region = new Region(_graphPathRegionCtrl);
            pnl.Region = new Region(_graphPathRegionPnl);

            Refresh();
        }


        private Color GetCurrentBackColor()
        {
            if (!Enabled)
            {
                return ALEToolsUtility.AyoHoverGray;
            }
            else if (_isClickable)
            {
                if (_isHover)
                {
                    // compose color for hover
                    //() => { };
                    return ALEToolsUtility.AyoHoverGray;
                }
                else
                {
                    return BackColor;
                }
            }
            else
                return BackColor;
        }

        private Color GetCurrentBorderColor()
        {
            if (_isActivate)
            {
                return ALEToolsUtility.AyoYellow;
                //if (_clrBorderActivate != Color.Empty)
                //    return _clrBorderActivate;
            }
            else if (!Enabled)
            {
                // calcul
                return ALEToolsUtility.AyoLightGray;

                //() => { };
                //if (_clrBorderDisable != Color.Empty)
                //    return _clrBorderDisable;
            }
            else
                return ALEToolsUtility.AyoLightGray;
        }



        public static ALERoundedPanel Copy(ALERoundedPanel src)
        {
            ALERoundedPanel output = new ALERoundedPanel();
            output.Location = src.Location;
            output.Size = src.Size;
            output.Anchor = src.Anchor;
            output.IsActivate = src.IsActivate;
            output.IsAutoActivable = src.IsAutoActivable;
            output.IsClickable = src.IsClickable;
            output.IsColorizeOverPicture = src.IsColorizeOverPicture;
            output.RoundedType = src.RoundedType;
            output.BackgroundImage = src.BackgroundImage;
            output.MultiplierAccentuationBorder = src.MultiplierAccentuationBorder;
            output.PourcentZoomBack = src.PourcentZoomBack;
            output.PourcentAlphaDisable = src.PourcentAlphaDisable;
            output.ForeColor = src.ForeColor;
            output.BackColor = src.BackColor;
            output.Radius = src.Radius;
            output.BorderWidth = src.BorderWidth;

            foreach (Control control in src.Controls)
                output.Controls.Add(control);

            return output;
        }

        #endregion

        #region event
        // from child control
        private void Ctrl_MouseUp(object sender, MouseEventArgs e) => OnMouseUp(e);
        private void Ctrl_MouseDown(object sender, MouseEventArgs e) => OnMouseDown(e);
        private void Ctrl_Click(object sender, EventArgs e) => OnClick(e);
        private void Ctrl_MouseEnter(object sender, EventArgs e) => OnMouseEnter(e);

        // from itself
        protected override void OnClick(EventArgs e)
        {
            if (_isClickable)
            {
                if (_isAutoActivable)
                {
                    _isActivate = !_isActivate;
                    OnStateChanged?.Invoke(this, new EventArgs<bool>(_isActivate));
                }
                base.OnClick(e);
                Refresh();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_isClickable)
            {
                if (!_isDown)
                {
                    _isDown = true;
                    base.OnMouseDown(e);
                    Refresh();
                }

            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_isClickable)
            {
                if (_isDown)
                {
                    _isDown = false;
                    base.OnMouseDown(e);
                    Refresh();
                }

            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (_isClickable)
            {
                if (!_isHover)
                {
                    _isHover = true;
                    Refresh();
                }
            }
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_isClickable)
            {
                if (_isHover)
                {
                    _isHover = false;
                    _isDown = false;
                    Refresh();
                }
            }
            base.OnMouseLeave(e);
        }

        //protected override void OnControlAdded(ControlEventArgs e)
        //{
        //    pnl.Controls.Add(e.Control);
        //}

        //protected override void OnControlRemoved(ControlEventArgs e)
        //{
        //    pnl.Controls.Remove(e.Control);
        //}

        #endregion

        #endregion

        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(1, 1);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(148, 148);
            this.pnl.TabIndex = 0;
            // 
            // ALERoundedPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            base.Controls.Add(this.pnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.Name = "ALERoundedPanel";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ResumeLayout(false);

        }
    }
}