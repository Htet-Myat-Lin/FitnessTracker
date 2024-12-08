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

    public partial class DailyActivity : Form
    {
        DataSet1TableAdapters.ActivityTableAdapter Activity = new DataSet1TableAdapters.ActivityTableAdapter();
        DataSet1TableAdapters.DailyActivityRecordDetailTableAdapter DailyDatail = new DataSet1TableAdapters.DailyActivityRecordDetailTableAdapter();
        DataSet1TableAdapters.DailyActivityRecordTableAdapter DailyRecord = new DataSet1TableAdapters.DailyActivityRecordTableAdapter();
        DataSet1TableAdapters.GoalsTableAdapter Goal = new DataSet1TableAdapters.GoalsTableAdapter();
        DataTable dt = new DataTable();
        DataTable dta = new DataTable();
        DataRow datarow;
        public DailyActivity()
        {
            InitializeComponent();
            txtweight.Text = Convert.ToString(Login._weight);
            txtdailyactivityid.Text = AutoID();
            GetTargetCaloreis();
            setActivityName();
            if (txttgtcalories.Text == "")
            {
                btnsave.Enabled = false;
            }
            dta.Columns.Add("ActivityID", typeof(string));
            dta.Columns.Add("ActivityName", typeof(string));
            dta.Columns.Add("MET", typeof(decimal));
            dta.Columns.Add("Metric1", typeof(int));
            dta.Columns.Add("Metric2", typeof(int));
            dta.Columns.Add("Metric3", typeof(int));
            dta.Columns.Add("Calories", typeof(decimal));
        }
        
        private string AutoID()
        {
            DataTable dtTb = new DataTable();
            dtTb = DailyRecord.GetDataBy_DailyActivityID();
            int noOfRow = dtTb.Rows.Count;
            if (noOfRow < 1)
            {
                return "DA-0001";
            }
            else
            {
                string oldID = dtTb.Rows[0][0].ToString();
                int oldnum = Convert.ToInt32(oldID.Substring( 3));
                oldnum++;
                string newID = "DA-" + oldnum.ToString("0000");
                return newID;
            }
        }

        private void setActivityName()//Insert ActivityName from ActivityTableAdapter to ComboBox(cboactivityname)
        {
            dt = Activity.GetData();
            cboactivityname.Items.Add("Choose an exercise");
            cboactivityname.SelectedIndex = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboactivityname.Items.Add(dt.Rows[i][2].ToString());
            }
        }

        private void DailyActivityRecord_Load(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            this.Hide();
            homepage.Show();
        }
        
        private void GetTargetCaloreis()//Insert Targetcalories from GoalsTableAdapter to TextBox(txttgtcalories)
        {
            try
            {
                DataTable dtTargetcalories = new DataTable();
                dtTargetcalories = Goal.GetDataBy_TargetCalories(Login._userid);
                txttgtcalories.Text = dtTargetcalories.Rows[0][3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Set your target calories first", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        private void cboactivityname_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable activityname = new DataTable();
            activityname = Activity.GetDataBy_ActivityName(cboactivityname.SelectedItem.ToString());
            for (int i = 0; i < activityname.Rows.Count; i++)
            {
                txtactivityid.Text = activityname.Rows[i][0].ToString();
                txtMET.Text = activityname.Rows[i][3].ToString();
            }
        }
        public void CalculateTotalCalories()//calculation of total calories burned
        {
            decimal totalCalories = 0;
            foreach (DataGridViewRow row in dgvactivitydetails.Rows)
            {
                decimal calories;
                if (decimal.TryParse(row.Cells["Calories"].Value.ToString(), out calories))
                {
                    totalCalories += calories;
                }
            }
            txtTotalCalories.Text = totalCalories.ToString();
        }
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            string metric1, metric2, metric3;
            metric1 = txtmetric1.Text;
            metric2 = txtmetric2.Text;
            metric3 = txtmetric3.Text;
            if (cboactivityname.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose activity", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric1.Text == "")
            {
                MessageBox.Show("Please enter metric1", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric2.Text == "")
            {
                MessageBox.Show("Please choose metric2", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmetric3.Text == "")
            {
                MessageBox.Show("Please choose metric3", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!metric1.Any(char.IsDigit))
            {
                MessageBox.Show("Metric1 should be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!metric2.Any(char.IsDigit))
            {
                MessageBox.Show("Metric2 should be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!metric3.Any(char.IsDigit))
            {
                MessageBox.Show("Metric3 should be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(metric1) < 0)
            {
                MessageBox.Show("Metric1 should be only positive value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(metric2) < 0)
            {
                MessageBox.Show("Metric2 should be only positive value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(metric3)<1) 
            {
                MessageBox.Show("Duration shouldn't be zero and negative value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectvalue = txtactivityid.Text;
                bool isactivityExit = false;
                foreach (DataGridViewRow name in dgvactivitydetails.Rows)
                {
                    if (name.Cells[0].Value != null && name.Cells[0].Value.ToString().Equals(selectvalue))
                    {
                        isactivityExit = true;
                        break;
                    }
                }
                if (isactivityExit)
                {
                    MessageBox.Show("You can't choose the same activity", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    datarow = dta.NewRow();
                    datarow["ActivityID"] = txtactivityid.Text;
                    datarow["ActivityName"] = cboactivityname.SelectedItem.ToString();
                    datarow["MET"] = Convert.ToDecimal(txtMET.Text);
                    datarow["Metric1"] = Int32.Parse(txtmetric1.Text);
                    datarow["Metric2"] = Int32.Parse(txtmetric2.Text);
                    datarow["Metric3"] = Convert.ToInt32(txtmetric3.Text);
                    //formula of calculating calories burned
                    datarow["Calories"] = (decimal.Parse(txtMET.Text) * decimal.Parse(metric3) * decimal.Parse(txtweight.Text)) / 60;
                   
                    dta.Rows.Add(datarow);
                    dgvactivitydetails.DataSource = dta;

                    CalculateTotalCalories();
                    cboactivityname.SelectedIndex = 0;
                    txtmetric1.Clear();
                    txtMET.Clear();
                    txtmetric3.Clear();
                    txtmetric2.Clear();                    
                }
            }
        }

        private void btnremove_Click(object sender, EventArgs e)//To remove selected row in dataGridView(dgvactivitydetails)
        {
            if (dgvactivitydetails.SelectedRows.Count > 0)
            {
                int rowIndex = dgvactivitydetails.SelectedRows[0].Index;
                dgvactivitydetails.Rows.RemoveAt(rowIndex);
                CalculateTotalCalories();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.","MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvactivitydetails.Rows.Count; i++)
                {
                    string activityID = dgvactivitydetails.Rows[i].Cells[0].Value.ToString();
                    string activityName = dgvactivitydetails.Rows[i].Cells[1].Value.ToString();
                    string METs = dgvactivitydetails.Rows[i].Cells[2].Value.ToString();
                    string metric1 = dgvactivitydetails.Rows[i].Cells[3].Value.ToString();
                    string metric2 = dgvactivitydetails.Rows[i].Cells[4].Value.ToString();
                    string metric3 = dgvactivitydetails.Rows[i].Cells[5].Value.ToString();
                    string calories = dgvactivitydetails.Rows[i].Cells[6].Value.ToString();

                    DailyDatail.Insert(Login._userid, activityID, activityName, Decimal.Parse(METs), metric1, metric2, metric3, Decimal.Parse(calories));

                }
                string Message = null;
                decimal targetcalories = Convert.ToDecimal(txttgtcalories.Text);
                decimal totalcalories = Convert.ToDecimal(txtTotalCalories.Text);
                if (totalcalories >= targetcalories)
                {
                    Message = "Target Completed";
                }
                else
                {
                    Message = "Target did not complete";
                }
                DailyRecord.Insert(Login._userid, txtdailyactivityid.Text, totalcalories, targetcalories, DateTime.Parse(dateTimePicker1.Text), Message);
                MessageBox.Show(Message, "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalCalories.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Add first", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

