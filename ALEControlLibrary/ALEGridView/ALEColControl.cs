namespace ALEControlLibrary.CTRL
{
    // describe the behaviour of different control
    #region ALEControl for GridView

    public class ALEColControl
    {
        public event EventHandler<EventArgs<string>> ValueChanged;
        public event EventHandler<EventArgs<string>> UIInvalidated;


        #region members
        private readonly string _idCol;     
        protected Control _control;
        #endregion


        #region attibutes
        internal Control Control => _control;
        
        public bool ControlEnable { get => _control.Enabled; set=> _control.Enabled = value; }
        public bool ControlVisible { get => _control.Visible; set=> _control.Visible = value; }
        public Font ControlFont { get => _control.Font; set => _control.Font = value; }
        public Color ControlForeColor { get => _control.ForeColor; set => _control.ForeColor = value; }
        public Color ControlBackColor { get => _control.BackColor; set => _control.BackColor = value;  }
        public string ControlText { get => _control.Text; set => _control.Text = value;  }
        
        public string IdSetting => _idCol;
        
        public Size ControlSize { get => _control.Size; set=> _control.Size = value; }
        
        public Point ControlLocation { get => _control.Location; set=> _control.Location = value; }
        #endregion

        // constructor
        public ALEColControl( string idCol, Control control)
        {
            _idCol = idCol;
            _control = control;
        }

        public virtual void Invalidate()=>UIInvalidated?.Invoke(this, new EventArgs<string>(_idCol));

        protected void FireCtrlChanged() =>ValueChanged?.Invoke(this, new EventArgs<string>(_idCol));
    }

    #endregion

}
