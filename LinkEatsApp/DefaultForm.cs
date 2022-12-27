using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkEatsApp
{
    public partial class DefaultForm : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;

        private bool _isMoving = false;
        private Point _offsetLoc = new Point();

        public string Title { get => lb_title.Text; set=> lb_title.Text = value; }


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

        //condstructor
        public DefaultForm()
        {
            InitializeComponent();
        }


        private void rbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_max_Click(object sender, EventArgs e)
        {
            ChangeWindowState();
        }

        private void ChangeWindowState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void rbtn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void HeaderMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
                this.SetDesktopLocation(Cursor.Position.X - _offsetLoc.X, Cursor.Position.Y - _offsetLoc.Y);
        }

        private void HeaderUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
        }

        private void HeaderDown(object sender, MouseEventArgs e)
        {
            _isMoving= true;
            _offsetLoc = this.PointToClient((sender as Control).PointToScreen(e.Location));
        }

        private void HeaderDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeWindowState();
        }

    }
}
