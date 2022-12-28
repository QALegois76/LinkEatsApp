using ALEControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkEatsApp.Forms
{
    public partial class FormRestaurant : DefaultForm, IFormRestaurant
    {
        
        public event EventHandler UserSaved;
        public event EventHandler UserChangePassword;

        private bool _isModified = false;


        // attributes
        public bool ActifAccount { get => chk_actifAccount.Checked; set => chk_actifAccount.Checked = value; }
        public bool MailValidated { get => chk_emailCheck.Checked; set => chk_emailCheck.Checked = value; }

        public float RestaurantStars { get => pgrss_rate.PourcentValue; set => pgrss_rate.PourcentValue = value; }
        public float RestaurantDeliveryRange { get => float.Parse(tb_actionRange.Text); set => tb_actionRange.Text = value.ToString(); }

        public string TitleForm { get => this.Title; set => this.Title = value; }
        public string IdUser { get => tb_id.Text; set => tb_id.Text = value; }
        public string LoginUser { get => tb_login.Text; set => tb_login.Text = value; }
        public string EmailClient { get => tb_mail.Text; set => tb_mail.Text = value; }
        public string PhoneClient { get => tb_phone.Text; set => tb_phone.Text = value; }

        public string RestaurantSiret { get => tb_siret.Text; set => tb_siret.Text = value; }
        public string RestaurantSiren { get => tb_siren.Text; set => tb_siren.Text = value; }
        public string RestaurantName { get => tb_restoName.Text; set => tb_restoName.Text = value; }
        public string RestaurantIBAN { get => tb_IBAN.Text; set => tb_IBAN.Text = value; }
        
        public string RestaurantImgIdentityPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RestaurantImgBannerPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public DateTime CreatedAt { get => DateTime.Parse(lb_createdAt_value.Text); set => lb_createdAt_value.Text = value.ToString(); }
        public DateTime LastUpdatedAt { get => DateTime.Parse(lb_lastModif_value.Text); set => lb_lastModif_value.Text = value.ToString(); }


        // constructor
        public FormRestaurant()
        {
            InitializeComponent();
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            if (!AppSetting.RegexPhone.IsMatch(tb_phone.Text))
            {
                tb_phone.ForeColor = Color.Red;
            }
            else
            {
                tb_phone.ForeColor = ALEToolsUtility.AyoLightGray;
            }
            _isModified = true;
        }

        private void tb_mail_TextChanged(object sender, EventArgs e)
        {
            if (!AppSetting.RegexMail.IsMatch(tb_mail.Text))
            {
                tb_mail.ForeColor = Color.Red;
            }
            else
            {
                tb_mail.ForeColor = ALEToolsUtility.AyoLightGray;
            }
            _isModified = true;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _isModified = true;
        }


        private void rbtn_save_Click(object sender, EventArgs e) => UserSaved?.Invoke(this, EventArgs.Empty);

        private void rbtn_pwd_Click(object sender, EventArgs e) => UserChangePassword?.Invoke(this, EventArgs.Empty);
    }
}
