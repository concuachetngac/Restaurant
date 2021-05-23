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
    public partial class employeeMainMenu : Form
    {
        MY_DB mydb = new MY_DB();
        public employeeMainMenu()
        {
            InitializeComponent();
        }

        private void employeeMainMenu_Load(object sender, EventArgs e)
        {
            getEmployeeImgAndUsername(Global.StaffID);
        }

        public void getEmployeeImgAndUsername(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, picture FROM employee WHERE id = @id", mydb.getConnection);
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

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
