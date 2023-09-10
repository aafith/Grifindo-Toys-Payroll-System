using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace GTPSystem
{
    public partial class FormSignIn : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost;Initial Catalog=GTSystem;Integrated Security=True");
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string Adminusername, Admin_password;

            Adminusername = UsernameBox.Text;
            Admin_password = PasswordBox.Text;

            try
            {
                string sql = "SELECT * FROM Admin WHERE Admin_username = '"+ UsernameBox.Text +"' AND  Admin_password = '"+ PasswordBox.Text +"'";
                SqlDataAdapter Dataap = new SqlDataAdapter(sql, sqlcon);
                DataTable Datable = new DataTable();
                Dataap.Fill(Datable);

                if (Datable.Rows.Count > 0)
                {
                    Adminusername = UsernameBox.Text;
                    Admin_password = PasswordBox.Text;

                    this.Hide();
                    FormMain form = new FormMain();
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsernameBox.Clear();
                    PasswordBox.Clear();

                    //FOCUS USERNAME
                    UsernameBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Incorrect username or password.");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
