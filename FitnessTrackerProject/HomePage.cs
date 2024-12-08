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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            lbldisplayname.Text = Login._username;
        }
        
        private void btnsetgoal_Click(object sender, EventArgs e)
        {
            SetGoal goal = new SetGoal();
            this.Hide();
            goal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailyActivity dailyactivity = new DailyActivity();
            this.Hide();
            dailyactivity.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            this.Hide();
            record.Show();
        }
    }
}
