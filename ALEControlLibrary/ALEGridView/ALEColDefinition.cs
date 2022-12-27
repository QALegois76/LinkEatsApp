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

        /// <summary>
        /// always in absolute pixel
        /// </summary>
        internal int Position { get=> _position; set => _position = value; }
        /// <summary>
        /// if true dimension in pixel; if is false dimension is in pourcent and will be divided by 100
        /// </summary>
        public bool IsAbsolute { get=> _isAbsolute; set=> _isAbsolute = value; }
        public bool IsFixed { get=> _isFixed; set=> _isFixed = value; }
        /// <summary>
        /// can ben in absolute pixel or in pourcent (x100)
        /// </summary>
        public float ColWidth { get=> _colWidth; set=> _colWidth = value; }
        public float ColMinWidth { get => _minSize; set => _minSize = value; }
        public string Title { get=> _title; set => _title = value; }

        public ALEColDefinitionBase(string title)
        {
            _title = title;
        }

        public abstract ALEColControl CreateALEControl();      
    }
}
