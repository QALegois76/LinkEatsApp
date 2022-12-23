namespace ALEControlLibrary
{
    public interface IActivable
    {
        event EventHandler ActivStateChanged;

        bool IsActivate { get; set; }
        bool IsAutoActivable { get; set; }
    }
}