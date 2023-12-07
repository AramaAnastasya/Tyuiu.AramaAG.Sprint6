
namespace Tyuiu.AramaAG.Sprint6.Task7.V8
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelOne_AAG = new System.Windows.Forms.Panel();
            this.panelTwo_AAG = new System.Windows.Forms.Panel();
            this.groupBoxNameedOne_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_AAG = new System.Windows.Forms.TextBox();
            this.panelThree_AAG = new System.Windows.Forms.Panel();
            this.groupBoxTwo_AAG = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFour_AAG = new System.Windows.Forms.Panel();
            this.groupBoxThree_AAG = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewInMatrix_AAG = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutMatrix_AAG = new System.Windows.Forms.DataGridView();
            this.buttonSave_AAG = new System.Windows.Forms.Button();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.buttonOpenFile_AAG = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_AAG = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_AAG.SuspendLayout();
            this.panelTwo_AAG.SuspendLayout();
            this.groupBoxNameedOne_AAG.SuspendLayout();
            this.panelThree_AAG.SuspendLayout();
            this.groupBoxTwo_AAG.SuspendLayout();
            this.panelFour_AAG.SuspendLayout();
            this.groupBoxThree_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_AAG
            // 
            this.panelOne_AAG.Controls.Add(this.buttonSave_AAG);
            this.panelOne_AAG.Controls.Add(this.buttonHelp_AAG);
            this.panelOne_AAG.Controls.Add(this.buttonDone_AAG);
            this.panelOne_AAG.Controls.Add(this.buttonOpenFile_AAG);
            this.panelOne_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOne_AAG.Name = "panelOne_AAG";
            this.panelOne_AAG.Size = new System.Drawing.Size(1048, 106);
            this.panelOne_AAG.TabIndex = 0;
            // 
            // panelTwo_AAG
            // 
            this.panelTwo_AAG.Controls.Add(this.groupBoxNameedOne_AAG);
            this.panelTwo_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_AAG.Location = new System.Drawing.Point(0, 106);
            this.panelTwo_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTwo_AAG.Name = "panelTwo_AAG";
            this.panelTwo_AAG.Size = new System.Drawing.Size(1048, 109);
            this.panelTwo_AAG.TabIndex = 1;
            // 
            // groupBoxNameedOne_AAG
            // 
            this.groupBoxNameedOne_AAG.Controls.Add(this.textBoxNamedOne_AAG);
            this.groupBoxNameedOne_AAG.Location = new System.Drawing.Point(3, 4);
            this.groupBoxNameedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Name = "groupBoxNameedOne_AAG";
            this.groupBoxNameedOne_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxNameedOne_AAG.Size = new System.Drawing.Size(1042, 101);
            this.groupBoxNameedOne_AAG.TabIndex = 9;
            this.groupBoxNameedOne_AAG.TabStop = false;
            this.groupBoxNameedOne_AAG.Text = "Условие";
            // 
            // textBoxNamedOne_AAG
            // 
            this.textBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamedOne_AAG.Location = new System.Drawing.Point(7, 26);
            this.textBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamedOne_AAG.Multiline = true;
            this.textBoxNamedOne_AAG.Name = "textBoxNamedOne_AAG";
            this.textBoxNamedOne_AAG.ReadOnly = true;
            this.textBoxNamedOne_AAG.Size = new System.Drawing.Size(1021, 66);
            this.textBoxNamedOne_AAG.TabIndex = 3;
            this.textBoxNamedOne_AAG.Text = resources.GetString("textBoxNamedOne_AAG.Text");
            // 
            // panelThree_AAG
            // 
            this.panelThree_AAG.Controls.Add(this.groupBoxTwo_AAG);
            this.panelThree_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_AAG.Location = new System.Drawing.Point(0, 215);
            this.panelThree_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelThree_AAG.Name = "panelThree_AAG";
            this.panelThree_AAG.Size = new System.Drawing.Size(507, 426);
            this.panelThree_AAG.TabIndex = 2;
            // 
            // groupBoxTwo_AAG
            // 
            this.groupBoxTwo_AAG.Controls.Add(this.dataGridViewInMatrix_AAG);
            this.groupBoxTwo_AAG.Location = new System.Drawing.Point(14, 8);
            this.groupBoxTwo_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTwo_AAG.Name = "groupBoxTwo_AAG";
            this.groupBoxTwo_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTwo_AAG.Size = new System.Drawing.Size(487, 405);
            this.groupBoxTwo_AAG.TabIndex = 0;
            this.groupBoxTwo_AAG.TabStop = false;
            this.groupBoxTwo_AAG.Text = "Ввод";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(507, 215);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 426);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelFour_AAG
            // 
            this.panelFour_AAG.Controls.Add(this.groupBoxThree_AAG);
            this.panelFour_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_AAG.Location = new System.Drawing.Point(510, 215);
            this.panelFour_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFour_AAG.Name = "panelFour_AAG";
            this.panelFour_AAG.Size = new System.Drawing.Size(538, 426);
            this.panelFour_AAG.TabIndex = 4;
            // 
            // groupBoxThree_AAG
            // 
            this.groupBoxThree_AAG.Controls.Add(this.dataGridViewOutMatrix_AAG);
            this.groupBoxThree_AAG.Location = new System.Drawing.Point(10, 8);
            this.groupBoxThree_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxThree_AAG.Name = "groupBoxThree_AAG";
            this.groupBoxThree_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxThree_AAG.Size = new System.Drawing.Size(514, 405);
            this.groupBoxThree_AAG.TabIndex = 1;
            this.groupBoxThree_AAG.TabStop = false;
            this.groupBoxThree_AAG.Text = "Вывод";
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog";
            // 
            // toolTipOne
            // 
            this.toolTipOne.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOne.ToolTipTitle = "Подсказка";
            // 
            // dataGridViewInMatrix_AAG
            // 
            this.dataGridViewInMatrix_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_AAG.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_AAG.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewInMatrix_AAG.Name = "dataGridViewInMatrix_AAG";
            this.dataGridViewInMatrix_AAG.RowHeadersVisible = false;
            this.dataGridViewInMatrix_AAG.RowHeadersWidth = 62;
            this.dataGridViewInMatrix_AAG.RowTemplate.Height = 28;
            this.dataGridViewInMatrix_AAG.Size = new System.Drawing.Size(475, 372);
            this.dataGridViewInMatrix_AAG.TabIndex = 0;
            // 
            // dataGridViewOutMatrix_AAG
            // 
            this.dataGridViewOutMatrix_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_AAG.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_AAG.Location = new System.Drawing.Point(20, 23);
            this.dataGridViewOutMatrix_AAG.Name = "dataGridViewOutMatrix_AAG";
            this.dataGridViewOutMatrix_AAG.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_AAG.RowHeadersWidth = 62;
            this.dataGridViewOutMatrix_AAG.RowTemplate.Height = 28;
            this.dataGridViewOutMatrix_AAG.Size = new System.Drawing.Size(475, 375);
            this.dataGridViewOutMatrix_AAG.TabIndex = 1;
            // 
            // buttonSave_AAG
            // 
            this.buttonSave_AAG.Enabled = false;
            this.buttonSave_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.page_save;
            this.buttonSave_AAG.Location = new System.Drawing.Point(219, 13);
            this.buttonSave_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave_AAG.Name = "buttonSave_AAG";
            this.buttonSave_AAG.Size = new System.Drawing.Size(98, 82);
            this.buttonSave_AAG.TabIndex = 3;
            this.toolTipOne.SetToolTip(this.buttonSave_AAG, "Сохранить обработанные данные в формате csv");
            this.buttonSave_AAG.UseVisualStyleBackColor = true;
            this.buttonSave_AAG.Click += new System.EventHandler(this.ClickSave_AAG);
            this.buttonSave_AAG.MouseEnter += new System.EventHandler(this.ClickSaveFile_AAG);
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.help;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(928, 15);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(100, 82);
            this.buttonHelp_AAG.TabIndex = 2;
            this.toolTipOne.SetToolTip(this.buttonHelp_AAG, "Сведение о программе");
            this.buttonHelp_AAG.UseVisualStyleBackColor = true;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.ClickHelp_AAG);
            this.buttonHelp_AAG.MouseEnter += new System.EventHandler(this.ClickHelpFile_AAG);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.Enabled = false;
            this.buttonDone_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.page_go;
            this.buttonDone_AAG.Location = new System.Drawing.Point(115, 15);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(98, 82);
            this.buttonDone_AAG.TabIndex = 1;
            this.toolTipOne.SetToolTip(this.buttonDone_AAG, "Выпонить обратку \r\nВыполнить обработку данных");
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.ClickDone_AAG);
            this.buttonDone_AAG.MouseEnter += new System.EventHandler(this.ClickDoneFile_AAG);
            // 
            // buttonOpenFile_AAG
            // 
            this.buttonOpenFile_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.folder_page;
            this.buttonOpenFile_AAG.Location = new System.Drawing.Point(14, 15);
            this.buttonOpenFile_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile_AAG.Name = "buttonOpenFile_AAG";
            this.buttonOpenFile_AAG.Size = new System.Drawing.Size(94, 82);
            this.buttonOpenFile_AAG.TabIndex = 0;
            this.toolTipOne.SetToolTip(this.buttonOpenFile_AAG, "Открыть файл\r\nОткрыть файл  для обработки данных в формате cvs");
            this.buttonOpenFile_AAG.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AAG.Click += new System.EventHandler(this.ClickOpenFile_AAG);
            this.buttonOpenFile_AAG.MouseEnter += new System.EventHandler(this.VouseEntesOpen_AAG);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 641);
            this.Controls.Add(this.panelFour_AAG);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelThree_AAG);
            this.Controls.Add(this.panelTwo_AAG);
            this.Controls.Add(this.panelOne_AAG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 8 | Арама А.Г.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOne_AAG.ResumeLayout(false);
            this.panelTwo_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.ResumeLayout(false);
            this.groupBoxNameedOne_AAG.PerformLayout();
            this.panelThree_AAG.ResumeLayout(false);
            this.groupBoxTwo_AAG.ResumeLayout(false);
            this.panelFour_AAG.ResumeLayout(false);
            this.groupBoxThree_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAG)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panelOne_AAG;
        private System.Windows.Forms.Panel panelTwo_AAG;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_AAG;
        private System.Windows.Forms.TextBox textBoxNamedOne_AAG;
        private System.Windows.Forms.Panel panelThree_AAG;
        private System.Windows.Forms.GroupBox groupBoxTwo_AAG;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFour_AAG;
        private System.Windows.Forms.GroupBox groupBoxThree_AAG;
        private System.Windows.Forms.Button buttonOpenFile_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.Button buttonSave_AAG;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_AAG;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_AAG;
        private System.Windows.Forms.ToolTip toolTipOne;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_AAG;
    }
}

