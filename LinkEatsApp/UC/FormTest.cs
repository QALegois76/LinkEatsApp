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
using System.Xml.Linq;

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
            dataCollection.AddData(testData);
            tb_id.Text = Guid.NewGuid().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataCollection.Clear();
            for (int i = 0; i < 100; i++)
            {
                TestData testData = new TestData();
                testData.Name = RegenWord(rand.Next(4, 12));
                testData.LastName = RegenWord(rand.Next(4, 12));
                dataCollection.AddData(testData);
            }
            aleScrollBar1.Minimum = 0;
            aleScrollBar1.Maximum = 100 - dataCollection.Count;
            aleScrollBar1.Value= 0;
        }
    }




    public class TestDataCollection : ALERowVirtualCollection<TestData>
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
            rowDefinition.AddColDef(new ALEColDefinitionCheckbox(ECol.Selection.ToString()) { IsAbsolute = true, ColWidth = 50 });
            rowDefinition.AddColDef(new ALEColDefinitionLabel(ECol.Id.ToString()) { IsAbsolute = false, ColWidth = 40 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Name.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionTextbox(ECol.Lastname.ToString()) { IsAbsolute = false, ColWidth = 20 });
            rowDefinition.AddColDef(new ALEColDefinitionRoundedButon(ECol.Delete.ToString()) { IsAbsolute = true, ColWidth = 50 });
        }

        protected override void UpdateUI(ALEColControl colControl)
        {

            colControl.ControlBackColor = ALEToolsUtility.AyoBackGray1;
            colControl.ControlForeColor = ALEToolsUtility.AyoLightGray;
            colControl.ControlFont = new Font("Segoe UI", 11);

            ECol col;
            if (!Enum.TryParse(colControl.IdCol, out col))
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

        protected override void UpdateDataToUI(ALERow colControl, TestData data)
        {
            colControl.GetCol(ECol.Id.ToString()).ControlText = data.Guid.ToString();
            colControl.GetCol(ECol.Name.ToString()).ControlText = data.Name.ToString();
            colControl.GetCol(ECol.Lastname.ToString()).ControlText = data.LastName.ToString();
        }

        protected override void UpdateUIToData(ALERow colControl, TestData data)
        {
            data.Name = colControl.GetCol(ECol.Name.ToString()).ControlText;
            data.LastName = colControl.GetCol(ECol.Lastname.ToString()).ControlText;
        }
    }




    public class TestData
    {
        public Guid Guid { get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
