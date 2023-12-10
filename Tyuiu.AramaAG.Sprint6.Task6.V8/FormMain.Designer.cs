
namespace Tyuiu.AramaAG.Sprint6.Task6.V8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_AAG = new System.Windows.Forms.Panel();
            this.buttonHelp_AAG = new System.Windows.Forms.Button();
            this.buttonDone_AAG = new System.Windows.Forms.Button();
            this.buttonOpenFile_AAG = new System.Windows.Forms.Button();
            this.panelSeredina_AAG = new System.Windows.Forms.Panel();
            this.groupBoxConditions_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxConditions_AAG = new System.Windows.Forms.TextBox();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.groupBoxVvodData_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_AAG = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight_AAG = new System.Windows.Forms.Panel();
            this.groupBoxResult_AAG = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AAG = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_AAG = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne_AAG = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop_AAG.SuspendLayout();
            this.panelSeredina_AAG.SuspendLayout();
            this.groupBoxConditions_AAG.SuspendLayout();
            this.panelLeft_AAG.SuspendLayout();
            this.groupBoxVvodData_AAG.SuspendLayout();
            this.panelRight_AAG.SuspendLayout();
            this.groupBoxResult_AAG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Controls.Add(this.panel1);
            this.panelTop_AAG.Controls.Add(this.buttonDone_AAG);
            this.panelTop_AAG.Controls.Add(this.buttonOpenFile_AAG);
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1048, 106);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // buttonHelp_AAG
            // 
            this.buttonHelp_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task6.V8.Properties.Resources.help;
            this.buttonHelp_AAG.Location = new System.Drawing.Point(43, 13);
            this.buttonHelp_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_AAG.Name = "buttonHelp_AAG";
            this.buttonHelp_AAG.Size = new System.Drawing.Size(100, 82);
            this.buttonHelp_AAG.TabIndex = 2;
            this.toolTipOne_AAG.SetToolTip(this.buttonHelp_AAG, "Сведение о программе");
            this.buttonHelp_AAG.UseVisualStyleBackColor = true;
            this.buttonHelp_AAG.Click += new System.EventHandler(this.buttonHelp_AAG_Click);
            // 
            // buttonDone_AAG
            // 
            this.buttonDone_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_AAG.Enabled = false;
            this.buttonDone_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task6.V8.Properties.Resources.page_go;
            this.buttonDone_AAG.Location = new System.Drawing.Point(115, 15);
            this.buttonDone_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone_AAG.Name = "buttonDone_AAG";
            this.buttonDone_AAG.Size = new System.Drawing.Size(98, 82);
            this.buttonDone_AAG.TabIndex = 1;
            this.toolTipOne_AAG.SetToolTip(this.buttonDone_AAG, "Производит поиск в файле и выводит предпоследнее слово каждой строки в результиру" +
        "ющею строку");
            this.buttonDone_AAG.UseVisualStyleBackColor = true;
            this.buttonDone_AAG.Click += new System.EventHandler(this.buttonDone_AAG_Click);
            // 
            // buttonOpenFile_AAG
            // 
            this.buttonOpenFile_AAG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task6.V8.Properties.Resources.folder_page;
            this.buttonOpenFile_AAG.Location = new System.Drawing.Point(14, 15);
            this.buttonOpenFile_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile_AAG.Name = "buttonOpenFile_AAG";
            this.buttonOpenFile_AAG.Size = new System.Drawing.Size(94, 82);
            this.buttonOpenFile_AAG.TabIndex = 0;
            this.toolTipOne_AAG.SetToolTip(this.buttonOpenFile_AAG, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_AAG.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AAG.Click += new System.EventHandler(this.buttonOpenFile_AAG_Click);
            // 
            // panelSeredina_AAG
            // 
            this.panelSeredina_AAG.Controls.Add(this.groupBoxConditions_AAG);
            this.panelSeredina_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeredina_AAG.Location = new System.Drawing.Point(0, 106);
            this.panelSeredina_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSeredina_AAG.Name = "panelSeredina_AAG";
            this.panelSeredina_AAG.Size = new System.Drawing.Size(1048, 109);
            this.panelSeredina_AAG.TabIndex = 1;
            // 
            // groupBoxConditions_AAG
            // 
            this.groupBoxConditions_AAG.Controls.Add(this.textBoxConditions_AAG);
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
            // textBoxConditions_AAG
            // 
            this.textBoxConditions_AAG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxConditions_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConditions_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConditions_AAG.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConditions_AAG.Location = new System.Drawing.Point(3, 23);
            this.textBoxConditions_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxConditions_AAG.Multiline = true;
            this.textBoxConditions_AAG.Name = "textBoxConditions_AAG";
            this.textBoxConditions_AAG.ReadOnly = true;
            this.textBoxConditions_AAG.Size = new System.Drawing.Size(1042, 82);
            this.textBoxConditions_AAG.TabIndex = 3;
            this.textBoxConditions_AAG.Text = resources.GetString("textBoxConditions_AAG.Text");
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Controls.Add(this.groupBoxVvodData_AAG);
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 215);
            this.panelLeft_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(507, 414);
            this.panelLeft_AAG.TabIndex = 2;
            // 
            // groupBoxVvodData_AAG
            // 
            this.groupBoxVvodData_AAG.Controls.Add(this.textBoxLoadFromFile_AAG);
            this.groupBoxVvodData_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvodData_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvodData_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvodData_AAG.Name = "groupBoxVvodData_AAG";
            this.groupBoxVvodData_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxVvodData_AAG.Size = new System.Drawing.Size(507, 414);
            this.groupBoxVvodData_AAG.TabIndex = 0;
            this.groupBoxVvodData_AAG.TabStop = false;
            this.groupBoxVvodData_AAG.Text = "Ввод";
            // 
            // textBoxLoadFromFile_AAG
            // 
            this.textBoxLoadFromFile_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_AAG.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoadFromFile_AAG.Location = new System.Drawing.Point(3, 23);
            this.textBoxLoadFromFile_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLoadFromFile_AAG.Multiline = true;
            this.textBoxLoadFromFile_AAG.Name = "textBoxLoadFromFile_AAG";
            this.textBoxLoadFromFile_AAG.ReadOnly = true;
            this.textBoxLoadFromFile_AAG.Size = new System.Drawing.Size(501, 387);
            this.textBoxLoadFromFile_AAG.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(507, 215);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 414);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Controls.Add(this.groupBoxResult_AAG);
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_AAG.Location = new System.Drawing.Point(510, 215);
            this.panelRight_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(538, 414);
            this.panelRight_AAG.TabIndex = 4;
            // 
            // groupBoxResult_AAG
            // 
            this.groupBoxResult_AAG.Controls.Add(this.textBoxResult_AAG);
            this.groupBoxResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_AAG.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Name = "groupBoxResult_AAG";
            this.groupBoxResult_AAG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult_AAG.Size = new System.Drawing.Size(538, 414);
            this.groupBoxResult_AAG.TabIndex = 1;
            this.groupBoxResult_AAG.TabStop = false;
            this.groupBoxResult_AAG.Text = "Вывод";
            // 
            // textBoxResult_AAG
            // 
            this.textBoxResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_AAG.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_AAG.Location = new System.Drawing.Point(3, 23);
            this.textBoxResult_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResult_AAG.Multiline = true;
            this.textBoxResult_AAG.Name = "textBoxResult_AAG";
            this.textBoxResult_AAG.ReadOnly = true;
            this.textBoxResult_AAG.Size = new System.Drawing.Size(532, 387);
            this.textBoxResult_AAG.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_AAG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(848, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 106);
            this.panel1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelSeredina_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 8 | Арама А.Г.";
            this.panelTop_AAG.ResumeLayout(false);
            this.panelSeredina_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.ResumeLayout(false);
            this.groupBoxConditions_AAG.PerformLayout();
            this.panelLeft_AAG.ResumeLayout(false);
            this.groupBoxVvodData_AAG.ResumeLayout(false);
            this.groupBoxVvodData_AAG.PerformLayout();
            this.panelRight_AAG.ResumeLayout(false);
            this.groupBoxResult_AAG.ResumeLayout(false);
            this.groupBoxResult_AAG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelSeredina_AAG;
        private System.Windows.Forms.GroupBox groupBoxConditions_AAG;
        private System.Windows.Forms.TextBox textBoxConditions_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.GroupBox groupBoxVvodData_AAG;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.GroupBox groupBoxResult_AAG;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_AAG;
        private System.Windows.Forms.TextBox textBoxResult_AAG;
        private System.Windows.Forms.Button buttonOpenFile_AAG;
        private System.Windows.Forms.Button buttonDone_AAG;
        private System.Windows.Forms.Button buttonHelp_AAG;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAG;
        private System.Windows.Forms.ToolTip toolTipOne_AAG;
        private System.Windows.Forms.Panel panel1;
    }
}

