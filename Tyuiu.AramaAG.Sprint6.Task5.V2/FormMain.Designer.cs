
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_AAG = new System.Windows.Forms.GroupBox();
            this.buttonOpen_AAG = new System.Windows.Forms.Button();
            this.textBoxNaamedOne_AAG = new System.Windows.Forms.TextBox();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxNamedOne_AAG = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_AAG = new System.Windows.Forms.DataGridView();
            this.chartResult_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.groupBoxNameedOne_AAG.SuspendLayout();
            this.groupBoxNamedOne_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 543);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxNameedOne_AAG
            // 
            this.groupBoxNameedOne_AAG.Controls.Add(this.textBoxNaamedOne_AAG);
            this.groupBoxNameedOne_AAG.Location = new System.Drawing.Point(3, 4);
            this.groupBoxNameedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Name = "groupBoxNameedOne_AAG";
            this.groupBoxNameedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Size = new System.Drawing.Size(630, 101);
            this.groupBoxNameedOne_AAG.TabIndex = 15;
            this.groupBoxNameedOne_AAG.TabStop = false;
            this.groupBoxNameedOne_AAG.Text = "Условие";
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
            // textBoxNaamedOne_AAG
            // 
            this.textBoxNaamedOne_AAG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNaamedOne_AAG.Location = new System.Drawing.Point(7, 26);
            this.textBoxNaamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNaamedOne_AAG.Multiline = true;
            this.textBoxNaamedOne_AAG.Name = "textBoxNaamedOne_AAG";
            this.textBoxNaamedOne_AAG.Size = new System.Drawing.Size(611, 68);
            this.textBoxNaamedOne_AAG.TabIndex = 0;
            this.textBoxNaamedOne_AAG.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести в" +
    "се отрицательные числа. Построить диаграмму по этим значениям. ";
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
            // groupBoxNamedOne_AAG
            // 
            this.groupBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNamedOne_AAG.Controls.Add(this.dataGridViewResult_AAG);
            this.groupBoxNamedOne_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNamedOne_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Name = "groupBoxNamedOne_AAG";
            this.groupBoxNamedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Size = new System.Drawing.Size(200, 431);
            this.groupBoxNamedOne_AAG.TabIndex = 11;
            this.groupBoxNamedOne_AAG.TabStop = false;
            this.groupBoxNamedOne_AAG.Text = "Вывод данных";
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
            // chartResult_AAG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_AAG.ChartAreas.Add(chartArea1);
            this.chartResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_AAG.Legends.Add(legend1);
            this.chartResult_AAG.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AAG.Name = "chartResult_AAG";
            this.chartResult_AAG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_AAG.Series.Add(series1);
            this.chartResult_AAG.Size = new System.Drawing.Size(797, 431);
            this.chartResult_AAG.TabIndex = 1;
            this.chartResult_AAG.Text = "chart1";
            this.chartResult_AAG.Click += new System.EventHandler(this.chartResult_AAG_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.buttonOpen_AAG);
            this.panel2.Controls.Add(this.groupBoxNameedOne_AAG);
            this.panel2.Controls.Add(this.buttonDone_AAG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 112);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxNamedOne_AAG);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 431);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartResult_AAG);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 431);
            this.panel4.TabIndex = 18;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(536, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 16;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonHelp_AAG);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(882, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(115, 112);
            this.panel6.TabIndex = 17;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 112);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 431);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 543);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1019, 599);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Арама А. Г.";
            this.panel1.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.PerformLayout();
            this.groupBoxNamedOne_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_AAG;
        private System.Windows.Forms.Button buttonOpen_AAG;
        private System.Windows.Forms.TextBox textBoxNaamedOne_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAG;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAG;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
    }
}

