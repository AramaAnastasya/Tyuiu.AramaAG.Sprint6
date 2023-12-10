
namespace Tyuiu.AramaAG.Sprint6.Task2.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxConditions_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxData_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_AAG = new System.Windows.Forms.TextBox();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxResult_AAG = new System.Windows.Forms.GroupBox();
            this.chartFunction_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_AAG = new System.Windows.Forms.DataGridView();
            this.NamedX_AAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamedFx_AAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTextResult_AAG = new System.Windows.Forms.Label();
            this.labelTextStart_AAG = new System.Windows.Forms.Label();
            this.labelTextFinish_AAG = new System.Windows.Forms.Label();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.groupBoxData_AAG.SuspendLayout();
            this.groupBoxResult_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxConditions_AAG);
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(9, 8);
            this.groupBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(483, 370);
            this.groupBoxConditions_AAG.TabIndex = 10;
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
            this.textBoxConditions_AAG.Size = new System.Drawing.Size(446, 69);
            this.textBoxConditions_AAG.TabIndex = 0;
            this.textBoxConditions_AAG.Text = "Протабулировать функцию SIN(x)+(2*x/3)-COS(x)*4*x на заданном диапазоне.Результат" +
    " вывести в таблице.";
            this.textBoxConditions_AAG.TextChanged += new System.EventHandler(this.textBoxNaamedOne_AAG_TextChanged);
            // 
            // groupBoxData_AAG
            // 
            this.groupBoxData_AAG.Controls.Add(this.labelTextFinish_AAG);
            this.groupBoxData_AAG.Controls.Add(this.labelTextStart_AAG);
            this.groupBoxData_AAG.Controls.Add(this.textBoxStopStep_AAG);
            this.groupBoxData_AAG.Controls.Add(this.textBoxStartStep_AAG);
            this.groupBoxData_AAG.Location = new System.Drawing.Point(-6, 386);
            this.groupBoxData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxData_AAG.Name = "groupBoxData_AAG";
            this.groupBoxData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxData_AAG.Size = new System.Drawing.Size(285, 91);
            this.groupBoxData_AAG.TabIndex = 9;
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
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(283, 399);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(88, 69);
            this.buttonHelp_AAG.TabIndex = 8;
            this.buttonHelp_AAG.Text = "Справка";
            this.buttonHelp_AAG.UseVisualStyleBackColor = false;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.Halp_Click);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_AAG.Location = new System.Drawing.Point(377, 400);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(115, 68);
            this.buttonDone_AAG.TabIndex = 7;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDone_AAG_Click);
            this.buttonDone_AAG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_AAG_MouseDown);
            this.buttonDone_AAG.MouseEnter += new System.EventHandler(this.buttonDone_AAG_MouseEnter);
            this.buttonDone_AAG.MouseLeave += new System.EventHandler(this.buttonDone_AAG_MouseLeave);
            // 
            // groupBoxResult_AAG
            // 
            this.groupBoxResult_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxResult_AAG.Controls.Add(this.chartFunction_AAG);
            this.groupBoxResult_AAG.Controls.Add(this.dataGridViewFunction_AAG);
            this.groupBoxResult_AAG.Controls.Add(this.labelTextResult_AAG);
            this.groupBoxResult_AAG.Location = new System.Drawing.Point(498, 8);
            this.groupBoxResult_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Name = "groupBoxResult_AAG";
            this.groupBoxResult_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Size = new System.Drawing.Size(878, 469);
            this.groupBoxResult_AAG.TabIndex = 6;
            this.groupBoxResult_AAG.TabStop = false;
            this.groupBoxResult_AAG.Text = "Вывод данных";
            // 
            // chartFunction_AAG
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_AAG.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction_AAG.Legends.Add(legend4);
            this.chartFunction_AAG.Location = new System.Drawing.Point(263, 58);
            this.chartFunction_AAG.Name = "chartFunction_AAG";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_AAG.Series.Add(series4);
            this.chartFunction_AAG.Size = new System.Drawing.Size(598, 402);
            this.chartFunction_AAG.TabIndex = 2;
            this.chartFunction_AAG.Text = "chart1";
            // 
            // dataGridViewFunction_AAG
            // 
            this.dataGridViewFunction_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_AAG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamedX_AAG,
            this.NamedFx_AAG});
            this.dataGridViewFunction_AAG.Location = new System.Drawing.Point(20, 61);
            this.dataGridViewFunction_AAG.Name = "dataGridViewFunction_AAG";
            this.dataGridViewFunction_AAG.RowHeadersVisible = false;
            this.dataGridViewFunction_AAG.RowHeadersWidth = 62;
            this.dataGridViewFunction_AAG.RowTemplate.Height = 28;
            this.dataGridViewFunction_AAG.Size = new System.Drawing.Size(237, 399);
            this.dataGridViewFunction_AAG.TabIndex = 1;
            // 
            // NamedX_AAG
            // 
            this.NamedX_AAG.HeaderText = "X";
            this.NamedX_AAG.MinimumWidth = 8;
            this.NamedX_AAG.Name = "NamedX_AAG";
            this.NamedX_AAG.ReadOnly = true;
            this.NamedX_AAG.Width = 60;
            // 
            // NamedFx_AAG
            // 
            this.NamedFx_AAG.HeaderText = "F(x)";
            this.NamedFx_AAG.MinimumWidth = 8;
            this.NamedFx_AAG.Name = "NamedFx_AAG";
            this.NamedFx_AAG.ReadOnly = true;
            this.NamedFx_AAG.Width = 60;
            // 
            // labelTextResult_AAG
            // 
            this.labelTextResult_AAG.AutoSize = true;
            this.labelTextResult_AAG.Location = new System.Drawing.Point(23, 30);
            this.labelTextResult_AAG.Name = "labelTextResult_AAG";
            this.labelTextResult_AAG.Size = new System.Drawing.Size(89, 20);
            this.labelTextResult_AAG.TabIndex = 0;
            this.labelTextResult_AAG.Text = "Результат";
            // 
            // labelTextStart_AAG
            // 
            this.labelTextStart_AAG.AutoSize = true;
            this.labelTextStart_AAG.Location = new System.Drawing.Point(18, 32);
            this.labelTextStart_AAG.Name = "labelTextStart_AAG";
            this.labelTextStart_AAG.Size = new System.Drawing.Size(102, 20);
            this.labelTextStart_AAG.TabIndex = 7;
            this.labelTextStart_AAG.Text = "Старт шага:";
            // 
            // labelTextFinish_AAG
            // 
            this.labelTextFinish_AAG.AutoSize = true;
            this.labelTextFinish_AAG.Location = new System.Drawing.Point(156, 32);
            this.labelTextFinish_AAG.Name = "labelTextFinish_AAG";
            this.labelTextFinish_AAG.Size = new System.Drawing.Size(101, 20);
            this.labelTextFinish_AAG.TabIndex = 8;
            this.labelTextFinish_AAG.Text = "Конец шага:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 485);
            this.Controls.Add(this.groupBoxConditions_AAG);
            this.Controls.Add(this.groupBoxData_AAG);
            this.Controls.Add(this.buttonHelp_AAG);
            this.Controls.Add(this.buttonDone_AAG);
            this.Controls.Add(this.groupBoxResult_AAG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Арама А. Г.";
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.groupBoxData_AAG.ResumeLayout(false);
            this.groupBoxData_AAG.PerformLayout();
            this.groupBoxResult_AAG.ResumeLayout(false);
            this.groupBoxResult_AAG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.TextBox textBoxConditions_AAG;
        private System.Windows.Forms.GroupBox groupBoxData_AAG;
        private System.Windows.Forms.TextBox textBoxStopStep_AAG;
        private System.Windows.Forms.TextBox textBoxStartStep_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxResult_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAG;
        private System.Windows.Forms.DataGridView dataGridViewFunction_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamedX_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamedFx_AAG;
        private System.Windows.Forms.Label labelTextResult_AAG;
        private System.Windows.Forms.Label labelTextFinish_AAG;
        private System.Windows.Forms.Label labelTextStart_AAG;
    }
}

