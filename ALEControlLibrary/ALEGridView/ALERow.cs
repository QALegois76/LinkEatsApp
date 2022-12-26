namespace ALEControlLibrary.CTRL
{
    // describe a Row only UI 
    public class ALERow
    {
        public event EventHandler<ALEGridViewChengedEventArgs> RowChanged;

        private int _index = -1;
        private Guid _id= Guid.Empty;
        private Dictionary<string, ALEColControl> _rowCtrls;

        public ALEColControl this[string titleCol]
        {
            get
            {
                if (!_rowCtrls.ContainsKey(titleCol))
                    return null;
                else 
                    return _rowCtrls[titleCol];
            }
        }
        public int Index { get => _index; set => _index = value; }
        public Guid Id  => _id; 


        // constructor
        internal ALERow(Dictionary<string, ALEColControl> ctrls)
        {
            _id = Guid.NewGuid();

            _rowCtrls = ctrls;

            _rowCtrls.ToList().ForEach(rCtrl => rCtrl.Value.ValueChanged += Value_ValueChanged);
        }


        private void Value_ValueChanged(object? sender, EventArgs<string> e)
        {
            ALEGridViewChengedEventArgs eventArgs;
            eventArgs = new ALEGridViewChengedEventArgs(_index, e.Value, _id);
            RowChanged?.Invoke(this, eventArgs);
        }
    }

    #endregion

}
