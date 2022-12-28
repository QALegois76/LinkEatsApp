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
        public FormTest()
        {
            InitializeComponent();
            float value = (float)(aleScrollBarH.Value - aleScrollBarH.Minimum) / (float)(aleScrollBarH.Maximum - aleScrollBarH.Minimum);
            aleProgressH.PourcentValue = value;
            aleProgressH.IsTextVisisble = true;
            aleProgressH.Text = Math.Round(value * 100, 2).ToString() + "%";
            aleProgressV.PourcentValue = (float)(aleScrollBarV.Value - aleScrollBarV.Minimum) / (float)(aleScrollBarV.Maximum - aleScrollBarV.Minimum);

            aleCombobox.Add("Item1");
            aleCombobox.Add("Item2");
            aleCombobox.Add("Item3");
            aleCombobox.Add("Item4");
            aleCombobox.Add("Item5");
            aleCombobox.Add("Item6");
        }

        private void aleScrollBarH_Load(object sender, EventArgs e)
        {
            float value = (float)(aleScrollBarH.Value - aleScrollBarH.Minimum) / (float)(aleScrollBarH.Maximum - aleScrollBarH.Minimum);
            aleProgressH.PourcentValue = value;
            aleProgressH2.PourcentValue = value;
            aleProgressH.IsTextVisisble = true;
            aleProgressH.Text = Math.Round(value*100,2).ToString() + "%";
        }

        private void aleScrollBarV_Load(object sender, EventArgs e)
        {
            aleProgressV.PourcentValue = (float)(aleScrollBarV.Value - aleScrollBarV.Minimum) / (float)(aleScrollBarV.Maximum - aleScrollBarV.Minimum);
        }
    }
}
