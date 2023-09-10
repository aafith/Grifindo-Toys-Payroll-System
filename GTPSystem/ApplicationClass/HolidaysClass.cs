using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using GTPSystem.ComClass;

namespace GTPSystem.ApplicationClass
{
    internal class HolidaysClass : DBClass
    {
        public int Id { get; set; }
        public DateTime HolidayMonth { get; set; }
        public String Days { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Holidays (Holiday_month, Days) VALUES ('" + HolidayMonth + "', '" + Days + "')";
            if (executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Holidays SET Holiday_month = '" + HolidayMonth + "', Days = '" + Days + "' WHERE Holidays_id = " + Id;
            if (executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Holidays WHERE Holidays_id =" + Id;
            if (executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Holidays";
            LoadGridView(sql, GridViewName);
        }

        public void LoadEmpList(ComboBox comboBox)
        {
            string sql = "SELECT * FROM Holidays";
            LoadEmpListComboBox(sql, comboBox, "Holidays_id", "Holiday_month");
        }
    }
}
