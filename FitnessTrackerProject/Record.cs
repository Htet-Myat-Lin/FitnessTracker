using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackerProject
{
    public partial class Record : Form
    {
        DataSet1TableAdapters.DailyActivityRecordTableAdapter DailyActivityRecord = new DataSet1TableAdapters.DailyActivityRecordTableAdapter();
        public Record()
        {
            InitializeComponent();
            
        }

        private void Record_Load(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dtDate = new DataTable();
            dtDate = DailyActivityRecord.SearchDataBy_Date(dateTimePicker1.Text, Login._userid);
            dataGridView1.DataSource = dtDate;
            dataGridView1.Refresh();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            DataTable dtShowall = new DataTable();
            dtShowall = DailyActivityRecord.ShowAllData(Login._userid);
            dataGridView1.DataSource = dtShowall;
            dataGridView1.Refresh();
        }
    }
}
