namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColTexbox : ALEColControl
    {
        public string Text { get => _control.Text; set => _control.Text = value; }

        public ALEColTexbox(string idSetting, TextBox textBox) : base(idSetting,textBox)
        {
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object? sender, EventArgs e) => FireCtrlChanged();
    }

    #endregion

}
