namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionRoundedButon : ALEColDefinitionBase
    {
        public ALEColDefinitionRoundedButon(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            ALERoundedButton button = new ALERoundedButton();
            return new ALEColButton(Title, button);
        }
    }



}
