using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEControlLibrary.CTRL
{
    public partial class ALERoundedTextbox : UserControl
    {
        private const int PIX_GAP_ANTI_ALLIAS = 1;
        
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)] 
        public new event EventHandler TextChanged;

        private int _cornerRadius = 15;
        private int _borberSize = 2;

        private float _pourcentLineAnime = 0f;

        private ERoundedType _roundedType = ERoundedType.All;
        private ERoundedTag _roundedTag = ERoundedTag.None;

        private GraphicsPath _gpRegion;
        private GraphicsPath _gpBorder;

        private SolidBrush _foreBrush;
        private SolidBrush _backBrush;
        private Pen _pFore;

        private BackgroundWorker _bgWorker;


        #region attributes
        public bool ReadOnly { get => tb.ReadOnly; set => tb.ReadOnly = value; }
        public bool WordWrad { get => tb.WordWrap; set => tb.WordWrap = value; }

        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; UpdatedRegion(); } }
        public int BorderSize { get=> _borberSize; set { _borberSize = value; UpdatedRegion(); } }

        public char PasswordChar { get => tb.PasswordChar; set => tb.PasswordChar = value;  }


        public override Color BackColor { get => base.BackColor; set { base.BackColor = tb.BackColor = value; Invalidate(); }  }
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = tb.ForeColor = value; Invalidate(); } }
        public override Font Font { get => base.Font; set { base.Font = value; Invalidate(); } }


        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)] 
        public override string Text { get => tb.Text; set => tb.Text = value; }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; UpdatedRegion(); } }
        public ERoundedTag RoundedTags { get => _roundedTag; set { _roundedTag = value; UpdatedRegion(); } }
        #endregion

        // constructor
        public ALERoundedTextbox()
        {
            InitializeComponent();

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
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.CacheText, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UseTextForAccessibility, true);

            _bgWorker = new BackgroundWorker();
            _bgWorker.WorkerReportsProgress = true;
            _bgWorker.WorkerSupportsCancellation = true;

            _foreBrush = new SolidBrush(ALEToolsUtility.AyoLightGray);
            _backBrush = new SolidBrush(ALEToolsUtility.AyoBackGray1);

            _pFore = new Pen(_foreBrush, _borberSize);

            tb.Font = this.Font;
            tb.ForeColor = this.ForeColor;
            tb.BackColor = this.BackColor;
            tb.Text = this.Text;

            UpdateSize();

            tb.Resize -= Tb_Resize;
            tb.Resize += Tb_Resize;

            tb.GotFocus -= Tb_GotFocus;
            tb.GotFocus += Tb_GotFocus;

            tb.LostFocus -= Tb_LostFocus;
            tb.LostFocus += Tb_LostFocus;

            tb.TextChanged -= Tb_TextChanged;
            tb.TextChanged += Tb_TextChanged;

            _bgWorker.DoWork -= _bgWorker_DoWork;
            _bgWorker.DoWork += _bgWorker_DoWork;

            _bgWorker.ProgressChanged -= _bgWorker_ProgressChanged;
            _bgWorker.ProgressChanged += _bgWorker_ProgressChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e) => TextChanged?.Invoke(this, e);

        private void _bgWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            Invalidate();
        }

        private void _bgWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (_bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(5);

                    if (InvokeRequired)
                        Invoke(UpdateLineBar);
                    else
                        UpdateLineBar();


                    _bgWorker.ReportProgress((int)(_pourcentLineAnime * 100));
                }
            }
        }

        private void UpdateLineBar()
        {
            _pourcentLineAnime += tb.Focused ? 0.1f : -0.1f;

            if (tb.Focused && _pourcentLineAnime >= 1)
            {
                _bgWorker.CancelAsync();
                Invalidate();
            }
            else if (!tb.Focused && _pourcentLineAnime <= 0)
            {
                _bgWorker.CancelAsync();
                Invalidate();
            }
        }

        private void Tb_LostFocus(object? sender, EventArgs e)
        {
            if (!_bgWorker.IsBusy)
                _bgWorker.RunWorkerAsync();
        }

        private void Tb_GotFocus(object? sender, EventArgs e)
        {
            if (!_bgWorker.IsBusy)
                _bgWorker.RunWorkerAsync();
        }

        private void UpdateSize()
        {
            this.Height = tb.Height +2* _cornerRadius;
            tb.Width = this.Width -2* _cornerRadius;

            tb.Location = new Point((this.Width-tb.Width)/2,_cornerRadius);

            UpdatedRegion();
        }

        protected virtual void UpdatedRegion()
        {
            _gpRegion = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTag, _cornerRadius, DisplayRectangle, -2*PIX_GAP_ANTI_ALLIAS);
            _gpBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTag, _cornerRadius, DisplayRectangle, BorderSize+4*PIX_GAP_ANTI_ALLIAS);

            this.Region = new Region(_gpRegion);
            Invalidate();
        }





        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            tb.ForeColor = ALEToolsUtility.AyoLightGray;

            g.Clear(ALEToolsUtility.AyoBackGray1);
            tb.BackColor = ALEToolsUtility.AyoBackGray1;

            _pFore.StartCap = LineCap.Round;
            _pFore.EndCap = LineCap.Round;

            if (tb.Focused && Enabled && Focused && !ReadOnly)
            {
                Point pOrigin = new Point(this.Width/2,_borberSize+ tb.Location.Y + tb.Height + (this.Height - tb.Location.Y - tb.Height - _cornerRadius)/2);
                Vector2 vOrigin = pOrigin.ToVector2();
                Vector2 part1 =vOrigin + Vector2.UnitX * (tb.Width / 2) * _pourcentLineAnime;
                Vector2 part2 = vOrigin - Vector2.UnitX * (tb.Width / 2) * _pourcentLineAnime;

                g.DrawLine(_pFore, pOrigin, part1.ToPoint());
                g.DrawLine(_pFore, pOrigin, part2.ToPoint());
            }

            g.DrawPath(_pFore, _gpBorder);

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateSize();
        }

        private void Tb_Resize(object? sender, EventArgs e) => UpdateSize();



        public static implicit operator TextBox(ALERoundedTextbox rtb) => rtb.tb;
    }
}
