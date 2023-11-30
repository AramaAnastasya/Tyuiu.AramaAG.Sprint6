using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task1.V15.Lib;

namespace Tyuiu.AramaAG.Sprint6.Task1.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_AAG_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService(); 
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep_AAG.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_AAG.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_AAG.Text = "";
                textBoxResult_AAG.AppendText("+---------------------------- +" + Environment.NewLine);
                textBoxResult_AAG.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_AAG.AppendText("+-----------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startstep, func[i]);
                    textBoxResult_AAG.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_AAG.AppendText("+----------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
