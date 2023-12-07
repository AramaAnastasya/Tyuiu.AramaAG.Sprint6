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
using Tyuiu.AramaAG.Sprint6.Task7.V8.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_AAG.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        static string OpenFilePath;
        DataService ds = new DataService();

        private void ClickSave_AAG(object sender, EventArgs e)
        {
            saveFileDialogMatrix_AAG.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_AAG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_AAG.ShowDialog();
            string path = saveFileDialogMatrix_AAG.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if(fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_AAG.RowCount;
            int columns = dataGridViewOutMatrix_AAG.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(j != columns -1 )
                    {
                        str = str + dataGridViewOutMatrix_AAG.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_AAG.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void ClickDone_AAG(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutMatrix_AAG.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            buttonSave_AAG.Enabled = true;
        }
        static int  rows;
        static int columns;
        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            return arrayValues;
        }
        private void ClickOpenFile_AAG(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            OpenFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridViewInMatrix_AAG.ColumnCount = columns;
            dataGridViewInMatrix_AAG.RowCount = rows;
            dataGridViewOutMatrix_AAG.ColumnCount = columns;
            dataGridViewOutMatrix_AAG.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_AAG.Columns[i].Width = 25;
                dataGridViewOutMatrix_AAG.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_AAG.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_AAG.Enabled = true;
        }
        private void ClickHelp_AAG(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void VouseEntesOpen_AAG(object sender, EventArgs e)
        {
            toolTipOne.ToolTipTitle = "Открыть файл";
        }

        private void ClickDoneFile_AAG(object sender, EventArgs e)
        {
            toolTipOne.ToolTipTitle = "Выполнить";

        }

        private void ClickSaveFile_AAG(object sender, EventArgs e)
        {
            toolTipOne.ToolTipTitle = "Созранить в файл";

        }

        private void ClickHelpFile_AAG(object sender, EventArgs e)
        {
            toolTipOne.ToolTipTitle = "Справка";

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_AAG.ColumnCount = 50;
            dataGridViewOutMatrix_AAG.ColumnCount = 50;
            dataGridViewInMatrix_AAG.RowCount = 50;
            dataGridViewOutMatrix_AAG.RowCount = 50;
            for(int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_AAG.Columns[i].Width = 25;
                dataGridViewOutMatrix_AAG.Columns[i].Width = 25;

            }
        }
    }
}
