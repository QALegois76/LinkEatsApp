using ALEControlLibrary.CTRL;
using LinkEatsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkEatsApp.UC
{
    public partial class DefaultListControl : UserControl
    {
        // const
        private readonly static Image IMG_FILTER_ON = Resources.Filtre_tresclair;
        private readonly static Image IMG_FILTER_OFF = Resources.Filtre_Empty_tresclair;


        // event
        public event EventHandler OnAdd;
        public event EventHandler OnRemove;
        public event EventHandler OnRefresh;
        public event EventHandler OnSearchChanged;
        public event EventHandler OnFilterChanged;
        public event EventHandler OnSearchOptionChanged;
        public event EventHandler OnScrollVBarValueChanged;

        // members
        private bool _filterActiv = false;


        #region attributes

        public bool EnableAddDelete { get => rbtn_delete.Visible; set => rbtn_delete.Visible = rbtn_add.Visible = value; }

        public int ScrollMax { get => scrlBV.Maximum; set => scrlBV.Maximum = value; }
        public int ScrollMin { get => scrlBV.Minimum; set => scrlBV.Minimum = value; }
        public int ScrollValue { get => scrlBV.Value; set => scrlBV.Value = value; }
        public int SelectedIndexOption { get => cmb_search.SelectedIndex; set=> cmb_search.SelectedIndex = value; }

        public ALERowDefinition RowDefinition => gridView.RowDefinition;
        public ALERowCollection RowCollection { get => gridView.RowCollection; set => gridView.RowCollection = value; }
        #endregion

        // constructor
        public DefaultListControl()
        {
            InitializeComponent();
            pnl_gridView.Controls.Add(gridView);
            gridView.Dock = DockStyle.Fill;
        }

        private void rbtn_delete_Click_1(object sender, EventArgs e) => OnRemove?.Invoke(this, EventArgs.Empty);

        private void rbtn_add_Click(object sender, EventArgs e) => OnAdd?.Invoke(this, EventArgs.Empty);

        private void rbtn_refresh_Click(object sender, EventArgs e)=>OnRefresh?.Invoke(this, EventArgs.Empty);

        private void tb_search_TextChanged(object sender, EventArgs e) => OnSearchChanged?.Invoke(this, EventArgs.Empty);

        private void cmb_search_SelctedIndexChanged(object sender, ALEControlLibrary.EventArgs<int> e) => OnSearchOptionChanged?.Invoke(this, EventArgs.Empty);

        private void btn_filter_state_Click(object sender, EventArgs e)
        {
            btn_filter_state.BackgroundImage = _filterActiv ? IMG_FILTER_ON : IMG_FILTER_OFF;
            OnFilterChanged?.Invoke(this, EventArgs.Empty);
        }

        private void scrlBV_ValueChanged(object sender, EventArgs e)=> OnScrollVBarValueChanged?.Invoke(this, EventArgs.Empty);
        
        private void cmb_search_SelctedIndexChanged(object sender, EventArgs e) => OnSearchOptionChanged?.Invoke(this, EventArgs.Empty);


        public void SetOption(string[] display, object[] values =null)
        {
            cmb_search.Clear();

            if (display == null || display.Length == 0)
                return;

            bool hasValue = values != null;

            if (hasValue && values.Length != display.Length)
                return;

            List<Tuple<string, object>> items = new List<Tuple<string, object>>(display.Length);
            for (int i = 0; i < display.Length; i++)
            {
                string str = display[i];
                object obj = hasValue ? values[i] : null;
                items.Add(new Tuple<string, object>(str,obj));
            }

            cmb_search.AddRange(items);
        }

    }
}
