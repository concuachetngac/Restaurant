using csFile.EmployeeCs;
using Restaurant.csFile.MainCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace csFile.CalendarCs
{
    class Calendar
    {
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();

        public bool scheduling()
        {
            
            DataTable table = employee.getAllEmployee();

            if(table.Rows.Count != 0) 
            {
                int final = table.Rows.Count;
                if (Global.init > final) {
                    Global.setInit(0);
                    Global.setInitDatabase();
                }
                int init = Global.init;

                int day = 1;
                int shift = 1;
                for (; day <= 7; day++)
                {
                    loop(day, shift, table, init);
                }
            } else
            {
                return false;
            }
            Global.increaseInit();
            Global.setInitDatabase();
            return true;
        }

        public bool removeSchedule()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM calendar", mydb.getConnection);
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public DataTable getCalendar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM calendar", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public void loop(int day, int shift, DataTable table, int init)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO calendar (day, shift, employee_id) VALUES (@day, @shift, @id)", mydb.getConnection);
            for (; shift <= 3; shift++)
            {
                if (init >= table.Rows.Count - 1)
                {
                    init = 1;
                }
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@day", SqlDbType.Int).Value = day;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[init][0]);

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    mydb.closeConnection();
                }
                else
                {
                    mydb.closeConnection();
                }

                init++;
            }
        }
    }
}
