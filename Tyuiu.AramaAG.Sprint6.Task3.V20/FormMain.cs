using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task3.V20.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -14,17, -19, 3, 2 },
                                         { -4, -14, -19, -9, -1},
                                         { 1, 0, 13, 14, 8},
                                         { 13, 7, 8,-3,-15 },
                                         { 2,-20, 12, -14, 4} };


        private void buttonDoneClick_AAG(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            dataGridViewResult_AAG.ColumnCount = columns;
            dataGridViewResult_AAG.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_AAG.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_AAG.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }

        private void buttonHelpCLick_AAG(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_AAG_CLick(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridSimple_AAG.ColumnCount = columns;
            dataGridSimple_AAG.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridSimple_AAG.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridSimple_AAG.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
            
        }
    }
}
