namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColLabel : ALEColControl
    {
        private string Text { get=> _control.Text; set => _control.Text = value; }

        public ALEColLabel(string idSetting, Label label) : base(idSetting, label)
        {
        }
    }

    #endregion

}
