using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GTPSystem.ComClass;
using System.Windows.Forms;

namespace GTPSystem.ApplicationClass
{
    internal class AdminClass : DBClass
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }

        public DataGridView GridViewName { get; set; }

        //ADD 
        public void add()
        {
            string sql = "INSERT INTO Admin (Admin_name, Admin_mobilenumber, Admin_address, Admin_username, Admin_password,  Admin_dob) VALUES ('" + Name + "', '" + MobileNumber + "', '" + Address + "', '" + Username + "', '" + Password + "', '" + Dob + "')";
            if(executeQuary(sql, functiontype.add))
            {
                view();
            }
        }

        //UPDATE 
        public void update()
        {
            string sql = "UPDATE Admin SET Admin_name = '" + Name + "', Admin_mobilenumber = '" + MobileNumber + "', Admin_address = '" + Address + "', Admin_username = '" + Username + "', Admin_password = '" + Password + "', Admin_dob = '" + Dob + "' WHERE Admin_id = " + Id;
            if(executeQuary(sql, functiontype.update))
            {
                view();
            }
        }

        //DELETE
        public void delete()
        {
            string sql = "DELETE FROM Admin WHERE Admin_id =" + Id;
            if(executeQuary(sql, functiontype.delete))
            {
                view();
            }
        }

        //VIEW
        public void view()
        {
            string sql = "SELECT * FROM Admin";
            LoadGridView(sql, GridViewName);
        }
    }
}
