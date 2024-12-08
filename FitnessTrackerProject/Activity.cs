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
    public partial class Activity : Form
    {
        DataSet1TableAdapters.ActivityTableAdapter DA = new DataSet1TableAdapters.ActivityTableAdapter();
        DataTable dttemp = new DataTable();
        public static string _activityID;
        public Activity()
        {
            InitializeComponent();
            txtactivityid.Text = AutoID();
            txtuserid.Text = Login._userid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.Show();
        }

        private string AutoID()
        {
            DataTable dtTb = DA.GetDataBy_ActivityID();
            int noOfRow = dtTb.Rows.Count;
            if (noOfRow < 1)
            {
                return "A-0001";
            }
            else
            {
                string oldID = dtTb.Rows[0][0].ToString();
                int oldnum = Convert.ToInt32(oldID.Substring(2));
                oldnum++;
                string newID = "A-" + oldnum.ToString("0000");
                return newID;
            }
        }
        

        private void Clear()
        {
            txtactivityname.Clear();
            txtMETs.Clear();
            txtmetric1.Clear();
            txtmetric2.Clear();
            txtmetric3.Clear();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            MetabolicEquivalents METs = new MetabolicEquivalents();
            METs.getMETs= txtMETs.Text;
            if (txtactivityname.Text == "")
            {
                MessageBox.Show("Enter activity name", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMETs.Text=="")
            {
                MessageBox.Show("Enter METs", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric1.Text == "")
            {
                MessageBox.Show("Enter metric1", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric2.Text == "")
            {
                MessageBox.Show("Enter metric2", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric3.Text == "")
            {
                MessageBox.Show("Enter metric3", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!METs.getMETs.Any(char.IsDigit))
            {
                MessageBox.Show("METs should be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(METs.getMETs) < 0)
            {
                MessageBox.Show("METs should be positive value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DA.Insert(txtactivityid.Text,txtuserid.Text,txtactivityname.Text,Convert.ToDecimal(METs.getMETs),txtmetric1.Text, txtmetric2.Text, txtmetric3.Text);
                MessageBox.Show("Activity regristration complete","MyFitness",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtactivityid.Text=AutoID();
                Clear();
            }
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.Show();
        }
    }
    public class MetabolicEquivalents
    {
        string METs;
        public string getMETs
        {
            get
            {
                return METs;
            }
            set
            {
                METs = value;
            }
        }
    }
}
