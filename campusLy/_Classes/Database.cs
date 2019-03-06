﻿using System;
using System.Data;
using campusLy._Classes;
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
        /*Constructor*/
        internal Database()
        {
            db_server = "localhost";
            db_name = "campus.ly";
            db_uid = "student_admin";
            db_password = "admin_student";

            db_conn = new MySqlConnection(generateDb_info_string());
            db_state = new DataBase_Status("N/A","None");
        }

        /*Core*/
        internal bool start()
        {
            bool value = false;
            try
            {
                if (!ConnectionState.Open.Equals(getDb_conn())) { 
                     db_conn.Open();
                     value = true;
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: getDb_status().setMessage("Cannot connect to server!"); break;
                    case 1045: getDb_status().setMessage("Invalid username/password!"); break;
                    default: getDb_status().setMessage(ex.Message); break;
                }
            }
            return value;
        }
        internal bool end()
        {
            bool value = false;
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
                    default: getDb_status().setMessage(ex.Message); break;
                }
            }
            return value;
        }

        internal string insert(Student student)
        {
            
            /*Query prep*/
            string squery = (student.midInitIsEmpty()) ?

                /*if mid name is empty*/
                "INSERT INTO `student` (`stud_id`, `stud_id_no`, `stud_name_first`, `stud_name_last`, `stud_course`, `stud_course_yr`, `stud_date_of_birth`, `stud_gender`, `date_added`)" +
                "VALUES (NULL, '" + student.getStudIdNo() + "', '" + student.getStudNameFirst() + "', '" + student.getStudNameLast() + "', '" + student.getStudCourse() + "', '" + student.getStudCourseYr() + "', '" + student.getStudDateOfBirth() + "', '" + student.getStudGender() + "', CURRENT_TIMESTAMP)"

                :

                /*if mid name exists*/
                "INSERT INTO `student` (`stud_id`, `stud_id_no`, `stud_name_first`, `stud_name_mi`, `stud_name_last`, `stud_course`, `stud_course_yr`, `stud_date_of_birth`, `stud_gender`, `date_added`)" +
                "VALUES (NULL, '" + student.getStudIdNo() + "', '" + student.getStudNameFirst() + "', '" + student.getStudNameMi() + "', '" + student.getStudNameLast() + "', '" + student.getStudCourse() + "', '" + student.getStudCourseYr() + "', '" + student.getStudDateOfBirth() + "', '" + student.getStudGender() + "', CURRENT_TIMESTAMP)"

                ;

            /*Checks if db_conn is avail*/
            if (start())
            {
                try
                {
                    MySqlCommand scomm = new MySqlCommand(squery, getDb_conn());

                    scomm.ExecuteNonQuery();

                    squery = "Successfully created record!";
                }
                catch(Exception ex)
                {
                    squery = "ERROR: " + ex.Message;
                }
                end();
            }
            else
            {
                squery = "Cannot establish database connection! Check connection or contact admin!";
            }
            return squery;
        }

        /*Accessors*/
        internal void setPassword(string pass_val)
        {
            db_password = pass_val;
        }
        internal void setUsername(string user_val)
        {
            db_uid = user_val;
        }
        internal MySqlConnection getDb_conn()
        {
            return db_conn;
        }
        internal DataBase_Status getDb_status()
        {
            return db_state;
        }

        /*Other*/
        internal string updateConnectionState()
        {
            string value = "None";

            switch (getDb_conn().State)
            {
                case ConnectionState.Open: value = "Open"; break;
                case ConnectionState.Closed: value = "Closed"; break;
                case ConnectionState.Broken: value = "Broken"; break;
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
    }
}
