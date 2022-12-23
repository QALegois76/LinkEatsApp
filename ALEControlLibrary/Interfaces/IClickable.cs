using System.Windows.Forms;

namespace ALEControlLibrary
{
    public interface IClickable
    {
        event EventHandler Click;
        event EventHandler MouseEnter;
        event EventHandler MouseHover;
        event EventHandler MouseLeave;
        event MouseEventHandler MouseDown;
        event MouseEventHandler MouseUp;
        event MouseEventHandler MouseMove;

        bool IsClickable { get; set; }

    }
}