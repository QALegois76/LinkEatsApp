namespace ALEControlLibrary.CTRL
{
    // describe the eventArgs raise by row when a col is edited
    public class ALEGridViewChengedEventArgs :EventArgs
    {
        private readonly int _index;
        private readonly string _colTitle;
        private readonly Guid _id;

        public int Index => _index;
        public string ColTitle => _colTitle;
        public Guid Id => _id;

        public ALEGridViewChengedEventArgs(int index, string colTitle, Guid id)
        {
            _index = index;
            _colTitle = colTitle;
            _id = id;
        }
    }


}
