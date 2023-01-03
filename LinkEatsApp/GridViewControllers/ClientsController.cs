using ALEControlLibrary.CTRL;
using LinkEatsApp.UC;
using ConsoleAppEntityFramework.Models;
using ConsoleAppEntityFramework;
using System.Diagnostics;

namespace LinkEatsApp.GridViewControllers
{
    // CLIENT CONTROLLER
    public class ClientsController
    {
        private const string EDIT_CLIENT = "Edition de Client";
        private const string ADD_CLIENT = "Ajout d'un nouveau Client";

        private bool _isEditingMode = false;
        private ClientMng _clientsData;
        private ClientsUICollection _clientsUI;
        private DefaultListControl _view;
        private IFormClient _formClient;

        // constructor
        public ClientsController(ClientMng clientsData, DefaultListControl view)
        {
            _clientsData = clientsData;
            _view = view;
            _clientsUI = new ClientsUICollection(_view.RowDefinition);
            _clientsUI.AddRangeData(_clientsData.GetAll());
            _clientsUI.ItemChanged += ClientsUI_ItemChanged;

            InitSearchOption();

            _view.OnAdd += View_OnAdd;
            _view.OnRemove += View_OnRemove;
            _view.OnRefresh += View_OnRefresh;
            _view.OnSearchChanged += View_OnSearchChanged;
            _view.OnFilterChanged += View_OnFilterChanged;
            _view.OnSearchOptionChanged += View_OnSearchOptionChanged;
            _view.OnScrollVBarValueChanged += View_OnScrollVBarValueChanged;

            _view.RowCollection = _clientsUI;
            UpdateScrollVBar();
        }


        private void UpdateScrollVBar()
        {
            _view.ScrollMin = 0;
            _view.ScrollMax = _clientsUI.DataCount - _clientsUI.RowCount + 2;
        }

        private void View_OnRefresh(object? sender, EventArgs e)
        {
            _clientsUI.ClearData();
            _clientsUI.AddRangeData(_clientsData.GetAll());
            UpdateScrollVBar();
        }

        private void InitSearchOption()
        {
            List<string> searchOption =new List<string>();
            var props = typeof(Client).GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(string))
                {
                    searchOption.Add(prop.Name);
                }
            }
            _view.SetOption(searchOption.ToArray());
        }

        private void ClientsUI_ItemChanged(object? sender, ALEGridViewChengedEventArgs e)
        {
            if (e.ColTitle == ClientsUICollection.ECol.Edit.ToString())
            {
                _isEditingMode = true;
                Client c = _clientsUI.GetData(e.Index);
                _formClient = CreateForm(EDIT_CLIENT, c);
                SetForm(c);

                (_formClient as Form).StartPosition = FormStartPosition.CenterScreen;
                (_formClient as Form).ShowDialog();
            }
        }

        private void View_OnScrollVBarValueChanged(object? sender, EventArgs e)
        {
            _clientsUI.IndexStartData = _view.ScrollValue;
            Trace.WriteLine(_clientsUI.IndexStartData);
        }

        private void View_OnSearchOptionChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_OnFilterChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_OnSearchChanged(object? sender, EventArgs e)
        {

            throw new NotImplementedException();
        }

        private void View_OnRemove(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_OnAdd(object? sender, EventArgs e)
        {
            Client client = new Client();
            client.UserID = Guid.NewGuid();
            _formClient = CreateForm(ADD_CLIENT,client);
            SetForm(client);

            (_formClient as Form).StartPosition = FormStartPosition.CenterScreen;
            (_formClient as Form).ShowDialog();
        }

        private IFormClient CreateForm(string tiltle,Client c)
        {
            FormClient fc = new FormClient();
            fc.TitleForm = tiltle;
            fc.UserChangePassword += FormClient_UserChangePassword;
            fc.UserSaved += FormClient_UserSaved;
            (fc as Form).Tag = c;
            (fc as Form).FormClosed += ClientsController_FormClosed;
            return fc;
        }


        private void SetForm( Client client)
        {
            _formClient.FirstNameClient = client.ClientFirstName;
            _formClient.LastNameClient = client.ClientLastName;
            _formClient.LevelClient = client.ClientLevel;
            _formClient.XPClient = client.ClientCurrentXP;
            _formClient.XPNextLevelClient = client.ClientNextLevelXP;
            _formClient.WalletClient = client.ClientWallet;
            if (client.UserRegistreryToken != null)
            {
                _formClient.MailValidated = (DateTime.Now - client.UserRegistreryToken.RegistreryTokenExpiredDate).TotalDays > 0;
            }
            else
            {
                _formClient.MailValidated = false;
            }
            _formClient.EmailUser = client.UserEmail;
            _formClient.IdUser = client.UserID.ToString();
            _formClient.LoginUser = client.UserLogin;
            _formClient.PhoneUser = client.UserPhone;
            _formClient.ActifAccount = !client.RgpdObjectIsDeleted;
            _formClient.CreatedAt = client.RgpdObjectCreatedAt;
            _formClient.LastUpdatedAt = client.RgpdObjectLastWrite;
        }


        private void FormClient_UserSaved(object? sender, EventArgs e)
        {
            Client c = (_formClient as Form).Tag as Client;
            if (c == null)
                return;

            if(!_isEditingMode)
            {
                _clientsData.Add(c);
                _clientsUI.AddData(c);
            }
            (_formClient as Form).Close();
        }


        private void FormClient_UserChangePassword(object? sender, EventArgs e)
        {
            MailMng.Instance.SendMessageTo();
        }


        private void ClientsController_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _isEditingMode = false;
        }
    }
}
