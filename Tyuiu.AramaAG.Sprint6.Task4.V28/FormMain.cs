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
using Tyuiu.AramaAG.Sprint6.Task4.V28.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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

                //this.chartFunction_AAG.Titles.Add("График функции");
                this.chartFunction_AAG.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAG.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_AAG.Text = "";
                chartFunction_AAG.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                   

                    this.chartFunction_AAG.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_AAG.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Task4 выполнил студент группы СМАРТб,-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveClick_AAG(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V28.txt";
                File.WriteAllText(path, textBoxResult_AAG.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n открыть его в блокноте?", "Сообщение",  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxNamedOne_AAG_Enter(object sender, EventArgs e)
        {

        }

        private void chartFunction_AAG_Click(object sender, EventArgs e)
        {

        }
    }
}
