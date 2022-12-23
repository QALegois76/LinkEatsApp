using ALEControlLibrary;

namespace LinkEatsApp
{
    public partial class mainForm : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;


        private bool _isMoving = false;

        private int _xLocPan = 0;
        private int _xPanClose = 0;
        private int _xPanOpen = 0;

        private Point _offsetLoc;


        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        // construtor
        public mainForm()
        {
            InitializeComponent();
            
        }


        #region METHODS

        #region header manip
        private void HeaderDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            _offsetLoc = (sender as Control).PointToClient(Cursor.Position);
        }

        private void HeaderUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
        }

        private void HeaderMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
                this.SetDesktopLocation(Cursor.Position.X - _offsetLoc.X, Cursor.Position.Y - _offsetLoc.Y);
        }
        #endregion

        #region form min / max / closing
        private void rbtn_close_Click(object sender, EventArgs e)=> this.Close();
        
        private void rbtn_min_Click(object sender, EventArgs e)=>  this.WindowState = FormWindowState.Minimized;

        private void rbtn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        #endregion


        #endregion




    }
}