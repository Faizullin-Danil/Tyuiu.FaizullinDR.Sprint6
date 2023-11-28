using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task0.V28.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task0.V28
{
    public partial class FormMain_FDR : Form
    {
        public FormMain_FDR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPushMe_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_FDR.Text = Convert.ToString(ds.Calculate(3));
        }
    }
}
