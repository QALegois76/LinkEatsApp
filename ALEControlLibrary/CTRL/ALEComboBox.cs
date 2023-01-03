using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEControlLibrary
{
    [DefaultEvent(nameof(SelectedIndexChanged))]
    public class ALEComboBox : UserControl
    {
        public event EventHandler<EventArgs<int>> SelectedIndexChanged;

        // class which handle the form
        private class ALEComboBoxForm : Form
        {
            private int _radius = 15;
            private int _borderSize = 2;
            private int _indexMouse = -1;
            private int _selectedIndex = -1;
            private int _gapText = 10;

            private GraphicsPath _gpBorder;
            private GraphicsPath _gpRegion;

            private SolidBrush _bFore;
            private SolidBrush _bBack;

            private List<Tuple<string,Rectangle>> _items = new List<Tuple<string,Rectangle>>();

            public int Radius { get => _radius; set { _radius = value; UpdateRegion(); } }
            public int BorderSize { get => _borderSize; set { _borderSize = value; UpdateRegion(); } }
            public int GapText { get => _gapText; set {_gapText = value; Invalidate(); } }
            public int SelectedIndex { get => _selectedIndex; set { _selectedIndex = value; Invalidate(); } }
            public List<Tuple<string, Rectangle>> Items { get=> _items; set => _items = value; }

            // constructor
            public ALEComboBoxForm()
            {
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

                _bFore = new SolidBrush(ForeColor);
                _bBack = new SolidBrush(BackColor);

                this.FormBorderStyle= FormBorderStyle.None;
                this.AutoScaleMode = AutoScaleMode.None;

                UpdateRegion();
                _indexMouse = -1;

                this.Deactivate += ALEComboBoxForm_Deactivate;
            }

            private void ALEComboBoxForm_Deactivate(object? sender, EventArgs e)
            {
                this.Close();
            }

            protected virtual void UpdateRegion()
            {
                Rectangle r = DisplayRectangle;
                r.Inflate(-GAP_ANTI_ALLIAS, -GAP_ANTI_ALLIAS);
                r.Y = 0;
                _gpRegion = ALEDrawingHelper.GenerateBorder(ERoundedType.Bottom, _radius, DisplayRectangle, -GAP_ANTI_ALLIAS);
                _gpBorder = ALEDrawingHelper.GenerateBorder(ERoundedType.Bottom, _radius, r,_borderSize);
                Region = new Region(_gpRegion);
                Invalidate();
            }

          
            
            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                UpdateRegion();
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                pevent.Graphics.CompositingMode = CompositingMode.SourceOver;
                pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                pevent.Graphics.Clear(ALEToolsUtility.AyoBackGray1);


                _bBack.Color = ALEToolsUtility.AyoBackGray1;
                _bFore.Color = ALEToolsUtility.AyoLightGray;
  

                // back
                pevent.Graphics.FillPath(_bBack, _gpBorder);

                DrawOptions(pevent.Graphics);

                // border
                pevent.Graphics.Clip = new Region(DisplayRectangle);
                pevent.Graphics.DrawPath(new Pen(_bFore, _borderSize), _gpBorder);
            }



            private void DrawOptions(Graphics g)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    Rectangle rPlace = _items[i].Item2;
                    int yOffset = (rPlace.Height - TextRenderer.MeasureText(_items[i].Item1, Font).Height) / 2;

                    if (i == _indexMouse)
                    {
                        _bBack.Color = ALEToolsUtility.AyoHoverGray;
                        g.FillRectangle(_bBack, rPlace);
                        g.DrawString(_items[i].Item1, Font, _bFore, new PointF(GAP_ANTI_ALLIAS + _borderSize, rPlace.Y + yOffset));
                        _bBack.Color = ALEToolsUtility.AyoBackGray1;
                    }
                    else if (i == _selectedIndex)
                    {
                        _bBack.Color = ALEToolsUtility.AyoYellow;
                        _bFore.Color = ALEToolsUtility.AyoBackGray1;
                        g.FillRectangle(_bBack, rPlace);
                        g.DrawString(_items[i].Item1, Font, _bFore, new PointF(GAP_ANTI_ALLIAS + _borderSize, rPlace.Y + yOffset));
                        _bBack.Color = ALEToolsUtility.AyoBackGray1;
                        _bFore.Color = ALEToolsUtility.AyoLightGray;
                    }
                    else
                    {
                        g.FillRectangle(_bBack, rPlace);
                        g.DrawString(_items[i].Item1, Font, _bFore, new PointF(GAP_ANTI_ALLIAS + _borderSize, rPlace.Y + yOffset));
                    }


                }
            }

            private void CheckIndexMouse(int y)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    Rectangle r = _items[i].Item2;
                    if (y>= r.Y && y <r.Y+r.Height)
                    {
                        _indexMouse= i;
                        Invalidate();
                        Trace.WriteLine(_indexMouse);
                        return;
                    }
                }
            }

            public void SetData(string[] options)
            {
                if (options.Length == 0)
                    return;

                int height = TextRenderer.MeasureText(options[0],this.Font).Height + GAP_TEXT;
                int posY = _borderSize;
                for (int i = 0; i < options.Length; i++)
                {
                    Rectangle r = new Rectangle(2, i* (height  + GAP_TEXT)+ _borderSize, Width-2*_borderSize, height);
                    _items.Add(new Tuple<string, Rectangle>(options[i], r));
                }
                this.Height =_items.Last().Item2.Y + _items.Last().Item2.Height + 2*(_borderSize + GAP_ANTI_ALLIAS);
                Invalidate();
            }



            protected override void OnMouseClick(MouseEventArgs e)
            {
                if (_indexMouse != -1)
                    _selectedIndex = _indexMouse;
                Refresh();
                Close();
                base.OnMouseMove(e);
            }

            protected override void OnMouseMove(MouseEventArgs e)
            {
                CheckIndexMouse(e.Y);
                base.OnMouseDoubleClick(e);
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                _indexMouse = -1;
                Invalidate();
                base.OnMouseLeave(e);
            }


        }


        #region VARIABLES
        private const int GAP_ANTI_ALLIAS = 1;
        private const int GAP_TEXT = 3;

        protected bool _isDebug = false;
        protected bool _isOver;
        protected bool _isDropDown = false;
        protected bool _isBorderVisible = true;

        private int _radius = 15;
        private int _borderSize = 2;
        private int _selectedIndex = -1;


        ERoundedType temp;

        protected ERoundedType _roundedType = ERoundedType.All;
        protected ERoundedTag _roundedTags = ERoundedTag.None;

        private GraphicsPath _gpBorder;
        private GraphicsPath _gpRegion;

        private Region _regionText;

        private SolidBrush _bFore;
        private SolidBrush _bBack;


        protected List<Tuple<string,object>> _items = new List<Tuple<string,object>>();
        private ALEComboBoxForm _form;

        public bool IsDebug { get => _isDebug; set { _isDebug = value; UpdateRegion(); } }
        public bool IsBorderVisible { get => _isBorderVisible; set { _isBorderVisible = value; Invalidate(); } }

        public int Radius { get => _radius; set { _radius = value; UpdateRegion(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; UpdateRegion(); } }
        public int SelectedIndex { get => _selectedIndex; set { _selectedIndex = value; Invalidate(); } }

        public ERoundedType RoundedType { get => _roundedType; set { _roundedType = value; UpdateRegion(); } }
        public ERoundedTag RoundedTags { get => _roundedTags; set { _roundedTags = value; UpdateRegion(); } }
        #endregion

        // constructor
        public ALEComboBox()
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
            this.SetStyle(ControlStyles.FixedHeight, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.CacheText, false);
            this.SetStyle(ControlStyles.EnableNotifyMessage, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UseTextForAccessibility, false);

            _bFore = new SolidBrush(ForeColor);
            _bBack = new SolidBrush(BackColor);
            UpdateRegion();

        }


        protected virtual void UpdateRegion()
        {
            Rectangle r = DisplayRectangle;
            r.Inflate(-GAP_ANTI_ALLIAS, -GAP_ANTI_ALLIAS);
            _gpRegion = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, DisplayRectangle, -GAP_ANTI_ALLIAS);

            _gpBorder = ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize);

            _regionText = new Region(ALEDrawingHelper.GenerateBorder(_roundedType, _roundedTags, _radius, r, _borderSize));

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

                if (_isOver)
                    _bBack.Color = ALEToolsUtility.AyoHoverGray;
                else
                    _bBack.Color = ALEToolsUtility.AyoBackGray1;

                _bFore.Color = ALEToolsUtility.AyoLightGray;
            }
            else
            {
                _bBack.Color = ALEToolsUtility.AyoHoverGray;
                _bFore.Color = ALEToolsUtility.AyoLightGray;
            }

            // back
            pevent.Graphics.FillPath(_bBack,  _gpBorder);


            // text 
            string t;
            if (_selectedIndex >= 0 && _selectedIndex < _items.Count)
            {
                string str = _items[_selectedIndex].Item1;
                pevent.Graphics.Clip = _regionText;
                Size s = TextRenderer.MeasureText(str, this.Font);
                Rectangle r = DisplayRectangle;
                r.Inflate(-(_borderSize + _radius / 2), -(_borderSize + _radius / 2));
                Point p = new Point(_borderSize + GAP_ANTI_ALLIAS, (Height - s.Height) / 2);
                pevent.Graphics.DrawString(str, this.Font, _bFore, p);
            }

            DrawDrop(pevent.Graphics,_isDropDown);

            // border
            pevent.Graphics.Clip = new Region(DisplayRectangle);
            if (_isBorderVisible)
                pevent.Graphics.DrawPath(new Pen(_bFore, _borderSize), _gpBorder);
        }



        private void DrawDrop(Graphics g,bool isDropDown)
        {
            RectangleF rect = new RectangleF(Width-Height, 0, Height, Height);

            float up = (3f / 8f) * rect.Height;
            float down = (5f / 8f) * rect.Height;

            Point A = new PointF((2f / 8f) * rect.Width, isDropDown?down:up).ToPoint();
            Point vertex = new PointF((4f / 8f) * rect.Width, isDropDown ? up : down).ToPoint();
            Point B = new PointF((6f / 8f) * rect.Width, isDropDown ? down : up).ToPoint();

            A.Offset(rect.Location.ToPoint());
            B.Offset(rect.Location.ToPoint());
            vertex.Offset(rect.Location.ToPoint());



            Pen p = new Pen(_bFore, _borderSize);
            p.EndCap = LineCap.Round;
            p.StartCap = LineCap.Round;
            g.DrawLine(p, A,vertex);
            g.DrawLine(p, B,vertex);
        }




        protected override void OnMouseEnter(EventArgs e)
        {
            _isOver = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isOver = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            _isDropDown = true;
            var p = this.PointToScreen(new Point(0,Height-2*(GAP_ANTI_ALLIAS+_borderSize)));
            ERoundedType temp = RoundedType;
            RoundedType= ERoundedType.Top;


            _form = new ALEComboBoxForm();
            _form.StartPosition = FormStartPosition.Manual;
            _form.Font= Font;
            _form.BorderSize = _borderSize;
            _form.Radius = _radius;
            _form.SetDesktopLocation(p.X,p.Y);
            _form.Width = Width;
            _form.SelectedIndex = _selectedIndex;
            _form.FormClosing -= Form_FormClosed;
            _form.FormClosing += Form_FormClosed;
            _form.SetData(_items.Select(x => x.Item1).ToArray());
            _form.Show();
        }


        
        protected override void OnFontChanged(EventArgs e)
        {
            this.Height = TextRenderer.MeasureText("I", Font).Height + 2 * (_borderSize + GAP_ANTI_ALLIAS + GAP_TEXT);
            base.OnFontChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }



        private void Form_FormClosed(object? sender, EventArgs e)
        {
            RoundedType = temp;
            _isDropDown = false;
            _selectedIndex = _form.SelectedIndex;
            Refresh();
            SelectedIndexChanged?.Invoke(this, new EventArgs<int>(_selectedIndex));
        }



        public void Add(string optionName, object value = null)
        {
            _items.Add(new Tuple<string, object>(optionName, value));
        }

        public void AddRange(IEnumerable<Tuple<string,object>> items)
        {
            _items.AddRange(items);
        }


        public void Remove(string optionName)
        {
            int i = _items.FindIndex(x=> x.Item1 == optionName);
            RemoveAt(i);
        }

        public void RemoveAt(int index)
        {
            if (index == -1)
                return;

            _items.RemoveAt(index);
        }

        public void Clear()
        {
            _items.Clear();
        }

    }



}
