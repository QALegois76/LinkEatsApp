using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary.CTRL
{
    public class ALEWaitingControl : Control
    {
        // members
        private bool _isCancel = false;
        private bool _isRunning = true;
        private bool _isFixedOver = true;

        private int _gapX = 5;
        private int _gapY = 5;
        private int _refreshTime = 50;

        private float _angle = 0f;
        private float _incrementAngle = 10f;
        private float _pourcentFixed = 1;
        private float _pourcentRotated = 1;

        private PointF _centerOfRotation = new PointF();

        private Image _imgFixed;
        private Image _imgRotated;
        private Image _imgTempRotated;

        private Task task;


        // attributes
        public bool IsRunning { get => _isRunning; set=> _isRunning = value; }
        public bool IsFixed { get => _isFixedOver; set { _isFixedOver = value; Invalidate(); } }

        public int GapX { get => _gapX; set { _gapX = value; Invalidate(); } }
        public int GapY { get => _gapY; set { _gapY = value; Invalidate(); } }
        /// <summary>
        /// value in ms
        /// </summary>
        public int RefreshTime { get => _refreshTime; set => _refreshTime = value; }

        public float Angle { get => _angle; set { _angle = value; Invalidate(); } }
        public float IncrementAnge { get => _incrementAngle; set => _incrementAngle = value; }
        public float PourcentImgFixed { get => _pourcentFixed; set { _pourcentFixed = value; Invalidate(); } }
        public float PourcentImgRotated { get => _pourcentRotated; set { _pourcentRotated = value; Invalidate(); } }


        public Image ImageFixed { get => _imgFixed; set { _imgFixed = value; Invalidate(); } }
        public Image ImageRotated { get => _imgRotated; set { _imgRotated = value; Invalidate(); } }



        // constructor
        public ALEWaitingControl()
        {
            DoubleBuffered = true;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ContainerControl, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.Selectable,false );
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.StandardClick, false);
            this.SetStyle(ControlStyles.UserMouse, false);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.FixedWidth, false);
            this.SetStyle(ControlStyles.FixedHeight, false);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.CacheText, false);
            this.SetStyle(ControlStyles.EnableNotifyMessage, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UseTextForAccessibility, false);

            _isRunning = true;
            _isCancel = false;

            task = new Task(() => TaskMethod());
            task.Start();
        }

        // destructor
        ~ALEWaitingControl()
        {
            _isCancel = false;
            _isRunning = false;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _centerOfRotation = new PointF(Width / 2f, Height / 2f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(ALEToolsUtility.AyoBackGray1);


            if (_imgFixed == null || _imgRotated == null)
                return;

            Size sRot = this.Size.GetBestFitSize(_imgRotated.Size);
            Size sFixed = this.Size.GetBestFitSize(_imgFixed.Size);

            Rectangle rRot = new Rectangle(0, 0, sRot.Width, sRot.Height);
            Rectangle rFixed = new Rectangle(0, 0, sFixed.Width, sFixed.Height);

            rRot = this.ReZoom(rRot, _pourcentRotated).ToRectangle();
            rFixed = this.ReZoom(rFixed, _pourcentFixed).ToRectangle();

            rRot.Inflate(-_gapX,-_gapY);
            rFixed.Inflate(-_gapX,-_gapY);

            _imgTempRotated = ALEDrawingHelper.RotateImage(_imgRotated, _angle);

            if (!_isFixedOver)
            {
                e.Graphics.DrawImage(_imgFixed, rFixed);
                e.Graphics.DrawImage(_imgTempRotated, rRot);
            }
            else
            {
                e.Graphics.DrawImage(_imgTempRotated, rRot);
                e.Graphics.DrawImage(_imgFixed, rFixed);
            }
            e.Graphics.ResetTransform();

        }

        // running threaded method
        private void TaskMethod()
        {
            while(true)
            {
                if(_isCancel)
                    return;

                if(_isRunning)
                    _angle += _incrementAngle;

                Thread.Sleep(_refreshTime);

                this.Invoke(() => Invalidate());
            }
        }


    }
}
