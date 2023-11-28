using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task1.V14.Lib;


namespace Tyuiu.FaizullinDR.Sprint6.Task1.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент ИИПБ-23-3 Файзуллин Данил Рамилевич","Справка",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonPushMe_FDR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_FDR.Text);
                int stopValue = Convert.ToInt32(textBoxStop_FDR.Text);

                string strValue;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] arr;
                arr = new double[len];

                arr = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_FDR.Text = "";
                textBoxResult_FDR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_FDR.AppendText("|    X       |      F(x)  |" + Environment.NewLine);
                textBoxResult_FDR.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strValue = String.Format("|{0,5:d}       |    {1, 5:f2}  | ", startValue, arr[i]);
                    textBoxResult_FDR.AppendText(strValue + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_FDR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
