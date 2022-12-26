namespace ALEControlLibrary.CTRL
{
    // describe the behaviour of different control
    #region ALEControl for GridView

    public abstract class ALEColControl
    {
        public event EventHandler<EventArgs<string>> ValueChanged;

        #region members
        private readonly string _idCol;     
        protected Control _control;
        #endregion


        #region attibutes
        internal Control Control => _control;
        
        public bool ControlEnable { get => _control.Enabled; set=> _control.Enabled = value; }
        public bool ControlVisible { get => _control.Visible; set=> _control.Visible = value; }
        
        public string IdSetting => _idCol;
        
        public Size ControlSize { get => _control.Size; set=> _control.Size = value; }
        
        public Point ControlLocation { get => _control.Location; set=> _control.Location = value; }
        #endregion

        // constructor
        public ALEColControl( string idSetting, Control control)
        {
            _idCol = idSetting;
            _control = control;
        }

        protected void FireCtrlChanged() =>ValueChanged?.Invoke(this, new EventArgs<string>(_idCol));
    }

    #endregion

}
