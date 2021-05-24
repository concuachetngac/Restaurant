using csFile.CalendarCs;
using csFile.EmployeeCs;
using Restaurant.csFile.MainCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Restaurant
{
    public partial class ManagerMainMenu : Form
    {
        MY_DB mydb = new MY_DB();
        public ManagerMainMenu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();
            add.Show();
        }

        private void removeStaffButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            try
            {
                if (employee.removeEmployee(Convert.ToInt32(staffIDBox.Text)))
                {
                    MessageBox.Show("Staff Removed");
                }
            } catch
            {
                MessageBox.Show("Please input ID again !!!");
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerMainMenu_Load(object sender, EventArgs e)
        {
            getManagerImgAndUsername(Global.ManagerID);
        }

        public void getManagerImgAndUsername(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, picture FROM manager WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            byte[] pic;
            pic = (byte[])table.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            imgPanel.BackgroundImage = Image.FromStream(picture);
            imgPanel.BackgroundImageLayout = ImageLayout.Stretch;
            welcomeLabel.Text += "(" + table.Rows[0][0] + ")";
        }

        private void showStaffButton_Click(object sender, EventArgs e)
        {
            ShowFullStaff show = new ShowFullStaff();
            show.Show();
        }

        private void newCalendarButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.removeSchedule();
            if(calendar.scheduling())
            {
                MessageBox.Show("New Schedule successful");
            } else
            {
                MessageBox.Show("Error");
            }
        }

        private void editStaffButton_Click(object sender, EventArgs e)
        {
            EditStaff edit = new EditStaff();
            edit.Show();
        }

        private void showCalendarButton_Click(object sender, EventArgs e)
        {
            ShowCalendar show = new ShowCalendar();
            show.Show();
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            ChangeManagerPassword change = new ChangeManagerPassword();
            change.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditManager edit = new EditManager();
            edit.Show();
        }
    }
}
