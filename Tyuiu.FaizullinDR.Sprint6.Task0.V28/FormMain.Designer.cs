
namespace Tyuiu.FaizullinDR.Sprint6.Task0.V28
{
    partial class FormMain_FDR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_FDR));
            this.groupBoxTask_FDR = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_FDR = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutPut_FDR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_FDR = new System.Windows.Forms.TextBox();
            this.buttonPushMe_FDR = new System.Windows.Forms.Button();
            this.buttonInfo_FDR = new System.Windows.Forms.Button();
            this.groupBoxTask_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_FDR)).BeginInit();
            this.groupBoxOutPut_FDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_FDR
            // 
            this.groupBoxTask_FDR.Controls.Add(this.pictureBoxFormula_FDR);
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(655, 174);
            this.groupBoxTask_FDR.TabIndex = 0;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие";
            // 
            // pictureBoxFormula_FDR
            // 
            this.pictureBoxFormula_FDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_FDR.Image")));
            this.pictureBoxFormula_FDR.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxFormula_FDR.Name = "pictureBoxFormula_FDR";
            this.pictureBoxFormula_FDR.Size = new System.Drawing.Size(645, 113);
            this.pictureBoxFormula_FDR.TabIndex = 1;
            this.pictureBoxFormula_FDR.TabStop = false;
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Controls.Add(this.textBoxResult_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(272, 192);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(122, 93);
            this.groupBoxOutPut_FDR.TabIndex = 3;
            this.groupBoxOutPut_FDR.TabStop = false;
            this.groupBoxOutPut_FDR.Text = "Вывод данных";
            // 
            // textBoxResult_FDR
            // 
            this.textBoxResult_FDR.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_FDR.Name = "textBoxResult_FDR";
            this.textBoxResult_FDR.ReadOnly = true;
            this.textBoxResult_FDR.Size = new System.Drawing.Size(111, 22);
            this.textBoxResult_FDR.TabIndex = 4;
            // 
            // buttonPushMe_FDR
            // 
            this.buttonPushMe_FDR.Location = new System.Drawing.Point(511, 206);
            this.buttonPushMe_FDR.Name = "buttonPushMe_FDR";
            this.buttonPushMe_FDR.Size = new System.Drawing.Size(120, 57);
            this.buttonPushMe_FDR.TabIndex = 4;
            this.buttonPushMe_FDR.Text = "Выполнить";
            this.buttonPushMe_FDR.UseVisualStyleBackColor = true;
            this.buttonPushMe_FDR.Click += new System.EventHandler(this.buttonPushMe_Click);
            // 
            // buttonInfo_FDR
            // 
            this.buttonInfo_FDR.Location = new System.Drawing.Point(430, 206);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(75, 57);
            this.buttonInfo_FDR.TabIndex = 5;
            this.buttonInfo_FDR.Text = "справка";
            this.buttonInfo_FDR.UseVisualStyleBackColor = true;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // FormMain_FDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 294);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.buttonPushMe_FDR);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_FDR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 28 | Файзуллин Д. Р.";
            this.groupBoxTask_FDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_FDR)).EndInit();
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_FDR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_FDR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxOutPut_FDR;
        private System.Windows.Forms.TextBox textBoxResult_FDR;
        private System.Windows.Forms.Button buttonPushMe_FDR;
        private System.Windows.Forms.Button buttonInfo_FDR;
    }
}

