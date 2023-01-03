using ALEControlLibrary;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkEatsApp
{
    public partial class FormClient : DefaultForm , IFormClient
    {
        // const
        private static readonly Image LinkerUnChecked = Resources.LinkerVide;
        private static readonly Image LinkerChecked = Resources.LinkerPlein;
        private const string TAG_XP_LEFT = "%XP_LEFT%";
        private const string TAG_XP_NEXT = "%XP_NEXT%";
        private const string TAG_LVL_NEXT = "%XP_NEXT%";
        private const string DESCRIPTION_LVL = "Pour atteindre le niveau " + TAG_LVL_NEXT + " soit " + TAG_XP_NEXT + " il reste " + TAG_XP_LEFT + " à collecter";

        // event
        public event EventHandler UserSaved;
        public event EventHandler UserChangePassword;

        // members
        private int _xpCurent = -1;
        private int _xpNextLevel = -1;

        // attributes
        public bool ActifAccount { get => chk_actifAccount.Checked; set => chk_actifAccount.Checked = value; }
        public bool MailValidated { get => chk_emailCheck.Checked; set => chk_emailCheck.Checked = value; }
        
        public int LevelClient { get => int.Parse(lb_lvl.Text); set { lb_lvl.Text = value.ToString(); UpdateXp(); } }
        public int XPClient { get => _xpCurent; set { _xpCurent = value; UpdateXp(); } }
        public int XPNextLevelClient { get => _xpNextLevel; set { _xpNextLevel = value; UpdateXp(); } }
        public int WalletClient { get => int.Parse(tb_wallet.Text); set => tb_wallet.Text =((float)value/100f).ToString(); }
        
        public string FirstNameClient { get => tb_firstName.Text; set => tb_firstName.Text = value; }
        public string LastNameClient { get => tb_lastName.Text; set => tb_lastName.Text = value; }
        public string IdUser { get => tb_id.Text; set => tb_id.Text = value; }
        public string LoginUser { get => tb_login.Text; set => tb_login.Text = value; }
        public string EmailUser { get => tb_mail.Text; set => tb_mail.Text = value; }
        public string PhoneUser { get => tb_phone.Text; set => tb_phone.Text = value; }
        public string TitleForm { get => this.Title; set => this.Title = value; }

        public DateTime CreatedAt { get => DateTime.Parse(lb_createdAt_value.Text); set => lb_createdAt_value.Text = value.ToString(); }
        public DateTime LastUpdatedAt { get => DateTime.Parse(lb_lastModif_value.Text); set => lb_lastModif_value.Text = value.ToString(); }

        // constructor
        public FormClient()
        {
            InitializeComponent();
        }

        private void UpdateXp()
        {
            if (_xpCurent == -1)
                return;

            if (_xpNextLevel <=0)
                return;

            float pourcent = (float)_xpCurent / (float)_xpNextLevel;
            pgrss_lvl.PourcentValue= pourcent;
            pgrss_lvl.Text= Math.Round(pourcent*100f,2).ToString() + "%";

            string descrp = DESCRIPTION_LVL;
            descrp = descrp.Replace(TAG_LVL_NEXT,lb_lvl.Text);
            descrp = descrp.Replace(TAG_XP_LEFT, (_xpNextLevel - _xpCurent).ToString());
            descrp = descrp.Replace(TAG_XP_NEXT, _xpNextLevel.ToString());
            lb_lvl_description.Text= descrp;
        }


        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            if (!AppSetting.RegexPhone.IsMatch(tb_phone.Text))
            {
                tb_phone.ForeColor= Color.Red;
            }
            else
            {
                tb_phone.ForeColor= ALEToolsUtility.AyoLightGray;
            }
            rbtn_save.Enabled = true;
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
            rbtn_save.Enabled = true;
        }

        private void tb_lastName_TextChanged(object sender, EventArgs e)
        {
            rbtn_save.Enabled = true;
        }


        private void rbtn_AddWallet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TO DO");
        }

        private void rbtn_save_Click(object sender, EventArgs e)
        {
            UserSaved?.Invoke(this, EventArgs.Empty);
            rbtn_save.Enabled = false;
        }

        private void rbtn_pwd_Click(object sender, EventArgs e) => UserChangePassword?.Invoke(this, EventArgs.Empty);
        
        private void rbtn_linkerState_Click(object sender, EventArgs e)=> rbtn_linkerState.BackgroundImage = rbtn_linkerState.IsActivate? LinkerChecked: LinkerUnChecked;

    }
}
