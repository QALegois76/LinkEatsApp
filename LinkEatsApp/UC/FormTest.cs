﻿using ALEControlLibrary;
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

            aleScrollBar1.Minimum = 0;
            aleScrollBar1.Maximum = dataCollection.DataCount - dataCollection.RowCount+2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataCollection.ClearData();
            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 100; i++)
            {
                TestData testData = new TestData();
                testData.Guid = Guid.NewGuid();
                testData.Name = RegenWord(rand.Next(4, 12));
                testData.LastName = i.ToString();
                list.Add(testData);
            }

            dataCollection.AddRangeData(list);

            aleScrollBar1.Minimum = 0;
            aleScrollBar1.Maximum = dataCollection.DataCount - dataCollection.RowCount+2;
            aleScrollBar1.Value= 0;
        }

        private void aleScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            dataCollection.IndexStartData = aleScrollBar1.Value;
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
            rowDefinition.AddColDef(new ALEColDefinitionButon(ECol.Delete.ToString()) { IsAbsolute = true, ColWidth = 50 });
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
                case ECol.Selection:
                    break;
                case ECol.Id:
            colControl.Font = new Font("Segoe UI", 8);
                    break;
                case ECol.Name:
                case ECol.Lastname:
            colControl.Font = new Font("Segoe UI", 11);
                    break;
                case ECol.Delete:
                    break;
                default:
                    break;
            }

        }

        protected override void UpdateDataToUI(ALERow row, TestData data)
        {

            row.GetCol(ECol.Id.ToString()).Text = data.Guid.ToString();
            row.GetCol(ECol.Name.ToString()).Text = data.Name.ToString();

            string lstNm = data.LastName;
            ALEColControl colC = row.GetCol(ECol.Lastname.ToString());
            colC.Text = lstNm;
            row.GetCol(ECol.Lastname.ToString()).Text = data.LastName.ToString();
        }

        protected override void UpdateUIToData(ALERow colControl, TestData data)
        {
            data.Name = colControl.GetCol(ECol.Name.ToString()).Text;
            data.LastName = colControl.GetCol(ECol.Lastname.ToString()).Text;
        }
    }




    public class TestData
    {
        public Guid Guid { get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
