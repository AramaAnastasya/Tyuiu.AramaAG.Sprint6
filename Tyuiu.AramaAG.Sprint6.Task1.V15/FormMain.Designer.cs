
namespace Tyuiu.AramaAG.Sprint6.Task1.V15
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
        private void InitializeComponent()
        {
            this.textBoxResult_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxNamedOne_AAG = new System.Windows.Forms.GroupBox();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.groupBoxData_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxConditions_AAG = new System.Windows.Forms.TextBox();
            this.labelTextResult_AAG = new System.Windows.Forms.Label();
            this.labelTextStart_AAG = new System.Windows.Forms.Label();
            this.labelTextFinish_AAG = new System.Windows.Forms.Label();
            this.groupBoxNamedOne_AAG.SuspendLayout();
            this.groupBoxData_AAG.SuspendLayout();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult_AAG
            // 
            this.textBoxResult_AAG.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_AAG.Location = new System.Drawing.Point(0, 53);
            this.textBoxResult_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResult_AAG.Multiline = true;
            this.textBoxResult_AAG.Name = "textBoxResult_AAG";
            this.textBoxResult_AAG.ReadOnly = true;
            this.textBoxResult_AAG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAG.Size = new System.Drawing.Size(319, 398);
            this.textBoxResult_AAG.TabIndex = 0;
            // 
            // groupBoxNamedOne_AAG
            // 
            this.groupBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNamedOne_AAG.Controls.Add(this.labelTextResult_AAG);
            this.groupBoxNamedOne_AAG.Controls.Add(this.textBoxResult_AAG);
            this.groupBoxNamedOne_AAG.Location = new System.Drawing.Point(549, 6);
            this.groupBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Name = "groupBoxNamedOne_AAG";
            this.groupBoxNamedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Size = new System.Drawing.Size(333, 459);
            this.groupBoxNamedOne_AAG.TabIndex = 1;
            this.groupBoxNamedOne_AAG.TabStop = false;
            this.groupBoxNamedOne_AAG.Text = "Вывод данных";
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_AAG.Location = new System.Drawing.Point(426, 393);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(115, 81);
            this.buttonDone_AAG.TabIndex = 2;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDone_AAG_Click);
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(300, 393);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(120, 81);
            this.buttonHelp_AAG.TabIndex = 3;
            this.buttonHelp_AAG.Text = "Справка";
            this.buttonHelp_AAG.UseVisualStyleBackColor = false;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.buttonHelp_AAG_Click);
            // 
            // groupBoxData_AAG
            // 
            this.groupBoxData_AAG.Controls.Add(this.labelTextFinish_AAG);
            this.groupBoxData_AAG.Controls.Add(this.labelTextStart_AAG);
            this.groupBoxData_AAG.Controls.Add(this.textBoxStopStep_AAG);
            this.groupBoxData_AAG.Controls.Add(this.textBoxStartStep_AAG);
            this.groupBoxData_AAG.Location = new System.Drawing.Point(9, 383);
            this.groupBoxData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxData_AAG.Name = "groupBoxData_AAG";
            this.groupBoxData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxData_AAG.Size = new System.Drawing.Size(285, 91);
            this.groupBoxData_AAG.TabIndex = 4;
            this.groupBoxData_AAG.TabStop = false;
            this.groupBoxData_AAG.Text = "Ввод данных:";
            // 
            // textBoxStopStep_AAG
            // 
            this.textBoxStopStep_AAG.Location = new System.Drawing.Point(150, 56);
            this.textBoxStopStep_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStopStep_AAG.Name = "textBoxStopStep_AAG";
            this.textBoxStopStep_AAG.Size = new System.Drawing.Size(128, 26);
            this.textBoxStopStep_AAG.TabIndex = 6;
            this.textBoxStopStep_AAG.Text = "5";
            // 
            // textBoxStartStep_AAG
            // 
            this.textBoxStartStep_AAG.Location = new System.Drawing.Point(15, 56);
            this.textBoxStartStep_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStartStep_AAG.Name = "textBoxStartStep_AAG";
            this.textBoxStartStep_AAG.Size = new System.Drawing.Size(128, 26);
            this.textBoxStartStep_AAG.TabIndex = 5;
            this.textBoxStartStep_AAG.Text = "-5";
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxConditions_AAG);
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(6, 6);
            this.groupBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(533, 370);
            this.groupBoxConditions_AAG.TabIndex = 5;
            this.groupBoxConditions_AAG.TabStop = false;
            this.groupBoxConditions_AAG.Text = "Условие";
            // 
            // textBoxConditions_AAG
            // 
            this.textBoxConditions_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxConditions_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConditions_AAG.Location = new System.Drawing.Point(7, 26);
            this.textBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConditions_AAG.Multiline = true;
            this.textBoxConditions_AAG.Name = "textBoxConditions_AAG";
            this.textBoxConditions_AAG.Size = new System.Drawing.Size(520, 69);
            this.textBoxConditions_AAG.TabIndex = 0;
            this.textBoxConditions_AAG.Text = "Протабулировать функцию (COS(x)/(x-0,7))-SIN(x)*12*x+2 на заданном диапазоне.Резу" +
    "льтат вывести в таблице.";
            // 
            // labelTextResult_AAG
            // 
            this.labelTextResult_AAG.AutoSize = true;
            this.labelTextResult_AAG.Location = new System.Drawing.Point(6, 29);
            this.labelTextResult_AAG.Name = "labelTextResult_AAG";
            this.labelTextResult_AAG.Size = new System.Drawing.Size(93, 20);
            this.labelTextResult_AAG.TabIndex = 1;
            this.labelTextResult_AAG.Text = "Результат:";
            // 
            // labelTextStart_AAG
            // 
            this.labelTextStart_AAG.AutoSize = true;
            this.labelTextStart_AAG.Location = new System.Drawing.Point(11, 23);
            this.labelTextStart_AAG.Name = "labelTextStart_AAG";
            this.labelTextStart_AAG.Size = new System.Drawing.Size(102, 20);
            this.labelTextStart_AAG.TabIndex = 7;
            this.labelTextStart_AAG.Text = "Старт шага:";
            // 
            // labelTextFinish_AAG
            // 
            this.labelTextFinish_AAG.AutoSize = true;
            this.labelTextFinish_AAG.Location = new System.Drawing.Point(146, 23);
            this.labelTextFinish_AAG.Name = "labelTextFinish_AAG";
            this.labelTextFinish_AAG.Size = new System.Drawing.Size(97, 20);
            this.labelTextFinish_AAG.TabIndex = 8;
            this.labelTextFinish_AAG.Text = "Конец шага";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 479);
            this.Controls.Add(this.groupBoxConditions_AAG);
            this.Controls.Add(this.groupBoxData_AAG);
            this.Controls.Add(this.buttonHelp_AAG);
            this.Controls.Add(this.buttonDone_AAG);
            this.Controls.Add(this.groupBoxNamedOne_AAG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 15 | Арама А. Г.";
            this.groupBoxNamedOne_AAG.ResumeLayout(false);
            this.groupBoxNamedOne_AAG.PerformLayout();
            this.groupBoxData_AAG.ResumeLayout(false);
            this.groupBoxData_AAG.PerformLayout();
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.GroupBox groupBoxData_AAG;
        private System.Windows.Forms.TextBox textBoxStopStep_AAG;
        private System.Windows.Forms.TextBox textBoxStartStep_AAG;
        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.TextBox textBoxConditions_AAG;
        private System.Windows.Forms.Label labelTextResult_AAG;
        private System.Windows.Forms.Label labelTextFinish_AAG;
        private System.Windows.Forms.Label labelTextStart_AAG;
    }
}

