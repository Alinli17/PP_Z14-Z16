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
    public partial class students_Form : Form
    {
        public students_Form()
        {
            InitializeComponent();
        }

        private void students_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитиеDataSet.students);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
