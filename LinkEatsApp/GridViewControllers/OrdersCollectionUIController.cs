using ALEControlLibrary.CTRL;
using ALEControlLibrary;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.Properties;

namespace LinkEatsApp.GridViewControllers
{
    // ORDERS
    public class OrdersUICollection : ALERowVirtualCollection<Order>
    {
        private enum ECol
        {
            Id,
            Client,
            Restaurant,
            Deliveryman,
            Price,
            Edit
        }

        public OrdersUICollection(ALERowDefinition rowDefinition) : base(rowDefinition)
        {
            rowDefinition.Height = 50;
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Id.ToString()) { IsAbsolute = false, ColWidth = 30 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Client.ToString()) { IsAbsolute = false, ColWidth = 15 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Restaurant.ToString()) { IsAbsolute = false, ColWidth = 15 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Deliveryman.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Price.ToString()) { IsAbsolute = false, ColWidth = 10 });
            rowDefinition.AddColDef(new ALEColDefinitionRoundedButon(ECol.Edit.ToString()) { IsAbsolute = true, ColWidth = 40 });
        }

        protected override void UpdateUI(ALEColControl colControl)
        {

            colControl.BackColor = ALEToolsUtility.AyoBackGray1;
            colControl.ForeColor = ALEToolsUtility.AyoLightGray;

            ECol col;
            if (!Enum.TryParse(colControl.IdCol, out col))
                return;

            switch (col)
            {
                case ECol.Id:
                    if(colControl is ALEColTexbox colTexbox)
                    {
                        colTexbox.ReadOnly = true;
                        colControl.Font = new Font("Segoe UI", 8);
                    }
                    break;

                case ECol.Edit:
                    if (colControl is ALEColRoundedButton colRButton)
                    {
                        colRButton.BorderSize = 2;
                        colRButton.Radius = 15;
                        colRButton.PourcentBack = 0.7f;
                        colRButton.BackgroundImage = Resources.Edit_tresclair;
                        colControl.BackgroundImageLayout = ImageLayout.Zoom;
                        colRButton.IsAutoActivable = false;
                        colRButton.IsClickable = true;
                    }
                    break;

                default:
                    if (colControl is ALEColLabel colLabel)
                    {
                        colLabel.AutoEllipsis = true;
                        colLabel.AutoSize = false;
                        colLabel.Font = new Font("Segoe UI", 11);
                    }
                    break;
            }

        }

        protected override void UpdateDataToUI(ALERow row, Order data)
        {
            row.GetCol(ECol.Id.ToString()).Text = data.OrderID.ToString();

            string strClient = "";
            string strDeliveryman = "";

            Client client = data.OrderClient;
            Deliveryman deliveryman = data.OrderDeliveryman;

            if (client != null)
            {
                strClient+= client.ClientFirstName[0].ToString().ToUpper();
                strClient += ". ";
                strClient += client.ClientLastName;
            }

            if (deliveryman != null)
            {
                strDeliveryman += deliveryman.DeliverymanFirstName[0].ToString().ToUpper();
                strDeliveryman += ". ";
                strDeliveryman += deliveryman.DeliverymanLastName;
            }

            row.GetCol(ECol.Client.ToString()).Text = strClient;
            row.GetCol(ECol.Deliveryman.ToString()).Text = strDeliveryman;

            if (data.OrderRestaurant != null)
                row.GetCol(ECol.Restaurant.ToString()).Text = data.OrderRestaurant.RestaurantName;
            else
                row.GetCol(ECol.Restaurant.ToString()).Text = "";

            row.GetCol(ECol.Price.ToString()).Text = Math.Round((float)data.OrderFinalPrice/100f,2).ToString();
        }

        protected override void UpdateUIToData(ALERow row, Order data)
        {
            // no update in data grid view
            return;
        }
    }


}
