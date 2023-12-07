
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOne_AAG = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_AAG = new System.Windows.Forms.GroupBox();
            this.buttonOpen_AAG = new System.Windows.Forms.Button();
            this.textBoxNaamedOne_AAG = new System.Windows.Forms.TextBox();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.groupBoxNamedOne_AAG = new System.Windows.Forms.GroupBox();
            this.chartResult_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_AAG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelOne_AAG.SuspendLayout();
            this.groupBoxNameedOne_AAG.SuspendLayout();
            this.groupBoxNamedOne_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelOne_AAG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 543);
            this.panel1.TabIndex = 0;
            // 
            // panelOne_AAG
            // 
            this.panelOne_AAG.Controls.Add(this.groupBoxNameedOne_AAG);
            this.panelOne_AAG.Controls.Add(this.groupBoxNamedOne_AAG);
            this.panelOne_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOne_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelOne_AAG.Name = "panelOne_AAG";
            this.panelOne_AAG.Size = new System.Drawing.Size(997, 543);
            this.panelOne_AAG.TabIndex = 17;
            // 
            // groupBoxNameedOne_AAG
            // 
            this.groupBoxNameedOne_AAG.Controls.Add(this.buttonOpen_AAG);
            this.groupBoxNameedOne_AAG.Controls.Add(this.textBoxNaamedOne_AAG);
            this.groupBoxNameedOne_AAG.Controls.Add(this.buttonHelp_AAG);
            this.groupBoxNameedOne_AAG.Controls.Add(this.buttonDone_AAG);
            this.groupBoxNameedOne_AAG.Location = new System.Drawing.Point(12, 24);
            this.groupBoxNameedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Name = "groupBoxNameedOne_AAG";
            this.groupBoxNameedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Size = new System.Drawing.Size(969, 115);
            this.groupBoxNameedOne_AAG.TabIndex = 15;
            this.groupBoxNameedOne_AAG.TabStop = false;
            this.groupBoxNameedOne_AAG.Text = "Условие";
            // 
            // buttonOpen_AAG
            // 
            this.buttonOpen_AAG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpen_AAG.Location = new System.Drawing.Point(752, 30);
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
            this.buttonHelp_AAG.Location = new System.Drawing.Point(872, 30);
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
            this.buttonDone_AAG.Location = new System.Drawing.Point(631, 30);
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
            this.groupBoxNamedOne_AAG.Controls.Add(this.chartResult_AAG);
            this.groupBoxNamedOne_AAG.Location = new System.Drawing.Point(12, 147);
            this.groupBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Name = "groupBoxNamedOne_AAG";
            this.groupBoxNamedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNamedOne_AAG.Size = new System.Drawing.Size(969, 376);
            this.groupBoxNamedOne_AAG.TabIndex = 11;
            this.groupBoxNamedOne_AAG.TabStop = false;
            this.groupBoxNamedOne_AAG.Text = "Вывод данных";
            // 
            // chartResult_AAG
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_AAG.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_AAG.Legends.Add(legend5);
            this.chartResult_AAG.Location = new System.Drawing.Point(242, 43);
            this.chartResult_AAG.Name = "chartResult_AAG";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_AAG.Series.Add(series5);
            this.chartResult_AAG.Size = new System.Drawing.Size(663, 300);
            this.chartResult_AAG.TabIndex = 1;
            this.chartResult_AAG.Text = "chart1";
            // 
            // dataGridViewResult_AAG
            // 
            this.dataGridViewResult_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAG.ColumnHeadersVisible = false;
            this.dataGridViewResult_AAG.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewResult_AAG.Name = "dataGridViewResult_AAG";
            this.dataGridViewResult_AAG.RowHeadersVisible = false;
            this.dataGridViewResult_AAG.RowHeadersWidth = 62;
            this.dataGridViewResult_AAG.RowTemplate.Height = 28;
            this.dataGridViewResult_AAG.Size = new System.Drawing.Size(205, 343);
            this.dataGridViewResult_AAG.TabIndex = 2;
            this.dataGridViewResult_AAG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.panelOne_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.PerformLayout();
            this.groupBoxNamedOne_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOne_AAG;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_AAG;
        private System.Windows.Forms.Button buttonOpen_AAG;
        private System.Windows.Forms.TextBox textBoxNaamedOne_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAG;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAG;
    }
}

