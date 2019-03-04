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
        private DataBase_Status db_state;

        /*Constructor*/
        public Database()
        {
            db_server = "localhost";
            db_name = "campus.ly";
            db_uid = "student_admin";
            db_password = "the_lunz_fiv3";

            db_conn = null;
            db_state = new DataBase_Status("N/A","None");
        }

        public void start()
        {
            DataBase_Status State = getDb_status();

            try
            {

                //updateConnectionState();

                getDb_status().setMessage(generateDb_info_string());
            }
            catch (Exception ex)
            {
                State.setMessage(ex.Message);
            }


            getDb_status().setState(updateConnectionState());

        }

        internal string updateConnectionState()
        {
            string value = "None";

            switch (getDb_conn().State)
            {
                case ConnectionState.Broken : value = "Broken"; break;
                case ConnectionState.Closed: value = "Closed"; break;
                case ConnectionState.Connecting: value = "Connecting"; break;
                case ConnectionState.Executing: value = "Executing"; break;
                case ConnectionState.Fetching: value = "Fetching"; break;
                case ConnectionState.Open: value = "Open"; break;
            }

            getDb_status().setState(value);
            return value;
        }
        internal string generateDb_info_string()
        {
            return "SERVER=" + db_server + ";DATABASE=" + db_name + ";UID=" + db_uid + ";PASSWORD=" + db_password;
        }
        /*Accessors*/
        internal string getDb_server()
        {
            return db_server;
        }
        internal string getDb_name()
        {
            return db_name;
        }
        internal string getDb_uid()
        {
            return db_uid;
        }
        internal string getDb_password()
        {
            return db_password;
        }
        internal MySqlConnection getDb_conn()
        {
            return db_conn;
        }
        internal DataBase_Status getDb_status()
        {
            return db_state;
        }
        internal void updateDb_status(string status_val)
        {
            getDb_status().setState(status_val);
        }

    }
}
