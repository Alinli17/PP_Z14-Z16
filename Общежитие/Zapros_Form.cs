using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Общежитие
{
    public partial class Zapros_Form : Form
    {
        public Zapros_Form()
        {
            InitializeComponent();
        }

        private void Run_Request_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:/Users/Алина/Desktop/ПП/Студенческое_общежитие/Общежитие.accdb");
            sqlconn.Open();
            string s = "";
            if (Full_Information.Checked) { s = "SELECT * FROM Students"; }
            if (Short_Information.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            if (List_of_groups.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            if (Number_of_rooms.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
            if (Students_List.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
            OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource= dt;
            sqlconn.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for(int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
        }
    }
}
