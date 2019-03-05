using System.Data;
using MySql.Data.MySqlClient;

namespace campusLy
{
     public sealed class Database
    {
        private string db_server;
        private string db_name;
        private string db_uid;
        private string db_password;

        private MySqlConnection db_conn;
        private DataBase_Status db_state;

        private static Database instance;

        /*Constructor*/
        internal Database()
        {
            db_server = "localhost";
            db_name = "campus.ly";
            db_uid = "student_admin";
            db_password = "admin_student";

            instance = this;

            db_conn = new MySqlConnection(generateDb_info_string());
            db_state = new DataBase_Status("N/A","None");
        }

        internal bool start()
        {
            bool value;
            try
            {
                db_conn.Open();
                value = true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: getDb_status().setMessage("Cannot connect to server!"); break;
                    case 1045: getDb_status().setMessage("Invalid username/password!"); break;
                    default: getDb_status().setMessage(ex.Message); break;
                }
                value = false;
            }
            return value;
        }

        internal bool end()
        {
            bool value;
            try
            {
                db_conn.Close();
                value = true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: getDb_status().setMessage("Cannot connect to server!"); break;
                    case 1045: getDb_status().setMessage("Invalid username/password!"); break;
                    default: getDb_status().setMessage(ex.Message); break;
                }
                value = false;
            }
            return value;
        }

        internal string updateConnectionState()
        {
            string value = "None";

            switch (getDb_conn().State)
            {
                case ConnectionState.Open: value = "Open"; break;
                case ConnectionState.Closed: value = "Closed"; break;
                case ConnectionState.Broken : value = "Broken"; break;
                case ConnectionState.Connecting: value = "Connecting"; break;
                case ConnectionState.Executing: value = "Executing"; break;
                case ConnectionState.Fetching: value = "Fetching"; break;
            }

            getDb_status().setState(value);
            return value;
        }
        internal string generateDb_info_string()
        {
            return "SERVER=" + db_server + ";DATABASE=" + db_name + ";UID=" + db_uid + ";PASSWORD=" + db_password;
        }
        /*Accessors*/
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();

            }
            return instance;
        }
        internal MySqlConnection getDb_conn()
        {
            return db_conn;
        }
        internal DataBase_Status getDb_status()
        {
            return db_state;
        }
        internal void setPassword(string pass_val)
        {
            db_password = pass_val;
        }
        internal void setUsername(string user_val)
        {
            db_uid = user_val;
        }
       

    }
}
