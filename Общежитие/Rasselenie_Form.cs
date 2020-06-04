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
    public partial class Rasselenie_Form : Form
    {
        public Rasselenie_Form()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.общежитиеDataSet);

        }

        private void Rasselenie_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитиеDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.общежитиеDataSet.rooms);

        }

        private void Confirm_the_changes_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите подтвердить изменения?","Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                roomsBindingSource.EndEdit();
                roomsTableAdapter.Update(общежитиеDataSet);
                studentsTableAdapter.Update(общежитиеDataSet);
            }
        }
    }
}
