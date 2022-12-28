namespace ALEControlLibrary.CTRL
{
    // describe a Row with his controls
    public class ALERow
    {
        public event EventHandler<ALEGridViewChengedEventArgs> RowChanged;
        public event EventHandler<ALEGridViewChengedEventArgs> UIInvalidated;

        private bool _isVisible = true;
        private bool _isSettingValues = false;
        private int _index = -1;
        private Guid _id= Guid.Empty;
        private Dictionary<string, ALEColControl> _rowCtrls;

        /// <summary>
        /// disable the event of ui changement to prevent over write the model data incomplete
        /// </summary>
        internal bool IsSettingValues { get => _isSettingValues; set {  _isSettingValues = value; UpdateColsSettingState(); } }
        internal int Index { get => _index; set => _index = value; }
        public Guid Id  => _id; 
        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                _rowCtrls.ToList().ForEach(col => col.Value.ControlVisible = value);
            }
        }

        // constructor
        internal ALERow(Dictionary<string, ALEColControl> ctrls)
        {
            _id = Guid.NewGuid();

            _rowCtrls = ctrls;

            _rowCtrls.ToList().ForEach(rCtrl => rCtrl.Value.ValueChanged += Value_ValueChanged);
            _rowCtrls.ToList().ForEach(rCtrl => rCtrl.Value.UIInvalidated += ALEColCtrl_UIInvalidated);
        }

        public void Invalidate() 
        {
            _rowCtrls.Values.ToList().ForEach(c => UIInvalidated?.Invoke(c, new ALEGridViewChengedEventArgs(_index,c.IdCol,_id)));
        }


        public ALEColControl GetCol(string titleCol)
        {
            ALEColControl col = null;
            if (!_rowCtrls.ContainsKey(titleCol))
                return null;
            return _rowCtrls[titleCol];
        }

        public ALEColControl GetCol(int idxCol)
        {
            if (idxCol < 0 || idxCol >= _rowCtrls.Count)
                return null;
            else
                return _rowCtrls.ToArray()[idxCol].Value;
        }

        private void Value_ValueChanged(object? sender, EventArgs<string> e)
        {
            ALEGridViewChengedEventArgs eventArgs;
            eventArgs = new ALEGridViewChengedEventArgs(_index, e.Value, _id);
            RowChanged?.Invoke(this, eventArgs);
        }

        private void ALEColCtrl_UIInvalidated(object? sender, EventArgs<string> e)
        {
            ALEGridViewChengedEventArgs eventArgs;
            eventArgs = new ALEGridViewChengedEventArgs(_index, e.Value, _id);
            UIInvalidated?.Invoke(this, eventArgs);
        }

        private void UpdateColsSettingState()
        {
            _rowCtrls.ToList().ForEach(col => col.Value.IsSettingValues = _isSettingValues);
        }

    }
}
