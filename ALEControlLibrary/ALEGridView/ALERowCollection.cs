using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ALEControlLibrary.CTRL
{
    public class ALERowCollection
    {
        public event EventHandler<ALEGridViewChengedEventArgs> ItemChanged;
        public event NotifyCollectionChangedEventHandler RowChanged { add => _rows.CollectionChanged += value; remove => _rows.CollectionChanged -= value; }

        protected ALERowDefinition _rowDefinition;

        protected ObservableCollection<ALERow> _rows = new ObservableCollection<ALERow>();

        public int Count => _rows.Count;
        
        // constructor
        public ALERowCollection(ALERowDefinition rowDefinition)
        {
            _rowDefinition = rowDefinition;
            _rows.CollectionChanged += Rows_CollectionChanged;
        }


        public virtual ALERow AddRow()
        {
            ALERow row = _rowDefinition.CreateRow();
            row.RowChanged -= Row_RowChanged;
            row.RowChanged += Row_RowChanged;
            row.UIInvalidated -= Row_UIInvalidated;
            row.UIInvalidated += Row_UIInvalidated;
            _rows.Add(row);
            row.Invalidate();
            return row;
        }


        public virtual void RemoveRow(ALERow row)
        {
            _rowDefinition.RemoveRowCtrl(row);
            _rows.Remove(row);
        }

        public virtual void RemoveRow(Guid id)
        {
            int i = _rows.ToList().FindIndex(r => r.Id == id);
            if (i == -1)
                return;
            RemoveRow(_rows[i]);
        }

        public virtual void RemoveAtRow(int i)
        {
            RemoveRow(_rows[i]);
        }

        public virtual void Clear()
        {
            List<Guid> guids = new List<Guid>(_rows.Count);
            _rows.ToList().ForEach(r => guids.Add(r.Id));

            guids.ForEach(g => RemoveRow(g));
        }

        public virtual ALERow GetRow(int i)
        {
            if (i < 0 || i >= _rows.Count)
                return null;

            return _rows[i];
        }

        public virtual ALERow GetRow(Guid id)
        {
            return _rows.ToList().Find(r => r.Id == id);
        }

        protected virtual void UpdateUI(ALEColControl colControl) { }
   
        private void Rows_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            for (int i = 0; i < _rows.Count; i++)
            {
                _rows[i].Index = i;
            }
        }

        private void Row_RowChanged(object? sender, ALEGridViewChengedEventArgs e) => FireItemChenged(sender, e);

        protected void FireItemChenged(object? sender, ALEGridViewChengedEventArgs e) => ItemChanged?.Invoke(sender, e);
        
        protected void Row_UIInvalidated(object? sender, ALEGridViewChengedEventArgs e)
        {
            if (e.Index < 0 || e.Index >= _rows.Count)
                return;

            var row = _rows[e.Index];
            if (row == null)
                return;

            var col = row.GetCol(e.ColTitle);
            if (col == null)
                return;

            UpdateUI(col);
        }
    }
}
