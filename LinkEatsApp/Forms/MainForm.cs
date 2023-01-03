using ALEControlLibrary;
using ALEControlLibrary.CTRL;

namespace LinkEatsApp
{
    public partial class MainForm : DefaultForm
    {
        private const int HEIGHT_OPTION = 50;

        public event EventHandler<EventArgs<object>> OptionSelected;


        // construtor
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddOption(string title, object tag, Control viewCtrl)
        {
            Control c = CreateOptionMenu(title);
            int idx = pnl_menu.Controls.Count;
            c.Tag = tag;
            c.Dock = DockStyle.Top;
            pnl_menu.Controls.Add(c);
            c.Height = HEIGHT_OPTION;
            viewCtrl.Visible = false;
            viewCtrl.Dock = DockStyle.Fill;
            pnl_view.Controls.Add(viewCtrl);
            viewCtrl.Tag = tag;
            pnl_menu.Controls.SetChildIndex(c, 0);
        }

        public void ClearOption()
        {
            pnl_menu.Controls.Clear();
        }

        private Control CreateOptionMenu(string text)
        {
            ALERoundedButton btn = new ALERoundedButton();
            btn.RoundedType = ERoundedType.Right;
            btn.Radius = 15;
            btn.BorderSize = 2;
            btn.BorderSizeActiv = 3;
            btn.IsAutoActivable = false;
            btn.IsClickable = true;
            btn.IsBorderVisible = true;
            btn.Text = text;
            btn.Click += Menu_Click;
            return btn;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnl_menu.Controls)
            {
                if (c is ALERoundedButton rbtn)
                    rbtn.IsActivate = rbtn == sender;
            }
            OptionSelected?.Invoke(this, new EventArgs<object>((sender as Control).Tag));
        }

    }
}