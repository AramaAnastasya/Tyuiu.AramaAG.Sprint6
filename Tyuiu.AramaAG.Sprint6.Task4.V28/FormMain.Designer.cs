
namespace Tyuiu.AramaAG.Sprint6.Task4.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.groupBoxNamedOne_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AAG = new System.Windows.Forms.TextBox();
            this.chartFunction_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxConditions_AAG = new System.Windows.Forms.TextBox();
            this.groupBoxVvodData_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_AAG = new System.Windows.Forms.TextBox();
            this.textBoxStart_AAG = new System.Windows.Forms.TextBox();
            this.textBoxTextFinish_AAG = new System.Windows.Forms.TextBox();
            this.buttonSave_AAG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBoxNamedOne_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).BeginInit();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.groupBoxVvodData_AAG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(526, 18);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(107, 64);
            this.buttonHelp_AAG.TabIndex = 13;
            this.buttonHelp_AAG.Text = "Справка";
            this.buttonHelp_AAG.UseVisualStyleBackColor = false;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.Halp_Click);
            // 
            // groupBoxNamedOne_AAG
            // 
            this.groupBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNamedOne_AAG.Controls.Add(this.textBoxResult_AAG);
            this.groupBoxNamedOne_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNamedOne_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Name = "groupBoxNamedOne_AAG";
            this.groupBoxNamedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Size = new System.Drawing.Size(300, 404);
            this.groupBoxNamedOne_AAG.TabIndex = 11;
            this.groupBoxNamedOne_AAG.TabStop = false;
            this.groupBoxNamedOne_AAG.Text = "Вывод";
            this.groupBoxNamedOne_AAG.Enter += new System.EventHandler(this.groupBoxNamedOne_AAG_Enter);
            // 
            // textBoxResult_AAG
            // 
            this.textBoxResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_AAG.Location = new System.Drawing.Point(3, 23);
            this.textBoxResult_AAG.Multiline = true;
            this.textBoxResult_AAG.Name = "textBoxResult_AAG";
            this.textBoxResult_AAG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAG.Size = new System.Drawing.Size(294, 377);
            this.textBoxResult_AAG.TabIndex = 0;
            // 
            // chartFunction_AAG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_AAG.ChartAreas.Add(chartArea1);
            this.chartFunction_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_AAG.Legends.Add(legend1);
            this.chartFunction_AAG.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_AAG.Name = "chartFunction_AAG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_AAG.Series.Add(series1);
            this.chartFunction_AAG.Size = new System.Drawing.Size(1018, 404);
            this.chartFunction_AAG.TabIndex = 1;
            this.chartFunction_AAG.Text = "chart1";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.BorderWidth = 3;
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title";
            title1.Text = "График Функции cos(2x) +sin(x)/(x+2.5) + 2x ";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartFunction_AAG.Titles.Add(title1);
            this.chartFunction_AAG.Click += new System.EventHandler(this.chartFunction_AAG_Click);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_AAG.Location = new System.Drawing.Point(284, 18);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(115, 64);
            this.buttonDone_AAG.TabIndex = 12;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDone_AAG_Click);
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxConditions_AAG);
            this.groupBoxConditions_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(656, 123);
            this.groupBoxConditions_AAG.TabIndex = 15;
            this.groupBoxConditions_AAG.TabStop = false;
            this.groupBoxConditions_AAG.Text = "Условие";
            // 
            // textBoxConditions_AAG
            // 
            this.textBoxConditions_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxConditions_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConditions_AAG.Location = new System.Drawing.Point(8, 27);
            this.textBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConditions_AAG.Multiline = true;
            this.textBoxConditions_AAG.Name = "textBoxConditions_AAG";
            this.textBoxConditions_AAG.Size = new System.Drawing.Size(642, 83);
            this.textBoxConditions_AAG.TabIndex = 0;
            this.textBoxConditions_AAG.Text = resources.GetString("textBoxConditions_AAG.Text");
            // 
            // groupBoxVvodData_AAG
            // 
            this.groupBoxVvodData_AAG.Controls.Add(this.textBoxTextFinish_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.buttonHelp_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.textBoxStart_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.buttonSave_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.textBoxStopStep_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.buttonDone_AAG);
            this.groupBoxVvodData_AAG.Controls.Add(this.textBoxStartStep_AAG);
            this.groupBoxVvodData_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxVvodData_AAG.Location = new System.Drawing.Point(681, 0);
            this.groupBoxVvodData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvodData_AAG.Name = "groupBoxVvodData_AAG";
            this.groupBoxVvodData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvodData_AAG.Size = new System.Drawing.Size(637, 123);
            this.groupBoxVvodData_AAG.TabIndex = 14;
            this.groupBoxVvodData_AAG.TabStop = false;
            this.groupBoxVvodData_AAG.Text = "Ввод данных:";
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
            // textBoxStopStep_AAG
            // 
            this.textBoxStopStep_AAG.Location = new System.Drawing.Point(150, 56);
            this.textBoxStopStep_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStopStep_AAG.Name = "textBoxStopStep_AAG";
            this.textBoxStopStep_AAG.Size = new System.Drawing.Size(128, 26);
            this.textBoxStopStep_AAG.TabIndex = 6;
            this.textBoxStopStep_AAG.Text = "5";
            // 
            // textBoxStart_AAG
            // 
            this.textBoxStart_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStart_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_AAG.Location = new System.Drawing.Point(15, 26);
            this.textBoxStart_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStart_AAG.Name = "textBoxStart_AAG";
            this.textBoxStart_AAG.ReadOnly = true;
            this.textBoxStart_AAG.Size = new System.Drawing.Size(128, 19);
            this.textBoxStart_AAG.TabIndex = 5;
            this.textBoxStart_AAG.Text = "Старт шага:";
            // 
            // textBoxTextFinish_AAG
            // 
            this.textBoxTextFinish_AAG.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTextFinish_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTextFinish_AAG.Location = new System.Drawing.Point(150, 26);
            this.textBoxTextFinish_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTextFinish_AAG.Name = "textBoxTextFinish_AAG";
            this.textBoxTextFinish_AAG.ReadOnly = true;
            this.textBoxTextFinish_AAG.Size = new System.Drawing.Size(128, 19);
            this.textBoxTextFinish_AAG.TabIndex = 6;
            this.textBoxTextFinish_AAG.Text = "Конец шага:";
            // 
            // buttonSave_AAG
            // 
            this.buttonSave_AAG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_AAG.Location = new System.Drawing.Point(405, 18);
            this.buttonSave_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave_AAG.Name = "buttonSave_AAG";
            this.buttonSave_AAG.Size = new System.Drawing.Size(115, 64);
            this.buttonSave_AAG.TabIndex = 15;
            this.buttonSave_AAG.Text = "Сохранить";
            this.buttonSave_AAG.UseVisualStyleBackColor = false;
            this.buttonSave_AAG.Click += new System.EventHandler(this.SaveClick_AAG);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxConditions_AAG);
            this.panel1.Controls.Add(this.groupBoxVvodData_AAG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 123);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxNamedOne_AAG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 404);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.chartFunction_AAG);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 404);
            this.panel3.TabIndex = 18;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 404);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(300, 123);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 404);
            this.splitter2.TabIndex = 19;
            this.splitter2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 527);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1340, 583);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | Арама А. Г.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxNamedOne_AAG.ResumeLayout(false);
            this.groupBoxNamedOne_AAG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAG)).EndInit();
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.groupBoxVvodData_AAG.ResumeLayout(false);
            this.groupBoxVvodData_AAG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAG;
        private System.Windows.Forms.TextBox textBoxResult_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.TextBox textBoxConditions_AAG;
        private System.Windows.Forms.GroupBox groupBoxVvodData_AAG;
        private System.Windows.Forms.TextBox textBoxTextFinish_AAG;
        private System.Windows.Forms.TextBox textBoxStart_AAG;
        private System.Windows.Forms.TextBox textBoxStopStep_AAG;
        private System.Windows.Forms.TextBox textBoxStartStep_AAG;
        private System.Windows.Forms.Button buttonSave_AAG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

