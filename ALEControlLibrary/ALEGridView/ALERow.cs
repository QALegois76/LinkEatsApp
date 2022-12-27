namespace ALEControlLibrary.CTRL
{
    // describe a Row with his controls
    public class ALERow
    {
        public event EventHandler<ALEGridViewChengedEventArgs> RowChanged;
        public event EventHandler<ALEGridViewChengedEventArgs> UIInvalidated;

        private int _index = -1;
        //private int _position = 0;
        private Guid _id= Guid.Empty;
        private Dictionary<string, ALEColControl> _rowCtrls;

        //internal int Position { get=> _position; set => _position = value; }
        internal int Index { get => _index; set => _index = value; }
        public Guid Id  => _id; 


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
            _rowCtrls.Values.ToList().ForEach(c => UIInvalidated?.Invoke(c, new ALEGridViewChengedEventArgs(_index,c.IdSetting,_id)));
        }


        public ALEColControl GetCol(string titleCol)
        {
            if (!_rowCtrls.ContainsKey(titleCol))
                return null;
            else
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

    }
}
