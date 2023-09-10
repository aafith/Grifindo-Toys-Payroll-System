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
    public partial class FormAdmin : Form
    {
        AdminClass admin = new AdminClass();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            admin.add();
           
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            admin.GridViewName = LoadDb;
            admin.view();
        }

        private void LoadDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            admin.Id = Convert.ToInt32(LoadDb.Rows[RowIndex].Cells[0].Value.ToString());
            nameBox.Text = LoadDb.Rows[RowIndex].Cells[1].Value.ToString();
            mobileBox.Text = LoadDb.Rows[RowIndex].Cells[2].Value.ToString();
            addressBox.Text = LoadDb.Rows[RowIndex].Cells[3].Value.ToString();
            usernameBox.Text = LoadDb.Rows[RowIndex].Cells[4].Value.ToString();
            passwordBox.Text = LoadDb.Rows[RowIndex].Cells[5].Value.ToString();
            dobBox.Value = Convert.ToDateTime(LoadDb.Rows[RowIndex].Cells[6].Value.ToString());
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            admin.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            admin.delete();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            admin.Name = nameBox.Text;
        }

        private void MobileBox_TextChanged(object sender, EventArgs e)
        {
            admin.MobileNumber = mobileBox.Text;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            admin.Address = addressBox.Text;
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            admin.Username = usernameBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            admin.Password = passwordBox.Text;
        }

        private void DobBox_ValueChanged(object sender, EventArgs e)
        {
            admin.Dob = dobBox.Value;
        }
    }   
}
