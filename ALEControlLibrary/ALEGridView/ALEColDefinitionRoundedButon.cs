namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionRoundedButon : ALEColDefinitionButon
    {
        public ALEColDefinitionRoundedButon(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            ALERoundedButton button = new ALERoundedButton();
            return new ALEColRoundedButton(Title, button);
        }
    }



}
