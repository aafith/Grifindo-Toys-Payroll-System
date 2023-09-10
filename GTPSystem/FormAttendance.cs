using GTPSystem.ApplicationClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTPSystem
{
    public partial class FormAttendance : Form
    {
        AttendanceClass attendance = new AttendanceClass();
        EmployeeClass EmployeeObject = new EmployeeClass();
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            attendance.add();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            attendance.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            attendance.delete();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
            EmployeeObject.LoadEmpList(EmployeeListCBox);
            attendance.GridViewName = LoadDb;
            attendance.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            attendance.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            EmployeeListCBox.SelectedValue = LoadDb.Rows[RowIndex].Cells[1].Value.ToString();
            AnnualLeaveBox.Text = LoadDb.Rows[RowIndex].Cells[2].Value.ToString();
            CasualLeaveBox.Text = LoadDb.Rows[RowIndex].Cells[3].Value.ToString();
        }

        private void AnnualLeaveBox_TextChanged(object sender, EventArgs e)
        {
            attendance.Annualleave = AnnualLeaveBox.Text;
        }

        private void CasualLeaveBox_TextChanged(object sender, EventArgs e)
        {
            attendance.Casualleave = CasualLeaveBox.Text;
        }

        private void EmployeeListCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendance.EmployeeId = EmployeeListCBox.SelectedValue;
        }
    }
}
