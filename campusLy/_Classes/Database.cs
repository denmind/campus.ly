using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace campusLy
{
     public class Database
    {
        private string db_server;
        private string db_name;
        private string db_uid;
        private string db_password;

        private MySqlConnection db_conn;

        public Database()
        {
            this.db_server = "localhost";
            this.db_name = "campus.ly";
            this.db_uid = "student_admin";
            this.db_password = "the_lunz_fiv3";
        }

    }

   
}
