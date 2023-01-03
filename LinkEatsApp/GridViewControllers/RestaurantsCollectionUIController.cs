using ALEControlLibrary.CTRL;
using ALEControlLibrary;
using ConsoleAppEntityFramework.Models;
using LinkEatsApp.Properties;

namespace LinkEatsApp.GridViewControllers
{
    // RESTAURANT
    public class RestaurantsUICollection : ALERowVirtualCollection<Restaurant>
    {
        private enum ECol
        {
            Id,
            Siret,
            Name,
            Siren,
            Mail,
            Phone,
            Edit
        }

        public RestaurantsUICollection(ALERowDefinition rowDefinition) : base(rowDefinition)
        {
            rowDefinition.Height = 50;
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Id.ToString()) { IsAbsolute = false, ColWidth = 30 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Name.ToString()) { IsAbsolute = false, ColWidth = 10 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Siret.ToString()) { IsAbsolute = false, ColWidth = 10 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Siren.ToString()) { IsAbsolute = false, ColWidth = 10 });
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
                case ECol.Siren:
                case ECol.Siret:
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
                        colRButton.Text = "";
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

        protected override void UpdateDataToUI(ALERow row, Restaurant data)
        {
            row.GetCol(ECol.Id.ToString()).Text = data.UserID.ToString();
            row.GetCol(ECol.Name.ToString()).Text = data.RestaurantName;
            row.GetCol(ECol.Siren.ToString()).Text = data.RestaurantSiren;
            row.GetCol(ECol.Siret.ToString()).Text = data.RestaurantSiret;
            row.GetCol(ECol.Mail.ToString()).Text = data.UserEmail;
            row.GetCol(ECol.Phone.ToString()).Text = data.UserPhone;
        }

        protected override void UpdateUIToData(ALERow row, Restaurant data)
        {
            data.RestaurantName = row.GetCol(ECol.Name.ToString()).Text;
            data.RestaurantSiret = row.GetCol(ECol.Siret.ToString()).Text;
            data.RestaurantSiren = row.GetCol(ECol.Siren.ToString()).Text;
            data.UserEmail = row.GetCol(ECol.Mail.ToString()).Text;
            data.UserPhone = row.GetCol(ECol.Phone.ToString()).Text;
        }
    }


}
