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
    public partial class UserRegistration : Form
    {
        DataSet1TableAdapters.UserInfomationTableAdapter UserInfo = new DataSet1TableAdapters.UserInfomationTableAdapter();
        DataTable dttemp = new DataTable();
        public UserRegistration()
        {
            InitializeComponent();
            txtuserid.Text = AutoID();
        }
        private string AutoID()
        {
            DataTable dt = new DataTable();
            dt = UserInfo.GetDataBy_UserID();
            int NoOfRow = dt.Rows.Count;

            if (NoOfRow < 1)
            {
                return "U-0001";
            }
            else
            {
                
                string oldID = dt.Rows[0][0].ToString();
                int oldnum = Convert.ToInt32(oldID.Substring(2));
                oldnum++;
                string NewID = "U-" + oldnum.ToString("0000");
                return NewID;
            }
        }
        
        private void SignUpClear()//clear username, password, email, weight after clicking SignUp button
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtweight.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            string username = txtusername.Text;
            string weight = txtweight.Text;
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter Username", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Enter your email", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter password", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtweight.Text == "")
            {
                MessageBox.Show("Enter your weight (kg)", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Length > 20 || password.Length < 12)
            {
                MessageBox.Show("Your password should contain between 8 and 20", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Your password should contain at least one upper letter", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Your password should contain at least one lower letter", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Your password should contain at least one digit", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Any(char.IsUpper))
            {
                MessageBox.Show("Your username should not contain upper letter", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!username.Any(char.IsLower))
            {
                MessageBox.Show("Your username should contain lower letter", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Length < 6)
            {
                MessageBox.Show("Your username should contain at least 6", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!username.Any(char.IsDigit))
            {
                MessageBox.Show("Your username should contain at least one digit", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!weight.Any(char.IsDigit))
            {
                MessageBox.Show("Weight should be only number", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(weight) < 0)
            {
                MessageBox.Show("Weight should be positive value", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rdomale.Checked==false && rdofemale.Checked == false)
            {
                MessageBox.Show("Select gender", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gender = null;
                if (rdomale.Checked == true)
                {
                    gender = "Male";
                }
                else if (rdofemale.Checked == true)
                {
                    gender = "Female";
                }
                UserInfo.Insert(txtuserid.Text, username, txtemail.Text, password, gender, decimal.Parse(weight));
                MessageBox.Show("Registration successful", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtuserid.Text = AutoID();
                SignUpClear();

                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
