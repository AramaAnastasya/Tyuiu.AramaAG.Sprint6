using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task2.V13.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxNaamedOne_AAG_TextChanged(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();


        private void buttonDone_AAG_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_AAG.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_AAG.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_AAG.Titles.Add("График функции");
                this.chartFunction_AAG.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAG.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_AAG.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_AAG.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Halp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы СМАРТб,-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_AAG_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AAG.BackColor = Color.Red;
        }

        private void buttonDone_AAG_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AAG.BackColor = Color.DarkGreen;
        }

        private void buttonDone_AAG_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AAG.BackColor = Color.Blue;
        }
    }
}
