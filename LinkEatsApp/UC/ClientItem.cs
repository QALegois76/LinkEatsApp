using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkEatsApp.UC
{
    public partial class ClientItem : UserControl
    {
        public string ID { get => rgrp_client.Text; set => rgrp_client.Text = value; }
        public string FirstName { get => lb_firstName.Text; set => lb_firstName.Text = value; }
        public string LastName { get => lb_lastName.Text; set => lb_lastName.Text = value; }

        public event EventHandler OnDelete;

        public ClientItem()
        {
            InitializeComponent();
        }

        private void aleRoundedButton1_Click(object sender, EventArgs e) => OnDelete?.Invoke(this, e);
    }
}
