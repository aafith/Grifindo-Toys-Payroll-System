using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace GTPSystem.ComClass
{
    enum functiontype
    {

        add,
        update,
        delete,

    }
    internal class DBClass
    {
        private SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost;Initial Catalog=GTSystem;Integrated Security=True");
        public bool executeQuary( string sql, functiontype _funType)
        {
            bool FunctionRunStatus = false;
            string msg = "";
            bool FunctionStatus = false;

            if( _funType == functiontype.add)
            {
                FunctionRunStatus = true;
                msg = "Data Add Successfully";
            }
            else if ( _funType == functiontype.update)
            {
                if (MessageBox.Show("Do You want to update ?", "Update Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FunctionRunStatus = true;
                    msg = "Update Successfully";
                }
            }
            else if( _funType == functiontype.delete)
            {
                if (MessageBox.Show("Do You want to Delete ?", "Delete Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FunctionRunStatus = true;
                    msg = "Delete Successfully";
                }
            }

            if ( FunctionRunStatus)
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                int rowsCount = cmd.ExecuteNonQuery();
                if (rowsCount > 0)
                {
                    MessageBox.Show(msg);
                    FunctionStatus = true;
                }
                else
                {
                    MessageBox.Show("Contact with your System Developer");
                }

                sqlcon.Close();
          
            }

            return FunctionStatus;
        }

        public void LoadGridView( string sql, DataGridView _loadTable)
        { 
            SqlDataAdapter Dataap = new SqlDataAdapter(sql, sqlcon);
            DataTable Datable = new DataTable();
            Dataap.Fill(Datable);
            _loadTable.DataSource = Datable;
        }

        public void LoadEmpListComboBox( string sql , ComboBox comboBox , string idColName , string naemColName)
        {
            SqlDataAdapter Dataap = new SqlDataAdapter(sql, sqlcon);
            DataTable Datable = new DataTable();
            Dataap.Fill(Datable);
            comboBox.DataSource = Datable;
            comboBox.DisplayMember = naemColName;
            comboBox.ValueMember = idColName;
        }

    }
}
