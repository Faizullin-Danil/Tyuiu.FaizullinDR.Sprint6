using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task3.V26.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_FDR.BackColor = Color.Red;
            buttonHelp_FDR.BackColor = Color.Blue;
        }
        DataService ds = new DataService();

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTask_FDR_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_FDR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_FDR.BackColor = Color.Green;
        }

        private void buttonHelp_FDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент ИИПБ-23-3 Файзуллин Данил Рамилевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            int[,] matrix =
            {
                {16,19,17,2,8 },
                {-17,8,-17,-8,1 },
                {-7,17,-2,1,-3 },
                {-12,0,-17,15,6 },
                {17,-6,-17,18,-19 }
            };
            int[,] arr = ds.Calculate(matrix);

            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            dataGridViewResult.RowCount = rows;
            dataGridViewResult.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}
