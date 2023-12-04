using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void labelTask_FDR_Click(object sender, EventArgs e)
        {

        }

        private void labelTask2_FDR_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            try
            {
                

                int startStep = Convert.ToInt32(textBoxStart_FDR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_FDR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arrResult = new double[len];

                arrResult = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_FDR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_FDR.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_FDR.Text = "";
                chartResult_FDR.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartResult_FDR.Series[0].Points.AddXY(startStep, arrResult[i]);
                    textBoxResult_FDR.AppendText(arrResult[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_FDR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_FDR.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n открыть его в блокноте", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch 
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-3 Файзуллин Данил Рамилевич","Справка",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
