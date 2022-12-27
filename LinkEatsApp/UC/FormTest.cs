using ALEControlLibrary;
using ALEControlLibrary.CTRL;
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
    public partial class FormTest : Form
    {
        Random rand = new Random();
        List<string> list = new List<string>(26) {"a","b","c","d","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",};
        
        TestDataCollection dataCollection;



        public FormTest()
        {
            InitializeComponent();

            dataCollection = new TestDataCollection(aleGridView1.RowDefinition);
            aleGridView1.RowCollection = dataCollection;

            tb_id.Text = Guid.NewGuid().ToString();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            tb_id.Text = Guid.NewGuid().ToString();
            tb_lastName.Text = RegenWord(rand.Next(4,12));
            tb_name.Text = RegenWord(rand.Next(4,12));
        }

        private string RegenWord(int len)
        {
            StringBuilder outout = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                outout.Append(list[rand.Next(list.Count)]);
            }
            return outout.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TestData testData = new TestData() { Guid = Guid.Parse(tb_id.Text),Name = tb_name.Text, LastName = tb_lastName.Text };
            dataCollection.Add(testData);
            tb_id.Text = Guid.NewGuid().ToString();
        }
    }




    public class TestDataCollection : ALERowCollection
    {

        enum ECol
        {
            Selection,
            Id,
            Name,
            Lastname,
            Delete
        }

        // constructor
        public TestDataCollection(ALERowDefinition rowDefinition) : base(rowDefinition)
        {
            rowDefinition.Height = 50;
            rowDefinition.AddColDef(new ALEColDefinitionCheckbox(ECol.Selection.ToString()) { IsAbsolute = true, ColWidth = 50});
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Id.ToString()) { IsAbsolute = false, ColWidth = 40 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Name.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Lastname.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionRoundedButon(ECol.Delete.ToString()) { IsAbsolute = true, ColWidth = 50 });
        }

        public void Add(TestData testData)
        {
            ALERow row = base.AddRow();
            (row.GetCol(ECol.Id.ToString()) as ALEColLabel).ControlText = testData.Guid.ToString();
            (row.GetCol(ECol.Name.ToString()) as ALEColTexbox).ControlText = testData.Name.ToString();
            (row.GetCol(ECol.Lastname.ToString()) as ALEColTexbox).ControlText = testData.LastName.ToString();
        }

        public void Remove(Guid id)
        {
            foreach (ALERow row in _rows)
            {
                ALEColControl colCtrl = row.GetCol(ECol.Id.ToString());
                if (colCtrl is ALEColLabel)
                {
                    Guid g;
                    if (Guid.TryParse((colCtrl as ALEColLabel).ControlText, out g))
                    {
                        if (g == id)
                            base.RemoveRow(row.Id);
                    }
                }
            }

        }

        protected override void UpdateUI(ALEColControl colControl)
        {

            colControl.ControlBackColor = ALEToolsUtility.AyoBackGray1;
            colControl.ControlForeColor = ALEToolsUtility.AyoLightGray;
            colControl.ControlFont = new Font("Segoe UI", 11);

            ECol col;
            if (!Enum.TryParse(colControl.IdSetting,out col))
                return;

            switch (col)
            {
                case ECol.Selection:
                    break;
                case ECol.Id:
                case ECol.Name:
                case ECol.Lastname:
                    break;
                case ECol.Delete:
                    break;
                default:
                    break;
            }

        }
    }




    public class TestData
    {
        public Guid Guid { get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
