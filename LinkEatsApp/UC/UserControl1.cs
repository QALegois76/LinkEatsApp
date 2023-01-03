using ALEControlLibrary;
using ALEControlLibrary.CTRL;
using ConsoleAppEntityFramework;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.UC;
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
    public partial class UserControl1 : UserControl
    {
        DatabaseMng databaseMng;

        public UserControl1()
        {
            InitializeComponent();

            tb_firstName_tile.Text = "First name :";
            tb_lastName_title.Text = "Last name :";

        }

        private void aleScrollBar1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void aleRoundedButton1_Click(object sender, EventArgs e)
        {
            databaseMng = DatabaseMng.Instance;
            UpdateClients();
        }

        private void aleRoundedButton2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientFirstName = tb_firstName.Text;
            client.ClientLastName = tb_lastName.Text;
            client.UserEmail = tb_mail.Text;
            client.UserLogin = tb_login.Text;
            client.UserPassword = tb_pwd.Text;
            client.UserRegistreryToken = new RegistreryToken();
            client.UserRegistreryToken.RegistreryTokenID = Guid.NewGuid();
            client.UserRegistreryToken.RegistreryTokenEnabled = false;
            client.UserRegistreryToken.RegistreryTokenExpiredDate= DateTime.Now;
            databaseMng.Clients.Add(client);
            databaseMng.Save();
            //MailMng.Instance.SendMessageTo(client.UserEmail, client.ClientFirstName + " " + client.ClientLastName);
            UpdateClients();
        }

        private void UpdateClients()
        {
            if (databaseMng == null)
            {
                MessageBox.Show("Database not connected !");
                return;
            }

            rgrp.Controls.Clear();

            var clients = databaseMng.Clients.GetAll();
            int y = 20;
            foreach (Client item in clients)
            {
                ClientItem clientItem = new ClientItem();
                rgrp.Controls.Add(clientItem);
                clientItem.Location = new Point(5,y);
                clientItem.ID = item.UserID.ToString();
                clientItem.FirstName = item.ClientFirstName;
                clientItem.LastName = item.ClientLastName;
                clientItem.OnDelete += ClientItem_OnDelete;
                y += clientItem.Height + 10;

            }
        }

        private void ClientItem_OnDelete(object? sender, EventArgs e)
        {
            Guid g = Guid.Parse((sender as ClientItem).ID);
            databaseMng.Clients.RemoveId(g);
            databaseMng.Save();
            UpdateClients();
        }
    }
}
