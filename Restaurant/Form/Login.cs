using Restaurant;
using Restaurant.ManagerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Restaurant
{
    public partial class Login : Form
    {
        MY_DB mydb = new MY_DB();
        public Login()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            managerRadio.Checked = true;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (managerRadio.Checked)
            {
                if (managerLogin())
                {

                    MessageBox.Show("Ok, next time will be go to Manager Main Menu");

                }
                else
                {

                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (employeeLogin())
                {

                    MessageBox.Show("Ok, next time will be go to Employee Main Menu");
                    employeeMainMenu main = new employeeMainMenu();
                    main.Show();
                }
                else
                {

                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool managerLogin()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM manager WHERE username=@username AND password=@password", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernameBox.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordBox.Text;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            mydb.openConnection();

                if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        private bool employeeLogin()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM employee WHERE username=@username AND password=@password", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernameBox.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordBox.Text;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            mydb.openConnection();

                if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

    }
}
