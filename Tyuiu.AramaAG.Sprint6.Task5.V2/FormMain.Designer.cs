
namespace Tyuiu.AramaAG.Sprint6.Task5.V2
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
            this.panelTop_AAG = new System.Windows.Forms.Panel();
            this.splitter_AAG = new System.Windows.Forms.Splitter();
            this.panelRightCentre = new System.Windows.Forms.Panel();
            this.chartResult_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.groupBoxVvidData_AAG = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_AAG = new System.Windows.Forms.DataGridView();
            this.panelTopL_AAG = new System.Windows.Forms.Panel();
            this.panelTopLeft_AAG = new System.Windows.Forms.Panel();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonOpen_AAG = new System.Windows.Forms.Button();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxConditions_AAG = new System.Windows.Forms.TextBox();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.panelTop_AAG.SuspendLayout();
            this.panelRightCentre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).BeginInit();
            this.panelLeft_AAG.SuspendLayout();
            this.groupBoxVvidData_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).BeginInit();
            this.panelTopL_AAG.SuspendLayout();
            this.panelTopLeft_AAG.SuspendLayout();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Controls.Add(this.splitter_AAG);
            this.panelTop_AAG.Controls.Add(this.panelRightCentre);
            this.panelTop_AAG.Controls.Add(this.panelLeft_AAG);
            this.panelTop_AAG.Controls.Add(this.panelTopL_AAG);
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(997, 543);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // splitter_AAG
            // 
            this.splitter_AAG.Location = new System.Drawing.Point(200, 112);
            this.splitter_AAG.Name = "splitter_AAG";
            this.splitter_AAG.Size = new System.Drawing.Size(3, 431);
            this.splitter_AAG.TabIndex = 19;
            this.splitter_AAG.TabStop = false;
            // 
            // panelRightCentre
            // 
            this.panelRightCentre.Controls.Add(this.chartResult_AAG);
            this.panelRightCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightCentre.Location = new System.Drawing.Point(200, 112);
            this.panelRightCentre.Name = "panelRightCentre";
            this.panelRightCentre.Size = new System.Drawing.Size(797, 431);
            this.panelRightCentre.TabIndex = 18;
            this.panelRightCentre.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // chartResult_AAG
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_AAG.ChartAreas.Add(chartArea2);
            this.chartResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartResult_AAG.Legends.Add(legend2);
            this.chartResult_AAG.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AAG.Name = "chartResult_AAG";
            this.chartResult_AAG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_AAG.Series.Add(series2);
            this.chartResult_AAG.Size = new System.Drawing.Size(797, 431);
            this.chartResult_AAG.TabIndex = 1;
            this.chartResult_AAG.Text = "chart1";
            this.chartResult_AAG.Click += new System.EventHandler(this.chartResult_AAG_Click);
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Controls.Add(this.groupBoxVvidData_AAG);
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 112);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(200, 431);
            this.panelLeft_AAG.TabIndex = 17;
            // 
            // groupBoxVvidData_AAG
            // 
            this.groupBoxVvidData_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxVvidData_AAG.Controls.Add(this.dataGridViewResult_AAG);
            this.groupBoxVvidData_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvidData_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvidData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvidData_AAG.Name = "groupBoxVvidData_AAG";
            this.groupBoxVvidData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvidData_AAG.Size = new System.Drawing.Size(200, 431);
            this.groupBoxVvidData_AAG.TabIndex = 11;
            this.groupBoxVvidData_AAG.TabStop = false;
            this.groupBoxVvidData_AAG.Text = "Вывод данных";
            // 
            // dataGridViewResult_AAG
            // 
            this.dataGridViewResult_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAG.ColumnHeadersVisible = false;
            this.dataGridViewResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_AAG.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewResult_AAG.Name = "dataGridViewResult_AAG";
            this.dataGridViewResult_AAG.RowHeadersVisible = false;
            this.dataGridViewResult_AAG.RowHeadersWidth = 62;
            this.dataGridViewResult_AAG.RowTemplate.Height = 28;
            this.dataGridViewResult_AAG.Size = new System.Drawing.Size(194, 404);
            this.dataGridViewResult_AAG.TabIndex = 2;
            this.dataGridViewResult_AAG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelTopL_AAG
            // 
            this.panelTopL_AAG.Controls.Add(this.panelTopLeft_AAG);
            this.panelTopL_AAG.Controls.Add(this.buttonOpen_AAG);
            this.panelTopL_AAG.Controls.Add(this.groupBoxConditions_AAG);
            this.panelTopL_AAG.Controls.Add(this.buttonDone_AAG);
            this.panelTopL_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopL_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTopL_AAG.Name = "panelTopL_AAG";
            this.panelTopL_AAG.Size = new System.Drawing.Size(997, 112);
            this.panelTopL_AAG.TabIndex = 16;
            // 
            // panelTopLeft_AAG
            // 
            this.panelTopLeft_AAG.Controls.Add(this.buttonHelp_AAG);
            this.panelTopLeft_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopLeft_AAG.Location = new System.Drawing.Point(882, 0);
            this.panelTopLeft_AAG.Name = "panelTopLeft_AAG";
            this.panelTopLeft_AAG.Size = new System.Drawing.Size(115, 112);
            this.panelTopLeft_AAG.TabIndex = 17;
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(3, 30);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(88, 64);
            this.buttonHelp_AAG.TabIndex = 13;
            this.buttonHelp_AAG.Text = "Справка";
            this.buttonHelp_AAG.UseVisualStyleBackColor = false;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.Help_AAGClick);
            // 
            // buttonOpen_AAG
            // 
            this.buttonOpen_AAG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpen_AAG.Location = new System.Drawing.Point(761, 34);
            this.buttonOpen_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpen_AAG.Name = "buttonOpen_AAG";
            this.buttonOpen_AAG.Size = new System.Drawing.Size(115, 64);
            this.buttonOpen_AAG.TabIndex = 15;
            this.buttonOpen_AAG.Text = "Открыть файл";
            this.buttonOpen_AAG.UseVisualStyleBackColor = false;
            this.buttonOpen_AAG.Click += new System.EventHandler(this.OpenFileClick_AAG);
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxConditions_AAG);
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(3, 4);
            this.groupBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(630, 101);
            this.groupBoxConditions_AAG.TabIndex = 15;
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
            this.textBoxConditions_AAG.Size = new System.Drawing.Size(611, 68);
            this.textBoxConditions_AAG.TabIndex = 0;
            this.textBoxConditions_AAG.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести в" +
    "се отрицательные числа. Построить диаграмму по этим значениям. ";
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_AAG.Location = new System.Drawing.Point(640, 34);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(115, 64);
            this.buttonDone_AAG.TabIndex = 12;
            this.buttonDone_AAG.Text = "Выполнить";
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.DoneClick_AAG);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 543);
            this.Controls.Add(this.panelTop_AAG);
            this.MinimumSize = new System.Drawing.Size(1019, 599);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Арама А. Г.";
            this.panelTop_AAG.ResumeLayout(false);
            this.panelRightCentre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).EndInit();
            this.panelLeft_AAG.ResumeLayout(false);
            this.groupBoxVvidData_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).EndInit();
            this.panelTopL_AAG.ResumeLayout(false);
            this.panelTopLeft_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.Button buttonOpen_AAG;
        private System.Windows.Forms.TextBox textBoxConditions_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxVvidData_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAG;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAG;
        private System.Windows.Forms.Panel panelRightCentre;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.Panel panelTopL_AAG;
        private System.Windows.Forms.Panel panelTopLeft_AAG;
        private System.Windows.Forms.Splitter splitter_AAG;
    }
}

