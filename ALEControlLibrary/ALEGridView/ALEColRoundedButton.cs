using System.Security.Cryptography;

namespace ALEControlLibrary.CTRL
{
    public class ALEColRoundedButton : ALEColButton
    {
        protected ALERoundedButton Rbtn => _control as ALERoundedButton;

        public bool IsClickable { get => Rbtn.IsClickable; set => Rbtn.IsClickable = value; }
        public bool IsActivate { get => Rbtn.IsActivate; set => Rbtn.IsActivate = value;  }
        public bool IsAutoActivable { get => Rbtn.IsAutoActivable; set => Rbtn.IsAutoActivable = value; }
        public bool IsBorderVisible { get => Rbtn.IsBorderVisible; set => Rbtn.IsBorderVisible = value;  }

        public int Radius { get => Rbtn.Radius; set => Rbtn.Radius = value;  }
        public int BorderSize { get => Rbtn.BorderSize; set => Rbtn.BorderSize = value; }
        public int BorderSizeActiv { get => Rbtn.BorderSizeActiv ; set => Rbtn.BorderSizeActiv = value; }

        public float PourcentBack { get => Rbtn.PourcentBack; set => Rbtn.PourcentBack = value;  }

        public ERoundedType RoundedType { get => Rbtn.RoundedType; set => Rbtn.RoundedType = value;  }
        public ERoundedTag RoundedTags { get => Rbtn.RoundedTags; set => Rbtn.RoundedTags = value;  }

        public ALEColRoundedButton(string idSetting, ALERoundedButton button) : base(idSetting, button)
        {

        }
    }

}
