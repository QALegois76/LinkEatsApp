namespace ALEControlLibrary.CTRL
{
    public class ALEColDefinitionCombobox : ALEColDefinitionBase
    {
        public ALEColDefinitionCombobox(string title) : base(title)
        {
        }

        public override ALEColControl CreateALEControl()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            return new ALEColCombobox(Title, comboBox);
        }
    }



}
