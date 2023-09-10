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
    public partial class FormEmployee : Form
    {
        EmployeeClass employee = new EmployeeClass();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            employee.add();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            employee.GridViewName = LoadDb;
            employee.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            employee.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            NameBox.Text = LoadDb.Rows[RowIndex].Cells[1].Value.ToString();
            EmailBox.Text = LoadDb.Rows[RowIndex].Cells[2].Value.ToString();
            MonthlySalaryBox.Text = LoadDb.Rows[RowIndex].Cells[3].Value.ToString();
            OvertimeBox.Text = LoadDb.Rows[RowIndex].Cells[4].Value.ToString();
            AllowancesBox.Text = LoadDb.Rows[RowIndex].Cells[5].Value.ToString();
            JobTitleBox.Text = LoadDb.Rows[RowIndex].Cells[6].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            employee.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            employee.delete();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            employee.Name = NameBox.Text;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            employee.Email = EmailBox.Text;
        }

        private void MonthlySalaryBox_TextChanged(object sender, EventArgs e)
        {
            employee.EmployeeMonthlySalary = MonthlySalaryBox.Text;
        }

        private void OvertimeBox_TextChanged(object sender, EventArgs e)
        {
            employee.OverTimeRateHourly = OvertimeBox.Text;
        }

        private void AllowancesBox_TextChanged(object sender, EventArgs e)
        {
            employee.Allowanceso = AllowancesBox.Text;
        }

        private void JobTitleBox_TextChanged(object sender, EventArgs e)
        {
            employee.JobTitle = JobTitleBox.Text;
        }
    }
}
