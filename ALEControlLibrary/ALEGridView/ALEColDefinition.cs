namespace ALEControlLibrary.CTRL
{
    // describe how is created the différent control
    public abstract class ALEColDefinitionBase
    {
        private bool _isAbsolute = false;
        private bool _isFixed = false;
        private int _position = 0;
        private float _colWidth = 10;
        private float _minSize = 10;
        private string _title;

        internal int Position { get=> _position; set => _position = value; }
        public bool IsAbsolute { get=> _isAbsolute; set=> _isAbsolute = value; }
        public bool IsFixed { get=> _isFixed; set=> _isFixed = value; }
        public float ColWidth { get=> _colWidth; set=> _colWidth = value; }
        public float ColMinWidth { get => _minSize; set => _minSize = value; }
        public string Title { get=> _title; set => _title = value; }

        public ALEColDefinitionBase(string title)
        {
            _title = title;
        }

        public abstract ALEColControl CreateALEControl();      
    }

    public class ALEColDefinitionTextbox : ALEColDefinitionBase
    {

    }

    public class ALEColDefinitionLabel : ALEColDefinitionBase
    {

    }

    public class ALEColDefinitionButon : ALEColDefinitionBase
    {

    }

    public class ALEColDefinition : ALEColDefinitionBase
    {

    }



}
