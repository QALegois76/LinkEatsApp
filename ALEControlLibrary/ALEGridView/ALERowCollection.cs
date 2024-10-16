﻿using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ALEControlLibrary.CTRL
{
    public class ALERowCollection
    {
        internal event EventHandler RefreshGrigView;
        public event EventHandler<ALEGridViewChengedEventArgs> ItemChanged;
        public event NotifyCollectionChangedEventHandler RowCollectionChanged { add => _rows.CollectionChanged += value; remove => _rows.CollectionChanged -= value; }

        protected ALERowDefinition _rowDefinition;

        protected ObservableCollection<ALERow> _rows = new ObservableCollection<ALERow>();

        /// <summary>
        /// return the number of rows in case of virtuallist it's return the max row
        /// </summary>
        public int RowCount => _rows.Count;
        
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
            RemoveAtRow(i);
        }

        public virtual void RemoveAtRow(int i)
        {
            if (i < 0)
                return;
            if (i >= _rows.Count)
                return;
            if (_rows.Count == 0)
                return;

            _rowDefinition.RemoveRowCtrl(_rows[i]);
            _rows.RemoveAt(i);
        }

        internal virtual void ClearRow()
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

        internal virtual void SetMaxRow(int n)
        {
            if (RowCount> 0)
                ClearRow();
            for (int i = 0; i < n; i++)
            {
                ALERow row = AddRow();
                row.IsVisible = false;
            }
        }

        private void Rows_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            for (int i = 0; i < _rows.Count; i++)
            {
                _rows[i].Index = i;
            }
        }

        private void Row_RowChanged(object? sender, ALEGridViewChengedEventArgs e) => FireItemChenged(sender, e);

        protected void FireItemChenged(object? sender, ALEGridViewChengedEventArgs e) => ItemChanged?.Invoke(sender, e);
        
        protected virtual void Row_UIInvalidated(object? sender, ALEGridViewChengedEventArgs e)
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

        protected internal void Fire_RefreshGrigView() => RefreshGrigView?.Invoke(this, EventArgs.Empty);
    }





    public abstract class ALERowVirtualCollection<TData> : ALERowCollection where TData : class
    {

        protected List<TData> _datas= new List<TData>();

        protected int _indexStartData = 0;

        public int DataCount => _datas.Count;
        public int IndexStartData { get => _indexStartData; set { _indexStartData = value; UpdateDataToUI(); } }

        // constructor
        protected ALERowVirtualCollection(ALERowDefinition rowDefinition) : base(rowDefinition)
        {
            this.ItemChanged += RowCollection_ItemChanged;
            this.RowCollectionChanged += RowCollection_RowCollectionChanged;
        }


        private void RowCollection_RowCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateDataToUI();
        }

        private void RowCollection_ItemChanged(object? sender, ALEGridViewChengedEventArgs e)
        {
            ALERow row = GetRow(e.Id);
            if (row.Index < 0 || row.Index > _datas.Count) 
                return;

           UpdateUIToData(row, _datas[row.Index]);
        }

        public virtual void AddData(TData data)
        {
            _datas.Add(data);
            UpdateDataToUI();
        }
        
        public virtual void AddRangeData(IEnumerable<TData> datas)
        {
            _datas.AddRange(datas);
            UpdateDataToUI();
        }

        public virtual void RemoveData(TData data)
        {
            _datas.Remove(data);
            UpdateDataToUI();
        }

        public virtual void RemoveDataAt(int i)
        {
            _datas.RemoveAt(i);
            UpdateDataToUI();
        }

        public virtual void ClearData()
        {
            _datas.Clear();
            UpdateDataToUI();
        }

        public virtual TData GetData(int i)
        {
            if (i < 0 || i >= _datas.Count)
                return null;

            return _datas[i];
        }


        protected override void Row_UIInvalidated(object? sender, ALEGridViewChengedEventArgs e)
        {
            // we are in virtual list, the index does'nt correspond to the index of the rwo but of the data
            if (e.Index - _indexStartData < 0 || e.Index - _indexStartData >= _rows.Count-1)
                return;

            var row = _rows[e.Index - _indexStartData];
            if (row == null)
                return;

            var col = row.GetCol(e.ColTitle);
            if (col == null)
                return;

            UpdateUI(col);
        }

        protected void UpdateDataToUI()
        {
            for (int i = 0; i <  RowCount; i++)
            {
                ALERow row = GetRow(i);
                if (_indexStartData+i>=0 && _indexStartData + i < _datas.Count)
                {
                    row.IsVisible= true;
                    row.Index = _indexStartData+i;
                    TData d = _datas[_indexStartData + i];
                    row.IsSettingValues= true;
                    UpdateDataToUI(row, d);
                    row.Invalidate();
                    row.IsSettingValues= false;
                }
                else
                {
                    row.Index = -1;
                    row.IsVisible= false;
                }
            }
            Fire_RefreshGrigView();
        }

        /// <summary>
        /// call to update the UI
        /// </summary>
        /// <param name="colControl"></param>
        /// <param name="data"></param>
        protected abstract void UpdateDataToUI(ALERow colControl, TData data);

        /// <summary>
        /// call to update the model
        /// </summary>
        /// <param name="colControl"></param>
        /// <param name="data"></param>
        protected abstract void UpdateUIToData(ALERow row, TData data);
        protected override void UpdateUI (ALEColControl colControl) { }
    }
}
