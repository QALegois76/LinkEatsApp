namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionCheckbox : ALEColDefinitionBase
    {
        public ALEColDefinitionCheckbox(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            ALERoundedCheckbox checkbox = new ALERoundedCheckbox();
            checkbox.AutoCheck = true;
            return new ALEColCheckbox(Title, checkbox);
        }
    }



}
