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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormAdmin(), LoadingView);
        }

        private void LoadView(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to SignOut ?", "SignOut Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                FormSignIn form = new FormSignIn();
                form.Show();
            }
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormEmployee(), LoadingView);
        }

        private void SalaryRecBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormSalary(), LoadingView);
        }

        private void HolidaysBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormHolidays(), LoadingView);
        }

        private void AttendanceBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormAttendance(), LoadingView);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            LoadView(new FormSettings(), LoadingView);
        }
    }
}
