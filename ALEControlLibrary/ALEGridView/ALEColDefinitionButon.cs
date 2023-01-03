namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionButon : ALEColDefinitionBase
    {
        public ALEColDefinitionButon(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            Button button = new Button();
            return new ALEColButton(Title, button);
        }
    }



}
