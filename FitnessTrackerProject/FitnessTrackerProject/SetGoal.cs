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
    
    public partial class SetGoal : Form
    {
        DataSet1TableAdapters.GoalsTableAdapter Goal = new DataSet1TableAdapters.GoalsTableAdapter();
        DataTable dtTb = new DataTable();
        public SetGoal()
        {
            InitializeComponent();
            txtgoalid.Text = AutoID();
            txtuserid.Text = Login._userid;
        }
        private string AutoID()
        {
            DataTable dtTb = Goal.GetDataBy_GoalID();
            int noOfRow = dtTb.Rows.Count;
            if (noOfRow < 1)
            {
                return "G-0001";
            }
            else
            {
                string oldID = dtTb.Rows[0][0].ToString();
                int oldnum = Convert.ToInt32(oldID.Substring(2));
                oldnum++;
                string newID = "G-" + oldnum.ToString("0000");
                return newID;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            GoalCalories calories = new GoalCalories();
            calories.getTargetCalories = txttgtcalories.Text;

            if (txtgoaldescription.Text == "")
            {
                MessageBox.Show("Enter goal description", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttgtcalories.Text == "")
            {
                MessageBox.Show("Enter target calories", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!calories.getTargetCalories.Any(char.IsDigit))
            {
                MessageBox.Show("Target calores shoule be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(calories.getTargetCalories) < 0)
            {
                MessageBox.Show("Calories should be positive value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Goal.Insert(txtgoalid.Text, txtuserid.Text, txtgoaldescription.Text, Decimal.Parse(calories.getTargetCalories), DateTime.Parse(dateTimePicker1.Text));
                MessageBox.Show("Your goal successfully saved", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txttgtcalories.Clear();
                txtgoaldescription.Clear();
            }
        }

        private void SetGoal_Load(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }

        
    }
    public class GoalCalories
    {
        string targetcalories;
        public string getTargetCalories
        {
            set
            {
                targetcalories = value;
            }
            get
            {
                return targetcalories;
            }
        }
    }
}
