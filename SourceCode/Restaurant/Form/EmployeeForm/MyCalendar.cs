using csFile.CalendarCs;
using csFile.EmployeeCs;
using Restaurant.csFile.MainCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MyCalendar : Form
    {
        public MyCalendar()
        {
            InitializeComponent();
        }

        private void MyShift_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Calendar calendar = new Calendar();

            DataTable table = employee.getShift(Global.StaffID);

            DataTable tableCloned = table.Clone();
            tableCloned.Columns[0].DataType = typeof(string);
            foreach (DataRow row in table.Rows)
            {
                tableCloned.ImportRow(row);
            }

            for (int i = 0; i <tableCloned.Rows.Count; i++)
            {
                tableCloned.Rows[i][0] = calendar.convertToDay(Convert.ToInt32(table.Rows[i][0]));
            }


            myShiftView.DataSource = tableCloned;
            myShiftView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            myShiftView.Columns[0].HeaderText = "Day";
            myShiftView.Columns[1].HeaderText = "Shift";

        }
    }
}
