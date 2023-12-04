
namespace Tyuiu.FaizullinDR.Sprint6.Task4.V20
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.chartResult_FDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_FDR = new System.Windows.Forms.Button();
            this.textBoxResult_FDR = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_FDR.SuspendLayout();
            this.groupBoxInPut_FDR.SuspendLayout();
            this.groupBoxTask_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_FDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutPut_FDR.Controls.Add(this.textBoxResult_FDR);
            this.groupBoxOutPut_FDR.Controls.Add(this.labelResult_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(12, 138);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(352, 549);
            this.groupBoxOutPut_FDR.TabIndex = 19;
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
            this.buttonInfo_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_FDR.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_FDR.Location = new System.Drawing.Point(1090, 12);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonInfo_FDR.TabIndex = 18;
            this.buttonInfo_FDR.Text = "Справка";
            this.buttonInfo_FDR.UseVisualStyleBackColor = false;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // buttonDone_FDR
            // 
            this.buttonDone_FDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_FDR.Location = new System.Drawing.Point(836, 12);
            this.buttonDone_FDR.Name = "buttonDone_FDR";
            this.buttonDone_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonDone_FDR.TabIndex = 17;
            this.buttonDone_FDR.Text = "Выполнить";
            this.buttonDone_FDR.UseVisualStyleBackColor = false;
            this.buttonDone_FDR.Click += new System.EventHandler(this.buttonDone_FDR_Click);
            // 
            // groupBoxInPut_FDR
            // 
            this.groupBoxInPut_FDR.Controls.Add(this.textBoxStop_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.textBoxStart_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.labelStop_FDR);
            this.groupBoxInPut_FDR.Controls.Add(this.labelStart_FDR);
            this.groupBoxInPut_FDR.Location = new System.Drawing.Point(550, 12);
            this.groupBoxInPut_FDR.Name = "groupBoxInPut_FDR";
            this.groupBoxInPut_FDR.Size = new System.Drawing.Size(280, 120);
            this.groupBoxInPut_FDR.TabIndex = 16;
            this.groupBoxInPut_FDR.TabStop = false;
            this.groupBoxInPut_FDR.Text = "Ввод данных";
            // 
            // textBoxStop_FDR
            // 
            this.textBoxStop_FDR.Location = new System.Drawing.Point(108, 38);
            this.textBoxStop_FDR.Name = "textBoxStop_FDR";
            this.textBoxStop_FDR.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_FDR.TabIndex = 3;
            this.textBoxStop_FDR.Text = "5";
            // 
            // textBoxStart_FDR
            // 
            this.textBoxStart_FDR.Location = new System.Drawing.Point(9, 38);
            this.textBoxStart_FDR.Name = "textBoxStart_FDR";
            this.textBoxStart_FDR.Size = new System.Drawing.Size(93, 22);
            this.textBoxStart_FDR.TabIndex = 2;
            this.textBoxStart_FDR.Text = "-5";
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
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(532, 120);
            this.groupBoxTask_FDR.TabIndex = 15;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие";
            // 
            // labelTask2_FDR
            // 
            this.labelTask2_FDR.AutoSize = true;
            this.labelTask2_FDR.Location = new System.Drawing.Point(6, 92);
            this.labelTask2_FDR.Name = "labelTask2_FDR";
            this.labelTask2_FDR.Size = new System.Drawing.Size(457, 17);
            this.labelTask2_FDR.TabIndex = 2;
            this.labelTask2_FDR.Text = "произвести табулирование на заданном диапазоне [-5;5] с шагом 1";
            this.labelTask2_FDR.Click += new System.EventHandler(this.labelTask2_FDR_Click);
            // 
            // pictureBoxTask_FDR
            // 
            this.pictureBoxTask_FDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_FDR.Image")));
            this.pictureBoxTask_FDR.Location = new System.Drawing.Point(9, 38);
            this.pictureBoxTask_FDR.Name = "pictureBoxTask_FDR";
            this.pictureBoxTask_FDR.Size = new System.Drawing.Size(418, 51);
            this.pictureBoxTask_FDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTask_FDR.TabIndex = 1;
            this.pictureBoxTask_FDR.TabStop = false;
            // 
            // labelTask_FDR
            // 
            this.labelTask_FDR.AutoSize = true;
            this.labelTask_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelTask_FDR.Name = "labelTask_FDR";
            this.labelTask_FDR.Size = new System.Drawing.Size(511, 17);
            this.labelTask_FDR.TabIndex = 0;
            this.labelTask_FDR.Text = "Написать программу которая выводит выводит таблицу значений функции:";
            this.labelTask_FDR.Click += new System.EventHandler(this.labelTask_FDR_Click);
            // 
            // chartResult_FDR
            // 
            this.chartResult_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chartResult_FDR.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartResult_FDR.Legends.Add(legend5);
            this.chartResult_FDR.Location = new System.Drawing.Point(370, 138);
            this.chartResult_FDR.Name = "chartResult_FDR";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_FDR.Series.Add(series5);
            this.chartResult_FDR.Size = new System.Drawing.Size(841, 543);
            this.chartResult_FDR.TabIndex = 20;
            this.chartResult_FDR.Text = "chart1";
            title5.Name = "Title";
            title5.Text = "График функции";
            this.chartResult_FDR.Titles.Add(title5);
            // 
            // buttonSave_FDR
            // 
            this.buttonSave_FDR.BackColor = System.Drawing.Color.Lime;
            this.buttonSave_FDR.Location = new System.Drawing.Point(963, 12);
            this.buttonSave_FDR.Name = "buttonSave_FDR";
            this.buttonSave_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonSave_FDR.TabIndex = 21;
            this.buttonSave_FDR.Text = "Сохранить";
            this.buttonSave_FDR.UseVisualStyleBackColor = false;
            this.buttonSave_FDR.Click += new System.EventHandler(this.buttonSave_FDR_Click);
            // 
            // textBoxResult_FDR
            // 
            this.textBoxResult_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResult_FDR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResult_FDR.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_FDR.Multiline = true;
            this.textBoxResult_FDR.Name = "textBoxResult_FDR";
            this.textBoxResult_FDR.ReadOnly = true;
            this.textBoxResult_FDR.Size = new System.Drawing.Size(343, 525);
            this.textBoxResult_FDR.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 699);
            this.Controls.Add(this.buttonSave_FDR);
            this.Controls.Add(this.chartResult_FDR);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.buttonDone_FDR);
            this.Controls.Add(this.groupBoxInPut_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            this.groupBoxInPut_FDR.ResumeLayout(false);
            this.groupBoxInPut_FDR.PerformLayout();
            this.groupBoxTask_FDR.ResumeLayout(false);
            this.groupBoxTask_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_FDR)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_FDR;
        private System.Windows.Forms.Button buttonSave_FDR;
        private System.Windows.Forms.TextBox textBoxResult_FDR;
    }
}

