
namespace Tyuiu.AramaAG.Sprint6.Task3.V20
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
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.labelConditions_AAG = new System.Windows.Forms.Label();
            this.dataGridSimple_AAG = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxResult_AAG = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_AAG = new System.Windows.Forms.DataGridView();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxConditions_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSimple_AAG)).BeginInit();
            this.groupBoxResult_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.labelConditions_AAG);
            this.groupBoxConditions_AAG.Controls.Add(this.dataGridSimple_AAG);
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(7, 7);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(676, 351);
            this.groupBoxConditions_AAG.TabIndex = 0;
            this.groupBoxConditions_AAG.TabStop = false;
            this.groupBoxConditions_AAG.Text = "Условие";
            // 
            // labelConditions_AAG
            // 
            this.labelConditions_AAG.Location = new System.Drawing.Point(6, 22);
            this.labelConditions_AAG.Name = "labelConditions_AAG";
            this.labelConditions_AAG.Size = new System.Drawing.Size(401, 371);
            this.labelConditions_AAG.TabIndex = 0;
            this.labelConditions_AAG.Text = "Дан массив 5 на 5 элементов.\r\nЗаменить четные значения в пятой строке на 0.\r\n-14 " +
    " 17 -19   3   2\r\n -4 -14 -19  -9  -1\r\n  1    0   13  14  8\r\n 13   7    8   -3 -1" +
    "5\r\n  2 -20  12 -14   4";
            // 
            // dataGridSimple_AAG
            // 
            this.dataGridSimple_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSimple_AAG.ColumnHeadersVisible = false;
            this.dataGridSimple_AAG.Location = new System.Drawing.Point(426, 25);
            this.dataGridSimple_AAG.Name = "dataGridSimple_AAG";
            this.dataGridSimple_AAG.RowHeadersVisible = false;
            this.dataGridSimple_AAG.RowHeadersWidth = 65;
            this.dataGridSimple_AAG.RowTemplate.Height = 28;
            this.dataGridSimple_AAG.Size = new System.Drawing.Size(234, 305);
            this.dataGridSimple_AAG.TabIndex = 1;
            // 
            // groupBoxResult_AAG
            // 
            this.groupBoxResult_AAG.Controls.Add(this.dataGridViewResult_AAG);
            this.groupBoxResult_AAG.Location = new System.Drawing.Point(689, 12);
            this.groupBoxResult_AAG.Name = "groupBoxResult_AAG";
            this.groupBoxResult_AAG.Size = new System.Drawing.Size(267, 276);
            this.groupBoxResult_AAG.TabIndex = 2;
            this.groupBoxResult_AAG.TabStop = false;
            this.groupBoxResult_AAG.Text = "Вывод данных";
            // 
            // dataGridViewResult_AAG
            // 
            this.dataGridViewResult_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAG.ColumnHeadersVisible = false;
            this.dataGridViewResult_AAG.Location = new System.Drawing.Point(18, 25);
            this.dataGridViewResult_AAG.Name = "dataGridViewResult_AAG";
            this.dataGridViewResult_AAG.RowHeadersVisible = false;
            this.dataGridViewResult_AAG.RowHeadersWidth = 62;
            this.dataGridViewResult_AAG.RowTemplate.Height = 28;
            this.dataGridViewResult_AAG.Size = new System.Drawing.Size(235, 244);
            this.dataGridViewResult_AAG.TabIndex = 0;
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(715, 298);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(49, 36);
            this.buttonHelp_AAG.TabIndex = 3;
            this.buttonHelp_AAG.Text = "?";
            this.buttonHelp_AAG.UseVisualStyleBackColor = true;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.buttonHelpCLick_AAG);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.Location = new System.Drawing.Point(808, 294);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(134, 45);
            this.buttonDone_AAG.TabIndex = 4;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = true;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDoneClick_AAG);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 367);
            this.Controls.Add(this.buttonDone_AAG);
            this.Controls.Add(this.buttonHelp_AAG);
            this.Controls.Add(this.groupBoxResult_AAG);
            this.Controls.Add(this.groupBoxConditions_AAG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Арама А. Г.";
            this.Load += new System.EventHandler(this.FormMain_AAG_CLick);
            this.groupBoxConditions_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSimple_AAG)).EndInit();
            this.groupBoxResult_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelConditions_AAG;
        private System.Windows.Forms.DataGridView dataGridSimple_AAG;
        private System.Windows.Forms.GroupBox groupBoxResult_AAG;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
    }
}

