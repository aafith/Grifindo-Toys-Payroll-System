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
    public partial class FormSettings : Form
    {
        SettingsClass settings = new SettingsClass();
        public FormSettings()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            settings.add();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            settings.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            settings.delete();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            settings.GridViewName = LoadDb;
            settings.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            settings.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            date_range_box.Text = LoadDb.Rows[RowIndex].Cells[1].Value.ToString();
            salary_cb_date_box.Value = Convert.ToDateTime(LoadDb.Rows[RowIndex].Cells[2].Value.ToString());
            salary_ce_date_box.Value = Convert.ToDateTime(LoadDb.Rows[RowIndex].Cells[3].Value.ToString());
        }

        private void DateRangeBox_TextChanged(object sender, EventArgs e)
        {
            settings.DateRange = date_range_box.Text;
        }

        private void SalaryCBDateBox_ValueChanged(object sender, EventArgs e)
        {
            settings.SalaryCBDate = salary_cb_date_box.Value;
        }

        private void SalaryCEDateBox_ValueChanged(object sender, EventArgs e)
        {
            settings.SalaryCEDate = salary_ce_date_box.Value;
        }
    }

}
