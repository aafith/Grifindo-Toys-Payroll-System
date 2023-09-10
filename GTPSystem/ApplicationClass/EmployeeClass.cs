using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using GTPSystem.ComClass;

namespace GTPSystem.ApplicationClass
{
    internal class EmployeeClass : DBClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public String EmployeeMonthlySalary { get; set; }
        public String OverTimeRateHourly { get; set; }
        public String Allowanceso { get; set; }
        public string JobTitle { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Employee (Employee_name, Employee_email, Emp_monthly_salary, Overtime_rates_hourly, Allowances,  Employee_job_title) VALUES ('" + Name + "', '" + Email + "', '" + EmployeeMonthlySalary + "', '" + OverTimeRateHourly + "', '" + Allowanceso + "', '" + JobTitle + "')";
            if (executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Employee SET Employee_name = '" + Name + "',Employee_email = '" + Email + "',Emp_monthly_salary = '" + EmployeeMonthlySalary + "', Overtime_rates_hourly = '" + OverTimeRateHourly + "', Allowances = '" + Allowanceso + "', Employee_job_title = '" + JobTitle + "' WHERE Employee_id = " + Id;
            if (executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Employee WHERE Employee_id =" + Id;
            if (executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Employee";
            LoadGridView(sql, GridViewName);
        }

        public void LoadEmpList(ComboBox comboBox)
        {
            string sql = "SELECT * FROM Employee";
            LoadEmpListComboBox(sql, comboBox , "Employee_id" , "Employee_name");
        }
    }

}
