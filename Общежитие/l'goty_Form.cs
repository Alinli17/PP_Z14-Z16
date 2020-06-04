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
    public partial class l_goty_Form : Form
    {
        public l_goty_Form()
        {
            InitializeComponent();
        }

        private void l_goty_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet._l_gota". При необходимости она может быть перемещена или удалена.
            this.l_gotaTableAdapter.Fill(this.общежитиеDataSet._l_gota);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            l_gotaTableAdapter.Update(общежитиеDataSet);
        }
    }
}
