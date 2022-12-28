namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColCombobox : ALEColControl
    {
        public int SelectedIndex { get => (_control as ComboBox).SelectedIndex; set => (_control as ComboBox).SelectedIndex = value; }
        public object SelectedValue { get => (_control as ComboBox).SelectedValue; set => (_control as ComboBox).SelectedValue = value; }

        public ALEColCombobox(string idSetting, ComboBox comboBox) : base(idSetting, comboBox)
        {
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e) => FireCtrlChanged();

        public void SetList(IEnumerable<Tuple<string,object>> diplayValue)
        {
            ComboBox cmb = _control as ComboBox;
            
            cmb.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
            cmb.DisplayMember = nameof(Tuple<string, object>.Item1);
            cmb.DisplayMember = nameof(Tuple<string, object>.Item2);
            cmb.DataSource = diplayValue;
            cmb.SelectedIndex = 0;
            cmb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }
    }

    #endregion

}
