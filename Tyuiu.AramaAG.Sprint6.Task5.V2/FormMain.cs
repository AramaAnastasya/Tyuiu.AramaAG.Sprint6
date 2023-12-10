using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task5.V2.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V2.txt";

        private void DoneClick_AAG(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_AAG.ColumnCount = 2;
                dataGridViewResult_AAG.Columns[0].Width = 20;
                dataGridViewResult_AAG.Columns[1].Width = 50;

                this.chartResult_AAG.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_AAG.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_AAG.Series[0].Points.Clear();
                dataGridViewResult_AAG.Rows.Clear();
                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_AAG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartResult_AAG.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Help_AAGClick(object sender, EventArgs e)
        {
            MessageBox.Show("Task5 выполнил студент группы СМАРТб,-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFileClick_AAG(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartResult_AAG_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
