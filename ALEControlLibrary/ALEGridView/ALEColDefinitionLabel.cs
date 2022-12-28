namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionLabel : ALEColDefinitionBase
    {
        public ALEColDefinitionLabel(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            Label label = new Label();
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleLeft;
            return new ALEColLabel(Title, label);
        }
    }



}
