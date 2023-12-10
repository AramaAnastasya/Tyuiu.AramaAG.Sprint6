
namespace Tyuiu.AramaAG.Sprint6.Task6.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_AAG = new System.Windows.Forms.Label();
            this.buttonOK_AAG = new System.Windows.Forms.Button();
            this.pictureBoxOne_AAG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_AAG
            // 
            this.labelInfo_AAG.AutoSize = true;
            this.labelInfo_AAG.Location = new System.Drawing.Point(104, 18);
            this.labelInfo_AAG.Name = "labelInfo_AAG";
            this.labelInfo_AAG.Size = new System.Drawing.Size(413, 180);
            this.labelInfo_AAG.TabIndex = 1;
            this.labelInfo_AAG.Text = resources.GetString("labelInfo_AAG.Text");
            // 
            // buttonOK_AAG
            // 
            this.buttonOK_AAG.Location = new System.Drawing.Point(404, 227);
            this.buttonOK_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK_AAG.Name = "buttonOK_AAG";
            this.buttonOK_AAG.Size = new System.Drawing.Size(99, 39);
            this.buttonOK_AAG.TabIndex = 2;
            this.buttonOK_AAG.Text = "Ок";
            this.buttonOK_AAG.UseVisualStyleBackColor = true;
            this.buttonOK_AAG.Click += new System.EventHandler(this.CLoseClick_AAG);
            // 
            // pictureBoxOne_AAG
            // 
            this.pictureBoxOne_AAG.Image = global::Tyuiu.AramaAG.Sprint6.Task6.V8.Properties.Resources.user_female;
            this.pictureBoxOne_AAG.Location = new System.Drawing.Point(12, 77);
            this.pictureBoxOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxOne_AAG.Name = "pictureBoxOne_AAG";
            this.pictureBoxOne_AAG.Size = new System.Drawing.Size(86, 99);
            this.pictureBoxOne_AAG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne_AAG.TabIndex = 0;
            this.pictureBoxOne_AAG.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.buttonOK_AAG);
            this.Controls.Add(this.labelInfo_AAG);
            this.Controls.Add(this.pictureBoxOne_AAG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_AAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOne_AAG;
        private System.Windows.Forms.Label labelInfo_AAG;
        private System.Windows.Forms.Button buttonOK_AAG;
    }
}