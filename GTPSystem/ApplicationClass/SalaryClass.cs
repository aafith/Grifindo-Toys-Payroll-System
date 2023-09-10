using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GTPSystem.ComClass;
using System.Windows.Forms;

namespace GTPSystem.ApplicationClass
{
    internal class SalaryClass : DBClass
    {
        public int Id { get; set; }
        public object EmployeeId { get; set; }
        public DateTime SalaryIssueDate { get; set; }
        public string BasePayValue { get; set; }
        public string GrossPayValue { get; set; }
        public string NoPayValue { get; set; }
        public string TotalSalary { get; set; }
        public string SalaryCycleDateRange { get; set; }
        public string Absent { get; set; }
        public object HolidaysId { get; set; }
        public string Allowances { get; set; }
        public string OvertimeRate { get; set; }

        public string GovernmentTaxRate { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Salary (Employee_fk, Salary_issue_date, Base_pay_value, Gross_pay_value, No_pay_value, Total_Salary, Salary_Cycle_Date_Range, Absent, Holidays_fk, Allowances, Overtime_Rate, Government_Tax_Rate) VALUES ('" + EmployeeId + "', '" + SalaryIssueDate + "', '" + BasePayValue + "', '" + GrossPayValue + "' , '" + NoPayValue + "' , '" + TotalSalary + "' , '" + SalaryCycleDateRange + "' , '" + Absent + "' , '" + HolidaysId + "', '" + Allowances + "', '" + OvertimeRate + "', '" + GovernmentTaxRate+"')";
            if (executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Salary SET Employee_fk = '" + EmployeeId + "', Salary_issue_date = '" + SalaryIssueDate + "', Base_pay_value = '" + BasePayValue + "', Gross_pay_value = '" + GrossPayValue + "' , No_pay_value = '" + NoPayValue + "' , Total_Salary = '" + TotalSalary + "' , Salary_Cycle_Date_Range = '" + SalaryCycleDateRange + "' , Absent = '" + Absent + "' , Holidays_fk = '" + HolidaysId + "' , Allowances = '" + Allowances + "' , Overtime_Rate = '" + OvertimeRate + "', Government_Tax_Rate = '" + GovernmentTaxRate +"'  WHERE Salary_id = " + Id;
            if (executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Salary WHERE Salary_id =" + Id;
            if (executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Salary";
            LoadGridView(sql, GridViewName);
        }
    }
}
