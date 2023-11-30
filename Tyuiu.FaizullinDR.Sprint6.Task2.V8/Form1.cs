using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task2.V8.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task2.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonDone_FDR.BackColor = Color.Green;
            buttonInfo_FDR.BackColor = Color.Blue;
        }
        DataService ds = new DataService();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_FDR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_FDR.BackColor = Color.Red;
        }

        private void buttonDone_FDR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_FDR.BackColor = Color.Green;
        }

        private void buttonDone_FDR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_FDR.BackColor = Color.Blue;
            
        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент ИИПБ-23-3 Файзуллин Данил Рамилевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewResult.Rows.Clear();
                this.chartResult.Series[0].Points.Clear();
                this.chartResult.Titles.Clear();
                int startStep = Convert.ToInt32(textBoxStart_FDR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_FDR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arr = new double[len];

                arr = ds.GetMassFunction(startStep, stopStep);

                this.chartResult.Titles.Add("График функции:");

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startStep), Convert.ToString(arr[i]));

                    this.chartResult.Series[0].Points.AddXY(startStep, arr[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
        }
    }
}
