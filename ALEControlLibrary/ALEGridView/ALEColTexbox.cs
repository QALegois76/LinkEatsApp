namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColTexbox : ALEColControl
    {

        public ALEColTexbox(string idSetting, TextBox textBox) : base(idSetting,textBox)
        {
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object? sender, EventArgs e) => FireCtrlChanged();
    }

    #endregion

}
