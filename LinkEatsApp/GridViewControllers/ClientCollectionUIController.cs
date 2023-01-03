using ALEControlLibrary.CTRL;
using ALEControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.Properties;

namespace LinkEatsApp.GridViewControllers
{
    // CLIENT UI COLLECTION
    public class ClientsUICollection : ALERowVirtualCollection<Client>
    {
        public readonly static Image IMG_EDIT = Resources.Edit_tresclair_75px;

        public enum ECol
        {
            Id,
            FirstName,
            LastName,
            Mail,
            Phone,
            Edit
        }

        public event EventHandler<EventArgs<Guid>> OnEditClient;


        // consructor
        public ClientsUICollection(ALERowDefinition rowDefinition) : base(rowDefinition)
        {
            rowDefinition.Height = 50;
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Id.ToString()) { IsAbsolute = false, ColWidth = 30 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.FirstName.ToString()) { IsAbsolute = false, ColWidth = 15 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.LastName.ToString()) { IsAbsolute = false, ColWidth = 15 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Mail.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Phone.ToString()) { IsAbsolute = false, ColWidth = 10 });
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
                        colRButton.IsClickable = true;
                        colRButton.IsAutoActivable = false;
                        if (colControl.BackgroundImage == IMG_EDIT)
                            return;
                        colControl.BackgroundImageLayout = ImageLayout.Zoom;
                        colRButton.BackgroundImage = IMG_EDIT;
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

        protected override void UpdateDataToUI(ALERow row, Client data)
        {
            row.GetCol(ECol.Id.ToString()).Text = data.UserID.ToString();
            row.GetCol(ECol.FirstName.ToString()).Text = data.ClientFirstName;
            row.GetCol(ECol.LastName.ToString()).Text = data.ClientLastName;
            row.GetCol(ECol.Mail.ToString()).Text = data.UserEmail;
            row.GetCol(ECol.Phone.ToString()).Text = data.UserPhone;
        }

        protected override void UpdateUIToData(ALERow row, Client data)
        {
            data.ClientFirstName = row.GetCol(ECol.FirstName.ToString()).Text;
            data.ClientLastName = row.GetCol(ECol.LastName.ToString()).Text;
            data.UserEmail = row.GetCol(ECol.Mail.ToString()).Text;
            data.UserPhone = row.GetCol(ECol.Phone.ToString()).Text;
        }

    }



















    public class RestaurantController
    {

    }

    public class DeliverymenController
    {

    }



    public class OrdersController
    {

    }
}
