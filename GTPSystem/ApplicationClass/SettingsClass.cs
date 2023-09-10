using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GTPSystem.ComClass;
using System.Windows.Forms;

namespace GTPSystem.ApplicationClass
{
    internal class SettingsClass : DBClass
    {
        public int Id { get; set; }
        public string DateRange { get; set; }
        public DateTime SalaryCBDate { get; set; }
        public DateTime SalaryCEDate { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Settings (Date_range, Salary_cycle_begin_date, Salary_cycle_end_date) VALUES ('" + DateRange + "', '" + SalaryCBDate + "', '" + SalaryCEDate + "')";
            if (executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Settings SET Date_range = '" + DateRange + "', Salary_cycle_begin_date = '" + SalaryCBDate + "', Salary_cycle_end_date = '" + SalaryCEDate + "' WHERE Settings_id = " + Id;
            if (executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Settings WHERE Settings_id =" + Id;
            if (executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Settings";
            LoadGridView(sql, GridViewName);
        }
    }
}
