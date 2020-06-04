using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rooms_Form form2 = new rooms_Form();
            form2.Text = "Комнаты";
            form2.ShowDialog();
        }

        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_goty_Form form3 = new l_goty_Form();
            form3.Text = "Льготы";
            form3.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students_Form form4 = new students_Form();
            form4.Text = "Студенты";
            form4.ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rasselenie_Form form5 = new Rasselenie_Form();
            form5.Text = "Расселение";
            form5.ShowDialog();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapros_Form form6 = new Zapros_Form();
            form6.Text = "Запросы";
            form6.ShowDialog();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Form form7 = new Otchet_Form();
            form7.Text = "Отчет";
            form7.ShowDialog();
        }
    }
}
