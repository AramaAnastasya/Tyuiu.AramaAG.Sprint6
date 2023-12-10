
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
            this.panelTop_AAG = new System.Windows.Forms.Panel();
            this.buttonSave_AAG = new System.Windows.Forms.Button();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.buttonOpenFile_AAG = new System.Windows.Forms.Button();
            this.panelTwo_AAG = new System.Windows.Forms.Panel();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxNamedOne_AAG = new System.Windows.Forms.TextBox();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.groupBoxVvoddData_AAG = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_AAG = new System.Windows.Forms.DataGridView();
            this.splitter_AAG = new System.Windows.Forms.Splitter();
            this.panelRight_AAG = new System.Windows.Forms.Panel();
            this.groupBoxResult_AAG = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_AAG = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_AAG = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne_AAG = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_AAG = new System.Windows.Forms.SaveFileDialog();
            this.panelTopLeft_AAG = new System.Windows.Forms.Panel();
            this.panelTop_AAG.SuspendLayout();
            this.panelTwo_AAG.SuspendLayout();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.panelLeft_AAG.SuspendLayout();
            this.groupBoxVvoddData_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAG)).BeginInit();
            this.panelRight_AAG.SuspendLayout();
            this.groupBoxResult_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAG)).BeginInit();
            this.panelTopLeft_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Controls.Add(this.panelTopLeft_AAG);
            this.panelTop_AAG.Controls.Add(this.buttonSave_AAG);
            this.panelTop_AAG.Controls.Add(this.buttonDone_AAG);
            this.panelTop_AAG.Controls.Add(this.buttonOpenFile_AAG);
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1048, 106);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // buttonSave_AAG
            // 
            this.buttonSave_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_AAG.Enabled = false;
            this.buttonSave_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.page_save;
            this.buttonSave_AAG.Location = new System.Drawing.Point(219, 15);
            this.buttonSave_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave_AAG.Name = "buttonSave_AAG";
            this.buttonSave_AAG.Size = new System.Drawing.Size(98, 82);
            this.buttonSave_AAG.TabIndex = 3;
            this.toolTipOne_AAG.SetToolTip(this.buttonSave_AAG, "Сохранить обработанные данные в формате csv");
            this.buttonSave_AAG.UseVisualStyleBackColor = true;
            this.buttonSave_AAG.Click += new System.EventHandler(this.ClickSave_AAG);
            this.buttonSave_AAG.MouseEnter += new System.EventHandler(this.ClickSaveFile_AAG);
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.help;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(18, 16);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(100, 82);
            this.buttonHelp_AAG.TabIndex = 2;
            this.toolTipOne_AAG.SetToolTip(this.buttonHelp_AAG, "Сведение о программе");
            this.buttonHelp_AAG.UseVisualStyleBackColor = true;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.ClickHelp_AAG);
            this.buttonHelp_AAG.MouseEnter += new System.EventHandler(this.ClickHelpFile_AAG);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_AAG.Enabled = false;
            this.buttonDone_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.page_go;
            this.buttonDone_AAG.Location = new System.Drawing.Point(115, 15);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(98, 82);
            this.buttonDone_AAG.TabIndex = 1;
            this.toolTipOne_AAG.SetToolTip(this.buttonDone_AAG, "Выполнить обработку данных");
            this.buttonDone_AAG.UseVisualStyleBackColor = false;
            this.buttonDone_AAG.Click += new System.EventHandler(this.ClickDone_AAG);
            this.buttonDone_AAG.MouseEnter += new System.EventHandler(this.ClickDoneFile_AAG);
            // 
            // buttonOpenFile_AAG
            // 
            this.buttonOpenFile_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_AAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task7.V8.Properties.Resources.folder_page;
            this.buttonOpenFile_AAG.Location = new System.Drawing.Point(14, 15);
            this.buttonOpenFile_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile_AAG.Name = "buttonOpenFile_AAG";
            this.buttonOpenFile_AAG.Size = new System.Drawing.Size(94, 82);
            this.buttonOpenFile_AAG.TabIndex = 0;
            this.toolTipOne_AAG.SetToolTip(this.buttonOpenFile_AAG, "Открыть файл  для обработки данных в формате cvs");
            this.buttonOpenFile_AAG.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AAG.Click += new System.EventHandler(this.ClickOpenFile_AAG);
            this.buttonOpenFile_AAG.MouseEnter += new System.EventHandler(this.VouseEntesOpen_AAG);
            // 
            // panelTwo_AAG
            // 
            this.panelTwo_AAG.Controls.Add(this.groupBoxConditions_AAG);
            this.panelTwo_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_AAG.Location = new System.Drawing.Point(0, 106);
            this.panelTwo_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTwo_AAG.Name = "panelTwo_AAG";
            this.panelTwo_AAG.Size = new System.Drawing.Size(1048, 109);
            this.panelTwo_AAG.TabIndex = 1;
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxNamedOne_AAG);
            this.groupBoxConditions_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConditions_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Name = "groupBoxConditions_AAG";
            this.groupBoxConditions_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConditions_AAG.Size = new System.Drawing.Size(1048, 109);
            this.groupBoxConditions_AAG.TabIndex = 9;
            this.groupBoxConditions_AAG.TabStop = false;
            this.groupBoxConditions_AAG.Text = "Условие";
            // 
            // textBoxNamedOne_AAG
            // 
            this.textBoxNamedOne_AAG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNamedOne_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamedOne_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamedOne_AAG.Location = new System.Drawing.Point(3, 23);
            this.textBoxNamedOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamedOne_AAG.Multiline = true;
            this.textBoxNamedOne_AAG.Name = "textBoxNamedOne_AAG";
            this.textBoxNamedOne_AAG.ReadOnly = true;
            this.textBoxNamedOne_AAG.Size = new System.Drawing.Size(1042, 82);
            this.textBoxNamedOne_AAG.TabIndex = 3;
            this.textBoxNamedOne_AAG.Text = resources.GetString("textBoxNamedOne_AAG.Text");
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Controls.Add(this.groupBoxVvoddData_AAG);
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 215);
            this.panelLeft_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(507, 426);
            this.panelLeft_AAG.TabIndex = 2;
            // 
            // groupBoxVvoddData_AAG
            // 
            this.groupBoxVvoddData_AAG.Controls.Add(this.dataGridViewInMatrix_AAG);
            this.groupBoxVvoddData_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvoddData_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvoddData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvoddData_AAG.Name = "groupBoxVvoddData_AAG";
            this.groupBoxVvoddData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvoddData_AAG.Size = new System.Drawing.Size(507, 426);
            this.groupBoxVvoddData_AAG.TabIndex = 0;
            this.groupBoxVvoddData_AAG.TabStop = false;
            this.groupBoxVvoddData_AAG.Text = "Ввод";
            // 
            // dataGridViewInMatrix_AAG
            // 
            this.dataGridViewInMatrix_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_AAG.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_AAG.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewInMatrix_AAG.Name = "dataGridViewInMatrix_AAG";
            this.dataGridViewInMatrix_AAG.RowHeadersVisible = false;
            this.dataGridViewInMatrix_AAG.RowHeadersWidth = 62;
            this.dataGridViewInMatrix_AAG.RowTemplate.Height = 28;
            this.dataGridViewInMatrix_AAG.Size = new System.Drawing.Size(501, 399);
            this.dataGridViewInMatrix_AAG.TabIndex = 0;
            // 
            // splitter_AAG
            // 
            this.splitter_AAG.Location = new System.Drawing.Point(507, 215);
            this.splitter_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter_AAG.Name = "splitter_AAG";
            this.splitter_AAG.Size = new System.Drawing.Size(3, 426);
            this.splitter_AAG.TabIndex = 3;
            this.splitter_AAG.TabStop = false;
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Controls.Add(this.groupBoxResult_AAG);
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_AAG.Location = new System.Drawing.Point(510, 215);
            this.panelRight_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(538, 426);
            this.panelRight_AAG.TabIndex = 4;
            // 
            // groupBoxResult_AAG
            // 
            this.groupBoxResult_AAG.Controls.Add(this.dataGridViewOutMatrix_AAG);
            this.groupBoxResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Name = "groupBoxResult_AAG";
            this.groupBoxResult_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Size = new System.Drawing.Size(538, 426);
            this.groupBoxResult_AAG.TabIndex = 1;
            this.groupBoxResult_AAG.TabStop = false;
            this.groupBoxResult_AAG.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_AAG
            // 
            this.dataGridViewOutMatrix_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_AAG.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_AAG.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewOutMatrix_AAG.Name = "dataGridViewOutMatrix_AAG";
            this.dataGridViewOutMatrix_AAG.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_AAG.RowHeadersWidth = 62;
            this.dataGridViewOutMatrix_AAG.RowTemplate.Height = 28;
            this.dataGridViewOutMatrix_AAG.Size = new System.Drawing.Size(532, 399);
            this.dataGridViewOutMatrix_AAG.TabIndex = 1;
            // 
            // openFileDialogTask_AAG
            // 
            this.openFileDialogTask_AAG.FileName = "openFileDialog";
            // 
            // toolTipOne_AAG
            // 
            this.toolTipOne_AAG.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOne_AAG.ToolTipTitle = "Подсказка";
            // 
            // panelTopLeft_AAG
            // 
            this.panelTopLeft_AAG.Controls.Add(this.buttonHelp_AAG);
            this.panelTopLeft_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopLeft_AAG.Location = new System.Drawing.Point(911, 0);
            this.panelTopLeft_AAG.Name = "panelTopLeft_AAG";
            this.panelTopLeft_AAG.Size = new System.Drawing.Size(137, 106);
            this.panelTopLeft_AAG.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 641);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.splitter_AAG);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelTwo_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 8 | Арама А.Г.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_AAG.ResumeLayout(false);
            this.panelTwo_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.panelLeft_AAG.ResumeLayout(false);
            this.groupBoxVvoddData_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAG)).EndInit();
            this.panelRight_AAG.ResumeLayout(false);
            this.groupBoxResult_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAG)).EndInit();
            this.panelTopLeft_AAG.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelTwo_AAG;
        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.TextBox textBoxNamedOne_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.GroupBox groupBoxVvoddData_AAG;
        private System.Windows.Forms.Splitter splitter_AAG;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.GroupBox groupBoxResult_AAG;
        private System.Windows.Forms.Button buttonOpenFile_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAG;
        private System.Windows.Forms.Button buttonSave_AAG;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_AAG;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_AAG;
        private System.Windows.Forms.ToolTip toolTipOne_AAG;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_AAG;
        private System.Windows.Forms.Panel panelTopLeft_AAG;
    }
}

