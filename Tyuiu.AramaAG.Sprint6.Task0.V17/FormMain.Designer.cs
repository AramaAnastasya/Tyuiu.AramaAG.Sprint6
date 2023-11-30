
using System;

namespace Tyuiu.AramaAG.Sprint6.Task0.V17
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxNamedTwo_AAG = new System.Windows.Forms.PictureBox();
            this.groupBoxNamedTwo_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxNamedFour_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxNamedThree_AAG = new System.Windows.Forms.GroupBox();
            this.groupBoxNamedSix_AAG = new System.Windows.Forms.GroupBox();
            this.nameX_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxNamedFour_AAG = new System.Windows.Forms.GroupBox();
            this.Result_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxNameddTwo_AAG = new System.Windows.Forms.GroupBox();
            this.buttonNamedOne_AAG = new System.Windows.Forms.Button();
            this.buttonNamedThree_AAG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamedTwo_AAG)).BeginInit();
            this.groupBoxNamedTwo_AAG.SuspendLayout();
            this.groupBoxNamedThree_AAG.SuspendLayout();
            this.groupBoxNamedSix_AAG.SuspendLayout();
            this.groupBoxNamedFour_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxNamedTwo_AAG
            // 
            this.pictureBoxNamedTwo_AAG.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNamedTwo_AAG.ErrorImage")));
            this.pictureBoxNamedTwo_AAG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNamedTwo_AAG.Image")));
            this.pictureBoxNamedTwo_AAG.Location = new System.Drawing.Point(478, 25);
            this.pictureBoxNamedTwo_AAG.Name = "pictureBoxNamedTwo_AAG";
            this.pictureBoxNamedTwo_AAG.Size = new System.Drawing.Size(96, 61);
            this.pictureBoxNamedTwo_AAG.TabIndex = 0;
            this.pictureBoxNamedTwo_AAG.TabStop = false;
            // 
            // groupBoxNamedTwo_AAG
            // 
            this.groupBoxNamedTwo_AAG.Controls.Add(this.textBoxNamedFour_AAG);
            this.groupBoxNamedTwo_AAG.Controls.Add(this.pictureBoxNamedTwo_AAG);
            this.groupBoxNamedTwo_AAG.Location = new System.Drawing.Point(12, 25);
            this.groupBoxNamedTwo_AAG.Name = "groupBoxNamedTwo_AAG";
            this.groupBoxNamedTwo_AAG.Size = new System.Drawing.Size(666, 184);
            this.groupBoxNamedTwo_AAG.TabIndex = 2;
            this.groupBoxNamedTwo_AAG.TabStop = false;
            this.groupBoxNamedTwo_AAG.Text = "Условие";
            // 
            // textBoxNamedFour_AAG
            // 
            this.textBoxNamedFour_AAG.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNamedFour_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamedFour_AAG.Location = new System.Drawing.Point(6, 21);
            this.textBoxNamedFour_AAG.Multiline = true;
            this.textBoxNamedFour_AAG.Name = "textBoxNamedFour_AAG";
            this.textBoxNamedFour_AAG.ReadOnly = true;
            this.textBoxNamedFour_AAG.Size = new System.Drawing.Size(242, 22);
            this.textBoxNamedFour_AAG.TabIndex = 1;
            this.textBoxNamedFour_AAG.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxNamedThree_AAG
            // 
            this.groupBoxNamedThree_AAG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedThree_AAG.Controls.Add(this.groupBoxNamedSix_AAG);
            this.groupBoxNamedThree_AAG.Location = new System.Drawing.Point(12, 215);
            this.groupBoxNamedThree_AAG.Name = "groupBoxNamedThree_AAG";
            this.groupBoxNamedThree_AAG.Size = new System.Drawing.Size(406, 137);
            this.groupBoxNamedThree_AAG.TabIndex = 3;
            this.groupBoxNamedThree_AAG.TabStop = false;
            this.groupBoxNamedThree_AAG.Text = "Ввод данных";
            // 
            // groupBoxNamedSix_AAG
            // 
            this.groupBoxNamedSix_AAG.Controls.Add(this.nameX_AAG);
            this.groupBoxNamedSix_AAG.Location = new System.Drawing.Point(33, 38);
            this.groupBoxNamedSix_AAG.Name = "groupBoxNamedSix_AAG";
            this.groupBoxNamedSix_AAG.Size = new System.Drawing.Size(324, 77);
            this.groupBoxNamedSix_AAG.TabIndex = 7;
            this.groupBoxNamedSix_AAG.TabStop = false;
            this.groupBoxNamedSix_AAG.Text = "Переменная X:";
            // 
            // nameX_AAG
            // 
            this.nameX_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.nameX_AAG.Location = new System.Drawing.Point(12, 39);
            this.nameX_AAG.Name = "nameX_AAG";
            this.nameX_AAG.Size = new System.Drawing.Size(306, 26);
            this.nameX_AAG.TabIndex = 1;
            this.nameX_AAG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonResult_AAG_KeyPress);
            // 
            // groupBoxNamedFour_AAG
            // 
            this.groupBoxNamedFour_AAG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxNamedFour_AAG.Controls.Add(this.Result_AAG);
            this.groupBoxNamedFour_AAG.Controls.Add(this.groupBoxNameddTwo_AAG);
            this.groupBoxNamedFour_AAG.Location = new System.Drawing.Point(424, 215);
            this.groupBoxNamedFour_AAG.Name = "groupBoxNamedFour_AAG";
            this.groupBoxNamedFour_AAG.Size = new System.Drawing.Size(254, 137);
            this.groupBoxNamedFour_AAG.TabIndex = 4;
            this.groupBoxNamedFour_AAG.TabStop = false;
            this.groupBoxNamedFour_AAG.Text = "Вывод данных";
            // 
            // Result_AAG
            // 
            this.Result_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.Result_AAG.Location = new System.Drawing.Point(37, 77);
            this.Result_AAG.Name = "Result_AAG";
            this.Result_AAG.ReadOnly = true;
            this.Result_AAG.Size = new System.Drawing.Size(182, 26);
            this.Result_AAG.TabIndex = 2;
            // 
            // groupBoxNameddTwo_AAG
            // 
            this.groupBoxNameddTwo_AAG.Location = new System.Drawing.Point(24, 38);
            this.groupBoxNameddTwo_AAG.Name = "groupBoxNameddTwo_AAG";
            this.groupBoxNameddTwo_AAG.Size = new System.Drawing.Size(210, 77);
            this.groupBoxNameddTwo_AAG.TabIndex = 3;
            this.groupBoxNameddTwo_AAG.TabStop = false;
            this.groupBoxNameddTwo_AAG.Text = "Результат";
            // 
            // buttonNamedOne_AAG
            // 
            this.buttonNamedOne_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNamedOne_AAG.ForeColor = System.Drawing.Color.Black;
            this.buttonNamedOne_AAG.Location = new System.Drawing.Point(490, 371);
            this.buttonNamedOne_AAG.Name = "buttonNamedOne_AAG";
            this.buttonNamedOne_AAG.Size = new System.Drawing.Size(168, 40);
            this.buttonNamedOne_AAG.TabIndex = 0;
            this.buttonNamedOne_AAG.Text = "Выполнить";
            this.buttonNamedOne_AAG.UseVisualStyleBackColor = false;
            this.buttonNamedOne_AAG.Click += new System.EventHandler(this.buttonResult_AAG_Click);
            // 
            // buttonNamedThree_AAG
            // 
            this.buttonNamedThree_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNamedThree_AAG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNamedThree_AAG.Location = new System.Drawing.Point(425, 371);
            this.buttonNamedThree_AAG.Name = "buttonNamedThree_AAG";
            this.buttonNamedThree_AAG.Size = new System.Drawing.Size(54, 39);
            this.buttonNamedThree_AAG.TabIndex = 6;
            this.buttonNamedThree_AAG.Text = "?";
            this.buttonNamedThree_AAG.UseVisualStyleBackColor = false;
            this.buttonNamedThree_AAG.Click += new System.EventHandler(this.buttonHelp_AAG_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.buttonNamedThree_AAG);
            this.Controls.Add(this.buttonNamedOne_AAG);
            this.Controls.Add(this.groupBoxNamedFour_AAG);
            this.Controls.Add(this.groupBoxNamedThree_AAG);
            this.Controls.Add(this.groupBoxNamedTwo_AAG);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 17 | Арама А. Г.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamedTwo_AAG)).EndInit();
            this.groupBoxNamedTwo_AAG.ResumeLayout(false);
            this.groupBoxNamedTwo_AAG.PerformLayout();
            this.groupBoxNamedThree_AAG.ResumeLayout(false);
            this.groupBoxNamedSix_AAG.ResumeLayout(false);
            this.groupBoxNamedSix_AAG.PerformLayout();
            this.groupBoxNamedFour_AAG.ResumeLayout(false);
            this.groupBoxNamedFour_AAG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxNamedTwo_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedTwo_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedThree_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedFour_AAG;
        private System.Windows.Forms.Button buttonNamedOne_AAG;
        private System.Windows.Forms.Button buttonNamedThree_AAG;
        private System.Windows.Forms.TextBox nameX_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedSix_AAG;
        private System.Windows.Forms.TextBox textBoxNamedFour_AAG;
        private System.Windows.Forms.GroupBox groupBoxNameddTwo_AAG;
        private System.Windows.Forms.TextBox Result_AAG;
    }
}

