using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.Task0.V17.Lib;


namespace Tyuiu.AramaAG.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_AAG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Арама Анастасия Георгиевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_AAG_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                Result_AAG.Text = ds.Calculate(Convert.ToInt32(nameX_AAG.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void buttonResult_AAG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
