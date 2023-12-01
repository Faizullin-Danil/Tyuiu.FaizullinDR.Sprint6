
namespace Tyuiu.FaizullinDR.Sprint6.Task3.V26
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
            this.groupBoxOutPut_FDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_FDR = new System.Windows.Forms.Label();
            this.groupBoxTask_FDR = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_FDR = new System.Windows.Forms.PictureBox();
            this.labelTask_FDR = new System.Windows.Forms.Label();
            this.buttonDone_FDR = new System.Windows.Forms.Button();
            this.buttonHelp_FDR = new System.Windows.Forms.Button();
            this.groupBoxOutPut_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxTask_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Controls.Add(this.dataGridViewResult);
            this.groupBoxOutPut_FDR.Controls.Add(this.labelResult_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(378, 12);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(603, 252);
            this.groupBoxOutPut_FDR.TabIndex = 16;
            this.groupBoxOutPut_FDR.TabStop = false;
            this.groupBoxOutPut_FDR.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult.Location = new System.Drawing.Point(9, 38);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(195, 196);
            this.dataGridViewResult.TabIndex = 1;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentClick);
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
            // labelResult_FDR
            // 
            this.labelResult_FDR.AutoSize = true;
            this.labelResult_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelResult_FDR.Name = "labelResult_FDR";
            this.labelResult_FDR.Size = new System.Drawing.Size(76, 17);
            this.labelResult_FDR.TabIndex = 0;
            this.labelResult_FDR.Text = "Результат";
            // 
            // groupBoxTask_FDR
            // 
            this.groupBoxTask_FDR.Controls.Add(this.labelTask_FDR);
            this.groupBoxTask_FDR.Controls.Add(this.pictureBoxTask_FDR);
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(360, 252);
            this.groupBoxTask_FDR.TabIndex = 15;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие";
            // 
            // pictureBoxTask_FDR
            // 
            this.pictureBoxTask_FDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_FDR.Image")));
            this.pictureBoxTask_FDR.Location = new System.Drawing.Point(77, 57);
            this.pictureBoxTask_FDR.Name = "pictureBoxTask_FDR";
            this.pictureBoxTask_FDR.Size = new System.Drawing.Size(174, 177);
            this.pictureBoxTask_FDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTask_FDR.TabIndex = 1;
            this.pictureBoxTask_FDR.TabStop = false;
            // 
            // labelTask_FDR
            // 
            this.labelTask_FDR.AutoSize = true;
            this.labelTask_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelTask_FDR.Name = "labelTask_FDR";
            this.labelTask_FDR.Size = new System.Drawing.Size(345, 17);
            this.labelTask_FDR.TabIndex = 2;
            this.labelTask_FDR.Text = "Заменить четные элементы массива 3 строки на 0";
            this.labelTask_FDR.Click += new System.EventHandler(this.labelTask_FDR_Click);
            // 
            // buttonDone_FDR
            // 
            this.buttonDone_FDR.Location = new System.Drawing.Point(378, 270);
            this.buttonDone_FDR.Name = "buttonDone_FDR";
            this.buttonDone_FDR.Size = new System.Drawing.Size(149, 66);
            this.buttonDone_FDR.TabIndex = 17;
            this.buttonDone_FDR.Text = "Выполнить";
            this.buttonDone_FDR.UseVisualStyleBackColor = true;
            this.buttonDone_FDR.Click += new System.EventHandler(this.buttonDone_FDR_Click);
            this.buttonDone_FDR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_FDR_MouseDown);
            // 
            // buttonHelp_FDR
            // 
            this.buttonHelp_FDR.Location = new System.Drawing.Point(268, 271);
            this.buttonHelp_FDR.Name = "buttonHelp_FDR";
            this.buttonHelp_FDR.Size = new System.Drawing.Size(95, 66);
            this.buttonHelp_FDR.TabIndex = 18;
            this.buttonHelp_FDR.Text = "Справка";
            this.buttonHelp_FDR.UseVisualStyleBackColor = true;
            this.buttonHelp_FDR.Click += new System.EventHandler(this.buttonHelp_FDR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 349);
            this.Controls.Add(this.buttonHelp_FDR);
            this.Controls.Add(this.buttonDone_FDR);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Файзуллин Д. Р.";
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBoxTask_FDR.ResumeLayout(false);
            this.groupBoxTask_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_FDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_FDR;
        private System.Windows.Forms.Label labelResult_FDR;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBoxTask_FDR;
        private System.Windows.Forms.Label labelTask_FDR;
        private System.Windows.Forms.PictureBox pictureBoxTask_FDR;
        private System.Windows.Forms.Button buttonDone_FDR;
        private System.Windows.Forms.Button buttonHelp_FDR;
    }
}

