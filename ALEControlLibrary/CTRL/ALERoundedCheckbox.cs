using ALEControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEControlLibrary
{
    public class ALERoundedCheckbox : CheckBox
    {
        public enum EState
        {
            Checked,
            Unchecked,
            Undefined
        }

        public enum EIcon
        {
            Cross,
            Rect,
            Circle,
            Validate,
            Line
        }

        private const float SQRT2 = 1.4142f;

        private bool _isAutoCheck = true;
        private bool _isMouseDown = false;
        private bool _isMouseOver = false;
        private bool _isChechedFilled = false;
        private bool _isAnimationEnable = false;
        private bool _isPourcentClipBackIncreasing = false;
        private bool _isPourcentClipIconIncreasing = false;

        private int _cornerRadius = 15;

        private float _pourcentBorder = 0.05f;
        private float _pourcentIcon = 0.05f;
        private float _pourcentClipBack = 0;
        private float _pourcentClipIcon = 0;

        private ERoundedType _roundedType = ERoundedType.All;
        private EState _state = EState.Unchecked;
        private EIcon _iconChecked = EIcon.Validate;
        private EIcon _iconUndefined = EIcon.Line;

        public bool IsAutoCheck { get => _isAutoCheck; set => _isAutoCheck = value; }
        public bool IsAnimationEnable { get => _isAnimationEnable; set => _isAnimationEnable = value; }
        public bool IsCheckedFiller { get => _isChechedFilled; set { _isChechedFilled = value; Invalidate(); } }
        public new bool Checked { get => _state == EState.Checked; set { _state = value ? EState.Checked : EState.Unchecked; Invalidate(); } }

        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; ReGenRegion(); Invalidate(); } }

        public float PourcentBorder { get => _pourcentBorder; set { _pourcentBorder = value; Invalidate(); } }
        public float PourcentIcon { get => _pourcentIcon; set { _pourcentIcon = value; Invalidate(); } }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; ReGenRegion(); Invalidate(); } }
        public EState State { get => _state; set { _state = value; Invalidate(); } }
        public EIcon IconChecked { get => _iconChecked; set { _iconChecked = value; Invalidate(); } }
        public EIcon IconUndefined { get => _iconUndefined; set { _iconUndefined = value; Invalidate(); } }

        private BackgroundWorker _backgroundWorkerBack;
        private BackgroundWorker _backgroundWorkerIcon;


        public ALERoundedCheckbox()
        {
            AutoSize = false;
            DoubleBuffered = true;
            _backgroundWorkerBack = new BackgroundWorker();
            _backgroundWorkerIcon = new BackgroundWorker();
            _backgroundWorkerBack.DoWork -= BackgroundWorker_DoWork;
            _backgroundWorkerBack.DoWork += BackgroundWorker_DoWork;
            _backgroundWorkerIcon.DoWork -= BackgroundWorkerIcon_DoWork;
            _backgroundWorkerIcon.DoWork += BackgroundWorkerIcon_DoWork;
            _pourcentClipBack = 0;
            _pourcentClipIcon = 1;
        }

        private void BackgroundWorkerIcon_DoWork(object sender, DoWorkEventArgs e)
        {
            while ((_isPourcentClipIconIncreasing && _pourcentClipIcon < 1) || (!_isPourcentClipIconIncreasing && _pourcentClipIcon > 0))
            {
                if (_isPourcentClipIconIncreasing)
                    _pourcentClipIcon += 0.1f;
                else
                    _pourcentClipIcon -= 0.1f;
                _pourcentClipIcon.Clamp(0, 1);
                Invalidate();
                Thread.Sleep(1);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            while ((_isPourcentClipBackIncreasing && _pourcentClipBack < 1) || (!_isPourcentClipBackIncreasing && _pourcentClipBack > 0))
            {
                if (_isPourcentClipBackIncreasing)
                    _pourcentClipBack += 0.1f;
                else
                    _pourcentClipBack -= 0.1f;

                _pourcentClipBack.Clamp(0, 1);
                Invalidate();
                Thread.Sleep(1);
            }
        }




        protected override void OnPaint(PaintEventArgs pevent)
        {
            // set quality setting
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.InterpolationMode = InterpolationMode.High;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Graphics g = pevent.Graphics;
            g.Clear(BackColor);

            RectangleF rectangle = this.ReZoom(this.ClientRectangle, ((float)Width - 2f) / (float)Width);

            float sizePenBorder = (float)Width * _pourcentBorder;
            float sizePenIcon = (float)Width * _pourcentIcon;
            GraphicsPath graphicsPath = ALEDrawingHelper.GenerateBorder(_roundedType, _cornerRadius, rectangle.ToRectangle(), 0);
            GraphicsPath gpBorder = new GraphicsPath();
            gpBorder.AddPath(graphicsPath, false);
            gpBorder.AddPath(ALEDrawingHelper.GenerateBorder(_roundedType, _cornerRadius, rectangle.ToRectangle(), 2 * (int)sizePenBorder), false);

            Brush b = new SolidBrush(GetCorrectBackColor());
            Brush bBoder = new SolidBrush(GetCorrectBorderColor());
            Pen pen = new Pen(GetCorrectBorderColor(), sizePenBorder);


            GraphicsPath gpClipBack = new GraphicsPath();
            GraphicsPath gpClipIcon = new GraphicsPath();
            gpClipBack.AddEllipse(this.ReZoom(this.ClientRectangle, SQRT2 * _pourcentClipBack));
            gpClipIcon.AddEllipse(this.ReZoom(this.ClientRectangle, SQRT2 * _pourcentClipIcon));


            Region temp = g.Clip;


            // fill background
            g.FillPath(b, graphicsPath);

            // draw over
            g.Clip = new Region(gpClipBack);
            Brush bOver = new SolidBrush(Color.FromArgb(255, GetCorrectHoverColor()));
            if (_pourcentClipBack > 0)
                g.FillPath(bOver, graphicsPath);


            // draw border
            g.Clip = temp;
            g.FillPath(bBoder, gpBorder);

            // draw state
            g.Clip = new Region(gpClipIcon);
            DrawState(g);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            pevent.Graphics.Clear(BackColor);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Width != Height)
            {
                int s = (Width + Height) / 2;
                Size = new Size(s, s);
            }
            ReGenRegion();
        }

        private void ReGenRegion()
        {
            GraphicsPath graphicsPath = ALEDrawingHelper.GenerateBorder(_roundedType, _cornerRadius, this.ClientRectangle, -1);
            Region = new Region(graphicsPath);
        }

        #region override interaction
        protected override void OnMouseEnter(EventArgs eventargs)
        {
            _isMouseOver = true;
            _isPourcentClipBackIncreasing = true;
            if (!_backgroundWorkerBack.IsBusy)
                _backgroundWorkerBack.RunWorkerAsync();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            _isMouseOver = false;
            _isPourcentClipBackIncreasing = false;
            if (!_backgroundWorkerBack.IsBusy)
                _backgroundWorkerBack.RunWorkerAsync();
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (_isMouseDown)
                return;

            _isMouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _isMouseDown = false;
            if (ThreeState && _isAutoCheck)
            {
                switch (_state)
                {
                    case EState.Checked:
                        _state = EState.Undefined;
                        break;


                    case EState.Unchecked:
                        _state = EState.Checked;
                        break;

                    default:
                    case EState.Undefined:
                        _state = EState.Unchecked;
                        break;
                }
                Invalidate();
                _isPourcentClipIconIncreasing = true;
                _pourcentClipIcon = 0;
                if (!_backgroundWorkerIcon.IsBusy)
                    _backgroundWorkerIcon.RunWorkerAsync();
            }
            else if (_isAutoCheck)
            {
                Checked = !Checked;
            }
            base.OnCheckedChanged(EventArgs.Empty);
            Invalidate();
        }
        #endregion

        #region draw methods
        private void DrawState(Graphics g)
        {
            switch (_state)
            {
                case EState.Checked:
                    DrawIcon(g, _iconChecked);
                    break;

                case EState.Undefined:
                    DrawIcon(g, _iconUndefined);
                    break;

                default:
                case EState.Unchecked:
                    break;
            }
        }

        private void DrawIcon(Graphics g, EIcon icon)
        {
            switch (icon)
            {
                case EIcon.Cross:
                    DrawCross(g);
                    break;

                case EIcon.Rect:
                    DrawRect(g);
                    break;

                case EIcon.Circle:
                    DrawCircle(g);
                    break;

                case EIcon.Line:
                    DrawHLine(g);
                    break;

                default:
                case EIcon.Validate:
                    DrawCValidate(g);
                    break;
            }
        }

        private void DrawCross(Graphics g)
        {
            Vector2 origin = new Vector2((float)Width / 2f, (float)Height / 2f);
            Vector2 diagP = new Vector2((float)Width, (float)Height) / 2f;
            Vector2 diagN = new Vector2((float)Width, -(float)Height) / 2f;

            float _overAllPourcent = (1 - 2 * (_pourcentBorder + _pourcentIcon));
            diagN *= _overAllPourcent;
            diagP *= _overAllPourcent;

            DrawVector(g, new Vector2(), diagP, origin);
            DrawVector(g, new Vector2(), diagN * -1, origin);
            DrawVector(g, new Vector2(), diagP * -1, origin);
            DrawVector(g, new Vector2(), diagN, origin);
        }

        private void DrawRect(Graphics g)
        {
            float _overAllPourcent = (1 - 2 * (_pourcentBorder + _pourcentIcon));
            GraphicsPath graphicsPath = ALEDrawingHelper.GenerateBorder(_roundedType, _cornerRadius, this.ReZoom(this.DisplayRectangle, _overAllPourcent).ToRectangle(), -1);
            SolidBrush brush = new SolidBrush(GetCorrectForeColor());
            g.FillPath(brush, graphicsPath);
        }

        private void DrawCircle(Graphics g)
        {
            float _overAllPourcent = (1 - 2 * (_pourcentBorder + _pourcentIcon));
            Rectangle r = this.ReZoom(this.DisplayRectangle, _overAllPourcent).ToRectangle();

            if (!_isChechedFilled)
            {
                SolidBrush brush = new SolidBrush(GetCorrectForeColor());
                g.FillEllipse(brush, r);
            }
            else
            {
                Pen pen = new Pen(GetCorrectForeColor(), (float)Width * _pourcentIcon);
                g.DrawEllipse(pen, r);
            }
        }

        private void DrawCValidate(Graphics g)
        {
            Vector2 origin = new Vector2((float)Width / 2f, (float)Height / 2f);
            Vector2 diagP = new Vector2((float)Width, (float)Height) / 2f;
            Vector2 diagN = new Vector2((float)Width, -(float)Height) / 2f;

            float _overAllPourcent = (1 - 2 * (_pourcentBorder + _pourcentIcon));
            diagN *= _overAllPourcent;
            diagP *= _overAllPourcent;

            float lenB = 1.25f;
            float lenS = 0.55f * lenB;

            Vector2 offset = diagP - new Vector2(0f, 1f) * 0.3333f * Height / 2f;
            //offset = new Vector2();

            Vector2 start = new Vector2() - lenB * diagP + offset;

            DrawVector(g, start, diagP * lenB, origin);
            DrawVector(g, start, diagN * -lenS, origin);

            //SolidBrush b = new SolidBrush(AyoToolsUtility.AyoLightGray);
            //g.FillEllipse(b, new RectangleF())
        }

        private void DrawHLine(Graphics g)
        {
            float _overAllPourcent = (1 - 2 * (_pourcentBorder + _pourcentIcon));
            Vector2 origin = new Vector2((float)Width / 2f, (float)Height / 2f);
            float len = (Width / 2) * _overAllPourcent;

            DrawVector(g, new Vector2(), new Vector2(-1, 0) * len, origin);
            DrawVector(g, new Vector2(), new Vector2(1, 0) * len, origin);
        }

        private void DrawVector(Graphics g, Vector2 start, Vector2 vec, Vector2 originVec)
        {
            Point s = this.GetPointFromVect(start, originVec);
            Point e = this.GetPointFromVect(start + vec, originVec);
            float size = (float)Width * _pourcentIcon;
            Pen pen = new Pen(GetCorrectForeColor(), size);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            //SolidBrush br = new SolidBrush(Color.Red);
            //SolidBrush bG = new SolidBrush(Color.Green);
            //g.FillEllipse(bG, new RectangleF(s, new SizeF(5f, 5f)));
            // g.FillEllipse(br, new RectangleF(e, new SizeF(5, 5)));
            g.DrawLine(pen, s, e);
        }
        #endregion

        #region color gestion

        private Color GetCorrectForeColor()
        {
            if (_state == EState.Checked)
            {
                if (_iconChecked == EIcon.Rect)
                    return ALEToolsUtility.AyoYellow;
                return (_isChechedFilled) ? ALEToolsUtility.AyoBackGray1 : ALEToolsUtility.AyoYellow;
            }
            else if (_state == EState.Undefined)
            {
                if (_iconUndefined == EIcon.Rect)
                    return ALEToolsUtility.AyoYellow;
                else
                    return (_isChechedFilled) ? ALEToolsUtility.AyoBackGray1 : ALEToolsUtility.AyoYellow;
            }
            else
            {
                return (_isChechedFilled) ? ALEToolsUtility.AyoBackGray1 : ALEToolsUtility.AyoLightGray;
            }
        }

        private Color GetCorrectBorderColor()
        {
            if (_state == EState.Checked)
            {
                return ALEToolsUtility.AyoYellow;
            }
            else
            {
                return ALEToolsUtility.AyoLightGray;
            }
        }

        private Color GetCorrectHoverColor()
        {
            if (Enabled)
            {
                if (_state == EState.Checked)
                {
                    if (_iconChecked == EIcon.Rect)
                        return ALEToolsUtility.AyoHoverGray;
                    else
                        return (_isChechedFilled) ? ALEToolsUtility.AyoYellow : ALEToolsUtility.AyoHoverGray;
                }
                else if (_state == EState.Undefined)
                {
                    if (_iconUndefined == EIcon.Rect)
                        return ALEToolsUtility.AyoHoverGray;
                    else
                        return (_isChechedFilled) ? ALEToolsUtility.AyoLightGray : ALEToolsUtility.AyoHoverGray;
                }
                else
                {
                    return ALEToolsUtility.AyoHoverGray;
                }
            }
            else
            {
                return ALEToolsUtility.AyoHoverGray;
            }
        }

        private Color GetCorrectBackColor()
        {
            if (this.Enabled)
            {
                if (_isMouseDown)
                {
                    return ALEToolsUtility.AyoBackGray1;
                }
                else
                {
                    if (_state == EState.Checked)
                    {
                        if (_iconChecked == EIcon.Rect)
                            return ALEToolsUtility.AyoBackGray1;
                        else
                            return (_isChechedFilled) ? ALEToolsUtility.AyoYellow : ALEToolsUtility.AyoBackGray1;
                    }
                    else if (_state == EState.Undefined)
                    {
                        if (_iconUndefined == EIcon.Rect)
                            return ALEToolsUtility.AyoBackGray1;
                        else
                            return (_isChechedFilled) ? ALEToolsUtility.AyoLightGray : ALEToolsUtility.AyoBackGray1;
                    }
                    else
                    {
                        return ALEToolsUtility.AyoBackGray1;
                    }
                }
            }
            else
            {
                return ALEToolsUtility.AyoHoverGray;
            }
        }
        #endregion
    }
}
