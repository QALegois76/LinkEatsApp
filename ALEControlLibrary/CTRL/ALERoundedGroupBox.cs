using ALEControlLibrary;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace AyoControlLibrary
{
    public partial class ALERoundedGroupBox : GroupBox
    {
        private Color _borderColor = Color.Black;
        private int _cornerRadius = 10;
        private int _borderSize = 1;

        private ERoundedType _roundedType = ERoundedType.All;
        private ERoundedTag _roundedTag = ERoundedTag.None;

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; Invalidate(); } }
        public ERoundedTag RoundedTag { get => _roundedTag; set { _roundedTag = value; Invalidate(); } }

        // constructor
        public ALERoundedGroupBox()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }



        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }

        public int CornerRadius { get=> _cornerRadius; set { _cornerRadius = value; Invalidate(); } }


        public int BorderSize { get => _borderSize; set { _borderSize = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //GroupBoxState state = base.Enabled ? GroupBoxState.Normal : GroupBoxState.Disabled;
            //TextFormatFlags flags = TextFormatFlags.PreserveGraphicsTranslateTransform
            //    | TextFormatFlags.PreserveGraphicsClipping
            //    | TextFormatFlags.TextBoxControl
            //    | TextFormatFlags.WordBreak;

            Color titleColor = this.ForeColor;

            if (!this.Enabled)
                titleColor = Color.FromArgb(64, titleColor);
                //titleColor = AyoColorHelper.ComposeColors(Color.FromArgb(64, titleColor), Parent.BackColor);
            if (this.BorderSize > 0)
            {
                Rectangle rect = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y + this.Font.Height / 2, this.ClientRectangle.Width, this.ClientRectangle.Height - this.Font.Height / 2);
                Color borderColor = this.BorderColor;
                if (!this.Enabled)
                {
                    //borderColor = AyoColorHelper.ComposeColors(Color.FromArgb(64, borderColor), Parent.BackColor);
                    borderColor = Color.FromArgb(64, this.BorderColor);
                }
                using (Pen pen = new Pen(borderColor, _borderSize))
                {
                    pen.Alignment = PenAlignment.Center;
                    e.Graphics.DrawPath(pen, ALEDrawingHelper.GenerateBorder(_roundedType,_roundedTag, _cornerRadius, rect, (int)Math.Round(pen.Width)));
                }
            }

            Rectangle rectText = new Rectangle(this.ClientRectangle.X + 8, this.ClientRectangle.Y, this.ClientRectangle.Width - 8, this.ClientRectangle.Height);
            Size size = TextRenderer.MeasureText(e.Graphics, this.Text, this.Font, new Size(rectText.Width, rectText.Height));
            rectText.Width = size.Width;
            rectText.Height = size.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rectText);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, rectText, titleColor);

            //AyoControlHelpers.DisplayText(e.Graphics, rectText, this.Text, this.Font, titleColor, System.Drawing.ContentAlignment.TopLeft, true);
            RaisePaintEvent(this, e);
        }
    }
}
