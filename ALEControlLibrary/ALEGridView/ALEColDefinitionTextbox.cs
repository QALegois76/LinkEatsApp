namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionTextbox : ALEColDefinitionBase
    {
        public ALEColDefinitionTextbox(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            TextBox textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            return new ALEColTexbox(Title, textBox);
        }
    }



}
