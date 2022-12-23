namespace ALEControlLibrary
{
    public interface ISelectable
    {
        event EventHandler SelectStateChanged;

        bool IsSelected { get; set; }
        bool IsAutoSelectable { get; set; }
    }
}