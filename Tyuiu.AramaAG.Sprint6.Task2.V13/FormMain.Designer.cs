
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxNameedOne_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxNaamedOne_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxNameddOne_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxNameedOne_AAG = new System.Windows.Forms.TextBox();
            this.textBoxNamedThree_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_AAG = new System.Windows.Forms.TextBox();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxNamedOne_AAG = new System.Windows.Forms.GroupBox();
            this.labelName_AAG = new System.Windows.Forms.Label();
            this.dataGridViewFunction_AAG = new System.Windows.Forms.DataGridView();
            this.NamedX_AAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamedFx_AAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNameedOne_AAG.SuspendLayout();
            this.groupBoxNameddOne_AAG.SuspendLayout();
            this.groupBoxNamedOne_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNameedOne_AAG
            // 
            this.groupBoxNameedOne_AAG.Controls.Add(this.textBoxNaamedOne_AAG);
            this.groupBoxNameedOne_AAG.Location = new System.Drawing.Point(27, 24);
            this.groupBoxNameedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Name = "groupBoxNameedOne_AAG";
            this.groupBoxNameedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Size = new System.Drawing.Size(483, 370);
            this.groupBoxNameedOne_AAG.TabIndex = 10;
            this.groupBoxNameedOne_AAG.TabStop = false;
            this.groupBoxNameedOne_AAG.Text = "Условие";
            // 
            // textBoxNaamedOne_AAG
            // 
            this.textBoxNaamedOne_AAG.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNaamedOne_AAG.Location = new System.Drawing.Point(7, 26);
            this.textBoxNaamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNaamedOne_AAG.Multiline = true;
            this.textBoxNaamedOne_AAG.Name = "textBoxNaamedOne_AAG";
            this.textBoxNaamedOne_AAG.Size = new System.Drawing.Size(446, 69);
            this.textBoxNaamedOne_AAG.TabIndex = 0;
            this.textBoxNaamedOne_AAG.Text = "Протабулировать функцию SIN(x)+(2*x/3)-COS(x)*4*x на заданном диапазоне.Результат" +
    " вывести в таблице.";
            this.textBoxNaamedOne_AAG.TextChanged += new System.EventHandler(this.textBoxNaamedOne_AAG_TextChanged);
            // 
            // groupBoxNameddOne_AAG
            // 
            this.groupBoxNameddOne_AAG.Controls.Add(this.textBoxNameedOne_AAG);
            this.groupBoxNameddOne_AAG.Controls.Add(this.textBoxNamedThree_AAG);
            this.groupBoxNameddOne_AAG.Controls.Add(this.textBoxStopStep_AAG);
            this.groupBoxNameddOne_AAG.Controls.Add(this.textBoxStartStep_AAG);
            this.groupBoxNameddOne_AAG.Location = new System.Drawing.Point(12, 402);
            this.groupBoxNameddOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameddOne_AAG.Name = "groupBoxNameddOne_AAG";
            this.groupBoxNameddOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameddOne_AAG.Size = new System.Drawing.Size(285, 91);
            this.groupBoxNameddOne_AAG.TabIndex = 9;
            this.groupBoxNameddOne_AAG.TabStop = false;
            this.groupBoxNameddOne_AAG.Text = "Ввод данных:";
            // 
            // textBoxNameedOne_AAG
            // 
            this.textBoxNameedOne_AAG.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNameedOne_AAG.Location = new System.Drawing.Point(150, 26);
            this.textBoxNameedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameedOne_AAG.Name = "textBoxNameedOne_AAG";
            this.textBoxNameedOne_AAG.Size = new System.Drawing.Size(128, 26);
            this.textBoxNameedOne_AAG.TabIndex = 6;
            this.textBoxNameedOne_AAG.Text = "Конец шага:";
            // 
            // textBoxNamedThree_AAG
            // 
            this.textBoxNamedThree_AAG.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNamedThree_AAG.Location = new System.Drawing.Point(15, 26);
            this.textBoxNamedThree_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamedThree_AAG.Name = "textBoxNamedThree_AAG";
            this.textBoxNamedThree_AAG.Size = new System.Drawing.Size(128, 26);
            this.textBoxNamedThree_AAG.TabIndex = 5;
            this.textBoxNamedThree_AAG.Text = "Старт шага:";
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
            this.buttonHelp_AAG.Location = new System.Drawing.Point(301, 401);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(88, 91);
            this.buttonHelp_AAG.TabIndex = 8;
            this.buttonHelp_AAG.Text = "Справка";
            this.buttonHelp_AAG.UseVisualStyleBackColor = false;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.Halp_Click);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_AAG.Location = new System.Drawing.Point(395, 402);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(115, 91);
            this.buttonDone_AAG.TabIndex = 7;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDone_AAG_Click);
            // 
            // groupBoxNamedOne_AAG
            // 
            this.groupBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNamedOne_AAG.Controls.Add(this.chartFunction_AAG);
            this.groupBoxNamedOne_AAG.Controls.Add(this.dataGridViewFunction_AAG);
            this.groupBoxNamedOne_AAG.Controls.Add(this.labelName_AAG);
            this.groupBoxNamedOne_AAG.Location = new System.Drawing.Point(516, 24);
            this.groupBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Name = "groupBoxNamedOne_AAG";
            this.groupBoxNamedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Size = new System.Drawing.Size(800, 484);
            this.groupBoxNamedOne_AAG.TabIndex = 6;
            this.groupBoxNamedOne_AAG.TabStop = false;
            this.groupBoxNamedOne_AAG.Text = "Вывод данных";
            // 
            // labelName_AAG
            // 
            this.labelName_AAG.AutoSize = true;
            this.labelName_AAG.Location = new System.Drawing.Point(23, 30);
            this.labelName_AAG.Name = "labelName_AAG";
            this.labelName_AAG.Size = new System.Drawing.Size(134, 30);
            this.labelName_AAG.TabIndex = 0;
            this.labelName_AAG.Text = "Результат";
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
            this.dataGridViewFunction_AAG.Size = new System.Drawing.Size(237, 406);
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
            // chartFunction_AAG
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_AAG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_AAG.Legends.Add(legend2);
            this.chartFunction_AAG.Location = new System.Drawing.Point(263, 58);
            this.chartFunction_AAG.Name = "chartFunction_AAG";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_AAG.Series.Add(series2);
            this.chartFunction_AAG.Size = new System.Drawing.Size(486, 409);
            this.chartFunction_AAG.TabIndex = 2;
            this.chartFunction_AAG.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 520);
            this.Controls.Add(this.groupBoxNameedOne_AAG);
            this.Controls.Add(this.groupBoxNameddOne_AAG);
            this.Controls.Add(this.buttonHelp_AAG);
            this.Controls.Add(this.buttonDone_AAG);
            this.Controls.Add(this.groupBoxNamedOne_AAG);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Арама А. Г.";
            this.groupBoxNameedOne_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.PerformLayout();
            this.groupBoxNameddOne_AAG.ResumeLayout(false);
            this.groupBoxNameddOne_AAG.PerformLayout();
            this.groupBoxNamedOne_AAG.ResumeLayout(false);
            this.groupBoxNamedOne_AAG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNameedOne_AAG;
        private System.Windows.Forms.TextBox textBoxNaamedOne_AAG;
        private System.Windows.Forms.GroupBox groupBoxNameddOne_AAG;
        private System.Windows.Forms.TextBox textBoxNameedOne_AAG;
        private System.Windows.Forms.TextBox textBoxNamedThree_AAG;
        private System.Windows.Forms.TextBox textBoxStopStep_AAG;
        private System.Windows.Forms.TextBox textBoxStartStep_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAG;
        private System.Windows.Forms.DataGridView dataGridViewFunction_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamedX_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamedFx_AAG;
        private System.Windows.Forms.Label labelName_AAG;
    }
}

