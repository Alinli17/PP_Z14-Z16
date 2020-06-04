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
    public partial class rooms_Form : Form
    {
        public rooms_Form()
        {
            InitializeComponent();
        }

        private void rooms_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитиеDataSet.rooms);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
