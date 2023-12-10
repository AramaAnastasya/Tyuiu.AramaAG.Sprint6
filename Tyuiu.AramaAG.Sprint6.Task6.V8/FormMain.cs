using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task6.V8.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_AAG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAG.ShowDialog();
            openFilePath = openFileDialogTask_AAG.FileName;
            textBoxLoadFromFile_AAG.Text = File.ReadAllText(openFilePath);
            groupBoxVvodData_AAG.Text = groupBoxVvodData_AAG.Text + " " + openFileDialogTask_AAG.FileName;
            buttonDone_AAG.Enabled = true;
        }

        private void buttonDone_AAG_Click(object sender, EventArgs e)
        {
            textBoxResult_AAG.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_AAG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
