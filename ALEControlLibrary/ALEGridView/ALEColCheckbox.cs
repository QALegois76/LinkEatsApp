namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColCheckbox : ALEColControl
    {
        public bool Checked { get => (_control as CheckBox).Checked; set =>(_control as CheckBox).Checked = value; }

        public ALEColCheckbox(string idSetting, CheckBox checkBox) : base(idSetting, checkBox)
        {
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e) => FireCtrlChanged();
    }

    #endregion

}
