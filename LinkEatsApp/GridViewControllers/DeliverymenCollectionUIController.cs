using ALEControlLibrary.CTRL;
using ALEControlLibrary;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.Properties;

namespace LinkEatsApp.GridViewControllers
{
    // DELIVERYMEN
    public class DeliverymenUICollection : ALERowVirtualCollection<Deliveryman>
    {
        private enum ECol
        {
            Id,
            FirstName,
            LastName,
            Mail,
            Phone,
            Edit
        }

        public DeliverymenUICollection(ALERowDefinition rowDefinition) : base(rowDefinition)
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

        protected override void UpdateDataToUI(ALERow row, Deliveryman data)
        {
            row.GetCol(ECol.Id.ToString()).Text = data.UserID.ToString();
            row.GetCol(ECol.FirstName.ToString()).Text = data.DeliverymanFirstName;
            row.GetCol(ECol.LastName.ToString()).Text = data.DeliverymanLastName;
            row.GetCol(ECol.Mail.ToString()).Text = data.UserEmail;
            row.GetCol(ECol.Phone.ToString()).Text = data.UserPhone;
        }

        protected override void UpdateUIToData(ALERow row, Deliveryman data)
        {
            data.DeliverymanFirstName = row.GetCol(ECol.FirstName.ToString()).Text;
            data.DeliverymanLastName = row.GetCol(ECol.LastName.ToString()).Text;
            data.UserEmail = row.GetCol(ECol.Mail.ToString()).Text;
            data.UserPhone = row.GetCol(ECol.Phone.ToString()).Text;
        }
    }


}
