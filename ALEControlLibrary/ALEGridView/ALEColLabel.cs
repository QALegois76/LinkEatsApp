namespace ALEControlLibrary.CTRL
{
    #region ALEControl for GridView

    public class ALEColLabel : ALEColControl
    {
        protected Label Lb => _control as Label;

        public bool AutoSize { get => Lb.AutoSize; set => Lb.AutoSize = value; }
        public bool AutoEllipsis { get => Lb.AutoEllipsis; set => Lb.AutoEllipsis = value;  }

        public ALEColLabel(string idSetting, Label label) : base(idSetting, label)
        {
        }
    }

    #endregion

}
