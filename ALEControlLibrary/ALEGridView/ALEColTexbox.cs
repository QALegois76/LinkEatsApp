namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColTexbox : ALEColControl
    {
        protected TextBox Tb => _control as TextBox;

        public bool ReadOnly { get => Tb.ReadOnly; set => Tb.ReadOnly = value; }
        public bool WordWrap { get => Tb.WordWrap; set => Tb.WordWrap = value; }


        public ALEColTexbox(string idSetting, TextBox textBox) : base(idSetting,textBox)
        {
            textBox.TextChanged += TextBox_TextChanged;

        }

        private void TextBox_TextChanged(object? sender, EventArgs e) => FireCtrlChanged();
    }

    #endregion

}
