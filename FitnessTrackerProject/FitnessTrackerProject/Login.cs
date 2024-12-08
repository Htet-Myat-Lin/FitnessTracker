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
    public partial class Login : Form
    {
        DataSet1TableAdapters.UserInfomationTableAdapter UserInfo = new DataSet1TableAdapters.UserInfomationTableAdapter();
        public static string _username, _userid;
        public static decimal _weight;
        
        public Login()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration signup = new UserRegistration();
            this.Hide();
            signup.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboshowpassword.Checked == false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter username", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter password", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dtlogin = new DataTable();
                dtlogin = UserInfo.UserLogIn(txtusername.Text,txtpassword.Text);
                if (dtlogin.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfull", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvuserinfomation.DataSource = dtlogin;
                    _username = dgvuserinfomation[1, 0].Value.ToString();
                    _weight = Convert.ToDecimal(dgvuserinfomation[5, 0].Value);
                    _userid = dgvuserinfomation[0, 0].Value.ToString();
                    HomePage homepage = new HomePage();
                    this.Hide();
                    homepage.Show();
                }
                else
                {
                     MessageBox.Show("Incorrect username or password", "MyFitness", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
