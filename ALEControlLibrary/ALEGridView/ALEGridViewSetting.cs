namespace ALEControlLibrary.CTRL
{
    public class ALEGridViewSetting
    {
        internal event EventHandler OnRebuild;
        public event EventHandler<ALEGridViewChengedEventArgs> ItemChanged;

        private List<ALEColDefinitionBase> _colDefinitions = new List<ALEColDefinitionBase>();

        private List<ALERow> _rows = new List<ALERow>();

        private Control.ControlCollection _ctrls;


        // constructor
        internal ALEGridViewSetting(Control.ControlCollection ctrls)
        {
            this._ctrls = ctrls;
        }

        #region Col Def manip
        public void AddColdef(ALEColDefinitionBase colDef) => _colDefinitions.Add(colDef);

        public void RemoveColDef(ALEColDefinitionBase colDef) => _colDefinitions.Remove(colDef);

        public void RemoveAtColDef(int i) => _colDefinitions.RemoveAt(i);

        public void RemoveColDef(string title)
        {
            int i = IndexOfColDef(title);
            if (i == -1)
                return;

            RemoveAtColDef(i);
        }

        public void ClearColDef() => _colDefinitions.Clear();

        public int IndexOfColDef(string title) => _colDefinitions.FindIndex(x => x.Title == title);

        public bool Contains(string title) => IndexOfColDef(title) != -1;
        #endregion


        #region Row manipulation
        public ALERow AddRow()
        {
            Dictionary<string, ALEColControl> cols = new Dictionary<string, ALEColControl>(_colDefinitions.Count);
            _colDefinitions.ForEach(cDef => cols.Add(cDef.Title, cDef.CreateALEControl()));
            ALERow row = new ALERow(cols);
            row.RowChanged -= Row_RowChanged;
            row.RowChanged += Row_RowChanged;
            _rows.Add(row);
            cols.ToList().ForEach(col => _ctrls.Add(col.Value.Control));
            return row;
        }

        public void RemoveRow(ALERow row)
        {
            _colDefinitions.ForEach(colDef => _ctrls.Remove(row[colDef.Title].Control));
            _rows.Remove(row);
        }

        public void RemoveRow(Guid id)
        {
            int i = _rows.FindIndex(r => r.Id == id);
            if (i == -1)
                return;
            RemoveRow(_rows[i]);
        }

        public void RemoveAtRow(int i)
        {
            RemoveRow(_rows[i]);
        }

        public void Clear()
        {
            List<Guid> guids = new List<Guid>(_rows.Count);
            _rows.ForEach(r => guids.Add(r.Id));

            guids.ForEach(g => RemoveRow(g));
        }

        public ALERow GetRow(int i)
        {
            if (i < 0 || i >= _rows.Count)
                throw new IndexOutOfRangeException();

            return _rows[i];
        }

        public ALERow GetRow(Guid id)
        {
            return _rows.Find(r => r.Id == id);
        }

        #endregion

        private void Row_RowChanged(object? sender, ALEGridViewChengedEventArgs e) => ItemChanged(sender, e);

    }

    #endregion

}
