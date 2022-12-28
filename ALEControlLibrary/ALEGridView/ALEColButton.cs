namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColButton : ALEColControl
    {
        public ALEColButton(string idSetting, Button button) : base(idSetting, button)
        {
            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e) => FireCtrlChanged();
    }

    #endregion

}
