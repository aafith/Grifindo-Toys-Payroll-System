using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GTPSystem.ApplicationClass;

namespace GTPSystem
{
    public partial class FormSalary : Form
    {
        SalaryClass salary = new SalaryClass();
        EmployeeClass EmployeeObject = new EmployeeClass();
        HolidaysClass HolidaysObject = new HolidaysClass();

        private decimal totalSalary;
        private int salaryCycleDateRange;
        private decimal allowances;
        private decimal overtimeRate;
        private decimal governmentTaxRate;

        public FormSalary()
        {
            InitializeComponent();
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            EmployeeObject.LoadEmpList(EmployeeListCBox);
            HolidaysObject.LoadEmpList(HolidayListBox);
            salary.GridViewName = LoadDb;
            salary.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            salary.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            EmployeeListCBox.SelectedValue = LoadDb.Rows[RowIndex].Cells[1].Value.ToString();
            SalaryIssueDateBox.Value = Convert.ToDateTime(LoadDb.Rows[RowIndex].Cells[2].Value.ToString());
            BasePayBox.Text = LoadDb.Rows[RowIndex].Cells[3].Value.ToString();
            GrossPayBox.Text = LoadDb.Rows[RowIndex].Cells[4].Value.ToString();
            NoPayBox.Text = LoadDb.Rows[RowIndex].Cells[5].Value.ToString();
            TotalSalaryBox.Text = LoadDb.Rows[RowIndex].Cells[6].Value.ToString();
            SalaryCycleDateRangeBox.Text = LoadDb.Rows[RowIndex].Cells[7].Value.ToString();
            AbsentBox.Text = LoadDb.Rows[RowIndex].Cells[8].Value.ToString();
            AllowancesBox.Text = LoadDb.Rows[RowIndex].Cells[9].Value.ToString();
            OvertimeRateBox.Text = LoadDb.Rows[RowIndex].Cells[10].Value.ToString();
            GovTexBox.Text = LoadDb.Rows[RowIndex].Cells[11].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            salary.add();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            salary.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            salary.delete();
        }

        private void CulculationBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputValues())
            {
                MessageBox.Show("Invalid input values. Please enter valid numeric values.");
                return;
            }


            int numberOfAbsentDays = GetNumberOfAbsentDays();

            decimal noPayValue = CalculateNoPayValue(numberOfAbsentDays);

            decimal basePayValue = CalculateBasePayValue();

            decimal grossPayValue = CalculateGrossPayValue(noPayValue, basePayValue);


            DisplayResults(noPayValue, basePayValue, grossPayValue);

        }

        private bool ValidateInputValues()
        {
            return decimal.TryParse(TotalSalaryBox.Text, out totalSalary) &&
                   int.TryParse(SalaryCycleDateRangeBox.Text, out salaryCycleDateRange) &&
                   decimal.TryParse(AllowancesBox.Text, out allowances) &&
                   decimal.TryParse(OvertimeRateBox.Text, out overtimeRate) &&
                   decimal.TryParse(GovTexBox.Text, out governmentTaxRate);
        }

        private int GetNumberOfAbsentDays()
        {
            return Convert.ToInt32(AbsentBox.Text);
        }

        private decimal CalculateNoPayValue(int numberOfAbsentDays)
        {
            return (totalSalary / salaryCycleDateRange) * numberOfAbsentDays;
        }

        private decimal CalculateBasePayValue()
        {
            int numberOfOvertimeHours = Convert.ToInt32(OvertimeRateBox.Text);
            return totalSalary + allowances + (overtimeRate * numberOfOvertimeHours);
        }

        private decimal CalculateGrossPayValue(decimal noPayValue, decimal basePayValue)
        {
            return basePayValue - (noPayValue + basePayValue * governmentTaxRate);
        }

        private void DisplayResults(decimal noPayValue, decimal basePayValue, decimal grossPayValue)
        {
            NoPayBox.Text = noPayValue.ToString();
            BasePayBox.Text = basePayValue.ToString();
            GrossPayBox.Text = grossPayValue.ToString();
        }

        private void EmployeeListCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.EmployeeId = EmployeeListCBox.SelectedValue;
        }

        private void SalaryIssueDateBox_ValueChanged(object sender, EventArgs e)
        {
            salary.SalaryIssueDate = SalaryIssueDateBox.Value;
        }

        private void BasePayBox_TextChanged(object sender, EventArgs e)
        {
            salary.BasePayValue = BasePayBox.Text;
        }

        private void GrossPayBox_TextChanged(object sender, EventArgs e)
        {
            salary.GrossPayValue = GrossPayBox.Text;
        }

        private void NoPayBox_TextChanged(object sender, EventArgs e)
        {
            salary.NoPayValue = NoPayBox.Text;
        }

        private void TotalSalaryBox_TextChanged(object sender, EventArgs e)
        {
            salary.TotalSalary = TotalSalaryBox.Text;
        }

        private void SalaryCycleDateRangeBox_TextChanged(object sender, EventArgs e)
        {
            salary.SalaryCycleDateRange = SalaryCycleDateRangeBox.Text;
        }

        private void AbsentBox_TextChanged(object sender, EventArgs e)
        {
            salary.Absent = AbsentBox.Text;
        }

        private void HolidayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.HolidaysId = HolidayListBox.SelectedValue;
        }

        private void AllowancesBox_TextChanged(object sender, EventArgs e)
        {
            salary.Allowances = AllowancesBox.Text;
        }

        private void OvertimeRateBox_TextChanged(object sender, EventArgs e)
        {
            salary.OvertimeRate = OvertimeRateBox.Text;
        }

        private void GovTexBox_TextChanged(object sender, EventArgs e)
        {
            salary.GovernmentTaxRate = GovTexBox.Text;
        }
    }
}
