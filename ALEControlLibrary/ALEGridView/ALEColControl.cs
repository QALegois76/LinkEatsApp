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
        protected bool _isSettingValues = false;
        #endregion


        #region attibutes
        internal Control Control => _control;
        internal bool IsSettingValues { get => _isSettingValues; set =>  _isSettingValues = value;}
        
        public bool Enable { get => _control.Enabled; set=> _control.Enabled = value; }
        public bool Visible { get => _control.Visible; set=> _control.Visible = value; }
        public string Text { get => _control.Text; set => _control.Text = value;  }

        public ImageLayout BackgroundImageLayout { get => _control.BackgroundImageLayout; set => _control.BackgroundImageLayout = value; }

        public Color ForeColor { get => _control.ForeColor; set => _control.ForeColor = value; }
        public Color BackColor { get => _control.BackColor; set => _control.BackColor = value;  }
        
        public Image BackgroundImage { get => _control.BackgroundImage; set => _control.BackgroundImage = value; }
        public Font Font { get => _control.Font; set => _control.Font = value; }
        
        public string IdCol => _idCol;
        
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

        protected void FireCtrlChanged()
        {
            if (_isSettingValues)
                return;
            ValueChanged?.Invoke(this, new EventArgs<string>(_idCol));
        }
    }

    #endregion

}
