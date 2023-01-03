using ALEControlLibrary;
using ConsoleAppEntityFramework;
using LinkEatsApp.GridViewControllers;
using LinkEatsApp.UC;

namespace LinkEatsApp
{
    public class MainFormController
    {
        private enum EMenuTag
        {
            None,
            MainMenu,
            Clients,
            Deliverymen,
            Restaurants,
            Orders,
            Dishes,
            Logs,
            Settings
        }

        private EMenuTag _activTag;

        private MainForm _mainForm;
        private DatabaseMng _dbMng;


        private Dictionary<EMenuTag, Control> _optionMenu = new Dictionary<EMenuTag, Control>();


        private ClientsController _clientsController;
        private DeliverymenUICollection _deliverymenCollectionUIController;
        private RestaurantsUICollection _restaurantsCollectionUIController;
        private OrdersUICollection _ordersCollectionUIController;


        private EMenuTag ActivMenu { get => _activTag; set { _activTag = value; UpdatedActivView(); } }


        // constructor
        public MainFormController(MainForm mainForm, DatabaseMng database)
        {
            _dbMng = database;
            _mainForm = mainForm;

            _mainForm.OptionSelected += MainForm_OptionSelected;

            InitiailizeElements();

            ActivMenu = EMenuTag.MainMenu;
        }

        private void MainForm_OptionSelected(object? sender, EventArgs<object> e)
        {
            if (e.Value == null)
            {
                ActivMenu = EMenuTag.None;
                return;
            }

            try
            {
                ActivMenu = (EMenuTag)e.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : this option is not recognised");
                ActivMenu = EMenuTag.None;
            }
               
        }

        private void InitiailizeElements()
        {
            _mainForm.ClearOption();

            // main form
            MainMenu mainMenu = new MainMenu();
            _mainForm.AddOption("Main Menu", EMenuTag.MainMenu, mainMenu);
            _optionMenu.Add(EMenuTag.MainMenu, mainMenu);


            // clients
            DefaultListControl listClient = new DefaultListControl();
            //_clientsCollectionUIController = new ClientsUICollection(listClient.RowDefinition);
            _clientsController = new ClientsController(_dbMng.Clients, listClient);
            _mainForm.AddOption("Clients", EMenuTag.Clients, listClient);
            _optionMenu.Add(EMenuTag.Clients, listClient);


            // deliverymen
            DefaultListControl listDeliverymen = new DefaultListControl();
            //_clientsCollectionUIController = new ClientsUICollection(listDeliverymen.RowDefinition);
            _mainForm.AddOption("Delicerymen", EMenuTag.Deliverymen, listDeliverymen);
            _optionMenu.Add(EMenuTag.Deliverymen, listDeliverymen);


            // restaurants
            DefaultListControl resataurantList = new DefaultListControl();
            //_clientsCollectionUIController = new ClientsUICollection(resataurantList.RowDefinition);
            _mainForm.AddOption("Restaurant", EMenuTag.Restaurants, resataurantList);
            _optionMenu.Add(EMenuTag.Restaurants, resataurantList);


            // orders
            DefaultListControl orderList = new DefaultListControl();
            //_clientsCollectionUIController = new ClientsUICollection(orderList.RowDefinition);
            _mainForm.AddOption("Orders", EMenuTag.Orders, orderList);
            _optionMenu.Add(EMenuTag.Orders, orderList);
        }


        private void UpdatedActivView()
        {
            _optionMenu.ToList().ForEach(x =>
            {
                x.Value.Visible = x.Key == _activTag;

                if (x.Value.Visible)
                    x.Value.BringToFront();
            });
        }
    }
}