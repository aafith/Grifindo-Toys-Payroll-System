using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using GTPSystem.ComClass;

namespace GTPSystem.ApplicationClass
{
    internal class AttendanceClass : DBClass
    {
        public int Id { get; set; }
        public object EmployeeId { get; set; }
        public string Annualleave { get; set; }
        public string Casualleave { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Attendance (Employee_fk, Annual_leave, Casual_leave) VALUES ('" + EmployeeId + "', '" + Annualleave + "', '" + Casualleave + "')";
            if (executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Attendance SET Employee_fk = '" + EmployeeId + "',Annual_leave = '" + Annualleave + "',Casual_leave = '" + Casualleave + "' WHERE Attendance_id = " + Id;
            if (executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Attendance WHERE Attendance_id =" + Id;
            if (executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Attendance";
            LoadGridView(sql, GridViewName);
        }
    }

}
