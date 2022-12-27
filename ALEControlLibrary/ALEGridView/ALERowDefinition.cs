namespace ALEControlLibrary.CTRL
{
    public class ALERowDefinition
    {
        internal event EventHandler OnRebuild;

        private int _heightRow = 50;
        private Control.ControlCollection _ctrlCollection;
        private List<ALEColDefinitionBase> _colDefinitions = new List<ALEColDefinitionBase>();

        private List<int> _colLinePos; 
        private List<int> _rowLinePos;

        public int Count => _colDefinitions.Count;
        public int Height { get => _heightRow; set { _heightRow = value; OnRebuild?.Invoke(this, EventArgs.Empty); } }
        public string[] ColTitles => _colDefinitions.Select(c => c.Title).ToArray();
        public ALEColDefinitionBase[] ColDefinitions => _colDefinitions.ToArray();
        //internal List<int> ColLinePos => _colLinePos;
        internal List<int> RowLinePos=> _rowLinePos;

        // constructor
        internal ALERowDefinition(Control.ControlCollection ctrlCollection)
        {
            _ctrlCollection = ctrlCollection;
            _colLinePos= new List<int>();
            _rowLinePos= new List<int>();
        }

        #region Methods

        public void AddColDef(ALEColDefinitionBase colDef)
        {
            _colDefinitions.Add(colDef);
            OnRebuild?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveColDef(ALEColDefinitionBase colDef)
        {
            _colDefinitions.Remove(colDef);
            OnRebuild?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveAtColDef(int i)
        {
            _colDefinitions.RemoveAt(i);
            OnRebuild?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveColDef(string title)
        {
            int i = IndexOfColDef(title);
            if (i == -1)
                return;

            RemoveAtColDef(i);
        }

        public void ClearColDef()
        {
            _colDefinitions.Clear();
            OnRebuild?.Invoke(this, EventArgs.Empty);
        }

        public int IndexOfColDef(string title)
        {
            return _colDefinitions.FindIndex(x => x.Title == title);
        }

        public bool Contains(string title)
        {
            return IndexOfColDef(title) != -1;
        }

        public ALERow CreateRow()
        {
            Dictionary<string, ALEColControl> cols = new Dictionary<string, ALEColControl>(_colDefinitions.Count);
            _colDefinitions.ForEach(cDef => cols.Add(cDef.Title, cDef.CreateALEControl()));
            cols.ToList().ForEach(col => _ctrlCollection.Add(col.Value.Control));
            ALERow row = new ALERow(cols);
            return row;
        }

        public void RemoveRowCtrl(ALERow row)
        {
            _colDefinitions.ForEach(colDef => _ctrlCollection.Remove(row.GetCol(colDef.Title).Control));
        }

        #endregion
    }
}
