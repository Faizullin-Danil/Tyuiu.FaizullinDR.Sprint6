
namespace Tyuiu.FaizullinDR.Sprint6.Task2.V8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutPut_FDR = new System.Windows.Forms.GroupBox();
            this.labelResult_FDR = new System.Windows.Forms.Label();
            this.buttonInfo_FDR = new System.Windows.Forms.Button();
            this.buttonDone_FDR = new System.Windows.Forms.Button();
            this.groupBoxInPut_FDR = new System.Windows.Forms.GroupBox();
            this.textBoxStop_FDR = new System.Windows.Forms.TextBox();
            this.textBoxStart_FDR = new System.Windows.Forms.TextBox();
            this.labelStop_FDR = new System.Windows.Forms.Label();
            this.labelStart_FDR = new System.Windows.Forms.Label();
            this.groupBoxTask_FDR = new System.Windows.Forms.GroupBox();
            this.labelTask2_FDR = new System.Windows.Forms.Label();
            this.pictureBoxTask_FDR = new System.Windows.Forms.PictureBox();
            this.labelTask_FDR = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_FDR.SuspendLayout();
            this.groupBoxInPut_FDR.SuspendLayout();
            this.groupBoxTask_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Controls.Add(this.dataGridViewResult);
            this.groupBoxOutPut_FDR.Controls.Add(this.labelResult_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(545, 7);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(149, 437);
            this.groupBoxOutPut_FDR.TabIndex = 14;
            this.groupBoxOutPut_FDR.TabStop = false;
            this.groupBoxOutPut_FDR.Text = "Вывод данных";
            // 
            // labelResult_FDR
            // 
            this.labelResult_FDR.AutoSize = true;
            this.labelResult_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelResult_FDR.Name = "labelResult_FDR";
            this.labelResult_FDR.Size = new System.Drawing.Size(76, 17);
            this.labelResult_FDR.TabIndex = 0;
            this.labelResult_FDR.Text = "Результат";
            // 
            // buttonInfo_FDR
            // 
            this.buttonInfo_FDR.Location = new System.Drawing.Point(293, 319);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(121, 125);
            this.buttonInfo_FDR.TabIndex = 13;
            this.buttonInfo_FDR.Text = "Справка";
            this.buttonInfo_FDR.UseVisualStyleBackColor = true;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // buttonDone_FDR
            // 
            this.buttonDone_FDR.Location = new System.Drawing.Point(418, 319);
            this.buttonDone_FDR.Name = "buttonDone_FDR";
            this.buttonDone_FDR.Size = new System.Drawing.Size(121, 125);
            this.buttonDone_FDR.TabIndex = 12;
            this.buttonDone_FDR.Text = "Выполнить";
            this.buttonDone_FDR.UseVisualStyleBackColor = true;
            this.buttonDone_FDR.Click += new System.EventHandler(this.buttonDone_FDR_Click);
            this.buttonDone_FDR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_FDR_MouseDown);
            this.buttonDone_FDR.MouseEnter += new System.EventHandler(this.buttonDone_FDR_MouseEnter);
            this.buttonDone_FDR.MouseLeave += new System.EventHandler(this.buttonDone_FDR_MouseLeave);
            // 
            // groupBoxInPut_FDR
            // 
            this.groupBoxInPut_FDR.Controls.Add(this.textBoxStop_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.textBoxStart_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.labelStop_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.labelStart_FDR);
            this.groupBoxInPut_FDR.Location = new System.Drawing.Point(7, 319);
            this.groupBoxInPut_FDR.Name = "groupBoxInPut_FDR";
            this.groupBoxInPut_FDR.Size = new System.Drawing.Size(280, 125);
            this.groupBoxInPut_FDR.TabIndex = 11;
            this.groupBoxInPut_FDR.TabStop = false;
            this.groupBoxInPut_FDR.Text = "Ввод данных";
            // 
            // textBoxStop_FDR
            // 
            this.textBoxStop_FDR.Location = new System.Drawing.Point(108, 38);
            this.textBoxStop_FDR.Name = "textBoxStop_FDR";
            this.textBoxStop_FDR.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_FDR.TabIndex = 3;
            // 
            // textBoxStart_FDR
            // 
            this.textBoxStart_FDR.Location = new System.Drawing.Point(9, 38);
            this.textBoxStart_FDR.Name = "textBoxStart_FDR";
            this.textBoxStart_FDR.Size = new System.Drawing.Size(93, 22);
            this.textBoxStart_FDR.TabIndex = 2;
            // 
            // labelStop_FDR
            // 
            this.labelStop_FDR.AutoSize = true;
            this.labelStop_FDR.Location = new System.Drawing.Point(105, 18);
            this.labelStop_FDR.Name = "labelStop_FDR";
            this.labelStop_FDR.Size = new System.Drawing.Size(85, 17);
            this.labelStop_FDR.TabIndex = 1;
            this.labelStop_FDR.Text = "Конец шага";
            // 
            // labelStart_FDR
            // 
            this.labelStart_FDR.AutoSize = true;
            this.labelStart_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelStart_FDR.Name = "labelStart_FDR";
            this.labelStart_FDR.Size = new System.Drawing.Size(83, 17);
            this.labelStart_FDR.TabIndex = 0;
            this.labelStart_FDR.Text = "Старт шага";
            // 
            // groupBoxTask_FDR
            // 
            this.groupBoxTask_FDR.Controls.Add(this.labelTask2_FDR);
            this.groupBoxTask_FDR.Controls.Add(this.pictureBoxTask_FDR);
            this.groupBoxTask_FDR.Controls.Add(this.labelTask_FDR);
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(7, 7);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(532, 306);
            this.groupBoxTask_FDR.TabIndex = 10;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие";
            // 
            // labelTask2_FDR
            // 
            this.labelTask2_FDR.AutoSize = true;
            this.labelTask2_FDR.Location = new System.Drawing.Point(6, 100);
            this.labelTask2_FDR.Name = "labelTask2_FDR";
            this.labelTask2_FDR.Size = new System.Drawing.Size(420, 17);
            this.labelTask2_FDR.TabIndex = 2;
            this.labelTask2_FDR.Text = "произвести табулирование на заданном диапазоне с шагом 1";
            // 
            // pictureBoxTask_FDR
            // 
            this.pictureBoxTask_FDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_FDR.Image")));
            this.pictureBoxTask_FDR.Location = new System.Drawing.Point(9, 47);
            this.pictureBoxTask_FDR.Name = "pictureBoxTask_FDR";
            this.pictureBoxTask_FDR.Size = new System.Drawing.Size(366, 47);
            this.pictureBoxTask_FDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask_FDR.TabIndex = 1;
            this.pictureBoxTask_FDR.TabStop = false;
            // 
            // labelTask_FDR
            // 
            this.labelTask_FDR.AutoSize = true;
            this.labelTask_FDR.Location = new System.Drawing.Point(6, 27);
            this.labelTask_FDR.Name = "labelTask_FDR";
            this.labelTask_FDR.Size = new System.Drawing.Size(511, 17);
            this.labelTask_FDR.TabIndex = 0;
            this.labelTask_FDR.Text = "Написать программу которая выводит выводит таблицу значений функции:";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(149, 393);
            this.dataGridViewResult.TabIndex = 1;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResult.Legends.Add(legend1);
            this.chartResult.Location = new System.Drawing.Point(700, 13);
            this.chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult.Series.Add(series1);
            this.chartResult.Size = new System.Drawing.Size(625, 425);
            this.chartResult.TabIndex = 15;
            this.chartResult.Text = "chartResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 450);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.buttonDone_FDR);
            this.Controls.Add(this.groupBoxInPut_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            this.groupBoxInPut_FDR.ResumeLayout(false);
            this.groupBoxInPut_FDR.PerformLayout();
            this.groupBoxTask_FDR.ResumeLayout(false);
            this.groupBoxTask_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_FDR;
        private System.Windows.Forms.Label labelResult_FDR;
        private System.Windows.Forms.Button buttonInfo_FDR;
        private System.Windows.Forms.Button buttonDone_FDR;
        private System.Windows.Forms.GroupBox groupBoxInPut_FDR;
        private System.Windows.Forms.TextBox textBoxStop_FDR;
        private System.Windows.Forms.TextBox textBoxStart_FDR;
        private System.Windows.Forms.Label labelStop_FDR;
        private System.Windows.Forms.Label labelStart_FDR;
        private System.Windows.Forms.GroupBox groupBoxTask_FDR;
        private System.Windows.Forms.Label labelTask2_FDR;
        private System.Windows.Forms.PictureBox pictureBoxTask_FDR;
        private System.Windows.Forms.Label labelTask_FDR;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}

