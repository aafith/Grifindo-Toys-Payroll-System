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
    public partial class FormHolidays : Form
    {
        HolidaysClass holidays = new HolidaysClass();
        public FormHolidays()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            holidays.add();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            holidays.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            holidays.delete();
        }

        private void FormHolidays_Load(object sender, EventArgs e)
        {
            holidays.GridViewName = LoadDb;
            holidays.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            holidays.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            HolidayMonthPicker.Value = Convert.ToDateTime(LoadDb.Rows[RowIndex].Cells[1].Value.ToString());
            DaysBox.Text = LoadDb.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void HolidayMonthPicker_ValueChanged(object sender, EventArgs e)
        {
            holidays.HolidayMonth = HolidayMonthPicker.Value;
        }

        private void DaysBox_TextChanged(object sender, EventArgs e)
        {
            holidays.Days = DaysBox.Text;
        }
    }
}
