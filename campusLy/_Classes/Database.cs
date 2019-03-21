﻿using System;
using System.Collections.Generic;
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
        /*Constructor*/
        internal Database()
        {
            db_server = "localhost";
            db_name = "campus.ly";
            db_uid = "student_admin";
            db_password = "admin_student";

            db_conn = new MySqlConnection(generateDb_info_string());
        }

        /*Core*/
        internal bool start()
        {
            bool value = false;
            try
            {
                switch (Database_Connection.State)
                {
                    case ConnectionState.Closed: db_conn.Open(); value = true; break;
                }
            }
            catch (MySqlException ex) { }
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
            catch (MySqlException ex) { }
            return value;
        }

        /*STUDENT*/
        internal bool insert(Student student)
        {
            bool value = true;
            /*Query prep*/
            string squery = (student.midInitIsEmpty()) ?

                /*if mid name is empty*/
                "INSERT INTO `student` (`stud_id`, `stud_id_no`, `stud_name_first`, `stud_name_last`, `stud_course`, `stud_course_yr`, `stud_date_of_birth`, `stud_gender`, `date_added`)" +
                "VALUES (NULL, '" + student.IdNo + "', '" + student.NameFirst + "', '" + student.NameLast + "', '" + student.Course + "', '" + student.CourseYr + "', '" + student.DateOfBirth + "', '" + student.Gender + "', CURRENT_TIMESTAMP)"

                :

                /*if mid name exists*/
                "INSERT INTO `student` (`stud_id`, `stud_id_no`, `stud_name_first`, `stud_name_mi`, `stud_name_last`, `stud_course`, `stud_course_yr`, `stud_date_of_birth`, `stud_gender`, `date_added`)" +
                "VALUES (NULL, '" + student.IdNo + "', '" + student.NameFirst + "', '" + student.NameMiddle + "', '" + student.NameLast + "', '" + student.Course + "', '" + student.CourseYr + "', '" + student.DateOfBirth + "', '" + student.Gender + "', CURRENT_TIMESTAMP)"

                ;

            /*Checks if db_conn is avail*/
            if (start())
            {
                try
                {
                    MySqlCommand scomm = new MySqlCommand(squery, Database_Connection);
                    scomm.ExecuteNonQuery();
                }
                catch (Exception ex) { value = false; }
                end();
            }
            else { value = false; }

            return value;
        }

        internal List<Student> selectAllStud()
        {
            /*Query*/
            string squery = "SELECT * FROM student";

            /*Storage*/
            List<Student> student_data = new List<Student>();

            if (start())
            {
                MySqlCommand scmd = new MySqlCommand(squery, Database_Connection);
                MySqlDataReader sqlDataReader = scmd.ExecuteReader();
                DateTime res_date_added;
                DateTime res_date_of_birth;

                /*read data*/
                while (sqlDataReader.Read())
                {
                    Student stud_data = new Student();

                    stud_data.Id = int.Parse(sqlDataReader["stud_id"] + "");
                    stud_data.IdNo = int.Parse(sqlDataReader["stud_id_no"] + "");
                    stud_data.CourseYr = int.Parse(sqlDataReader["stud_course_yr"] + "");

                    stud_data.NameFirst = sqlDataReader["stud_name_first"] + "";
                    stud_data.NameMiddle = sqlDataReader["stud_name_mi"] + "";
                    stud_data.NameLast = sqlDataReader["stud_name_last"] + "";
                    stud_data.Course = sqlDataReader["stud_course"] + "";
                    stud_data.Gender = sqlDataReader["stud_gender"] + "";

                    res_date_added = DateTime.Parse(sqlDataReader["date_added"] + "");
                    res_date_of_birth = DateTime.Parse(sqlDataReader["stud_date_of_birth"] + "");

                    stud_data.DateAdded = res_date_added.ToString("yyyy-MM-dd HH:mm:ss");
                    stud_data.DateOfBirth = res_date_of_birth.ToString("yyy-MM-dd");

                    student_data.Add(stud_data);
                }
            }
            return student_data;
        }
        internal List<Student> searchAll(string srch_term)
        {
            List<Student> search_result = new List<Student>();

            string squery = "SELECT * FROM student " +
                            "WHERE stud_id_no LIKE '%" + srch_term + "%' OR " +
                            "stud_name_first LIKE '%" + srch_term + "%' OR " +
                            "stud_name_mi LIKE '%" + srch_term + "%' OR " +
                            "stud_name_last LIKE '%" + srch_term + "%' OR " +
                            "stud_date_of_birth LIKE '%" + srch_term + "%' OR " +
                            "date_added LIKE '%" + srch_term + "%' ";


            if (start())
            {
                MySqlCommand scmd = new MySqlCommand(squery, Database_Connection);
                MySqlDataReader sqlDataReader = scmd.ExecuteReader();
                DateTime res_date_added;
                DateTime res_date_of_birth;

                /*read data*/
                while (sqlDataReader.Read())
                {
                    Student stud_data = new Student();

                    stud_data.Id = int.Parse(sqlDataReader["stud_id"] + "");
                    stud_data.IdNo = int.Parse(sqlDataReader["stud_id_no"] + "");
                    stud_data.CourseYr = int.Parse(sqlDataReader["stud_course_yr"] + "");

                    stud_data.NameFirst = sqlDataReader["stud_name_first"] + "";
                    stud_data.NameMiddle = sqlDataReader["stud_name_mi"] + "";
                    stud_data.NameLast = sqlDataReader["stud_name_last"] + "";
                    stud_data.Course = sqlDataReader["stud_course"] + "";
                    stud_data.Gender = sqlDataReader["stud_gender"] + "";

                    res_date_added = DateTime.Parse(sqlDataReader["date_added"] + "");
                    res_date_of_birth = DateTime.Parse(sqlDataReader["stud_date_of_birth"] + "");

                    stud_data.DateAdded = res_date_added.ToString("yyyy-MM-dd HH:mm:ss");
                    stud_data.DateOfBirth = res_date_of_birth.ToString("yyy-MM-dd");

                    search_result.Add(stud_data);
                }

            }
            return search_result;
        }
        internal bool delete(int idrops)
        {
            bool value = false;

            string squery = "";

            if (idrops > 0)
            {
                squery += "DELETE FROM student WHERE stud_id =" + idrops;

                if (start())
                {
                    try
                    {
                        MySqlCommand scomm = new MySqlCommand(squery, Database_Connection);
                        scomm.ExecuteNonQuery();
                        value = true;
                    }
                    catch (Exception ex) { value = false; }
                    end();
                }
                else { value = false; }
            }

            return value;
        }

        /*COURSE*/
        internal bool insert(Course course)
        {
            bool value = true;
            /*Query prep*/
            string squery = "INSERT INTO course (course_id, course_code, course_title) VALUES (NULL, '"+course.CourseCode +"', '"+ course.CourseTitle+"')";

            /*Checks if db_conn is avail*/
            if (start())
            {
                try
                {
                    MySqlCommand scomm = new MySqlCommand(squery, Database_Connection);
                    scomm.ExecuteNonQuery();
                }
                catch (Exception ex) { value = false; }
                end();
            }
            else { value = false; }

            return value;
        }
        internal List<Course> selectAllCourse()
        {
            /*Query*/
            string squery = "SELECT * FROM course";

            /*Storage*/
            List<Course> course_data = new List<Course>();

            if (start())
            {
                MySqlCommand scmd = new MySqlCommand(squery, Database_Connection);
                MySqlDataReader sqlDataReader = scmd.ExecuteReader();

                /*read data*/
                while (sqlDataReader.Read())
                {
                    Course course_data_hold = new Course();

                    course_data_hold.CourseId = int.Parse(sqlDataReader["course_id"] + "");
                    course_data_hold.CourseCode = sqlDataReader["course_code"] + "";
                    course_data_hold.CourseTitle = sqlDataReader["course_title"] + "";

                    course_data.Add(course_data_hold);
                }
            }
            return course_data;
        }

        /*ENROLL*/
        internal bool insert(Enroll enroll)
        {
            bool value = true;
            /*Query prep*/
            string squery = "INSERT INTO enroll (enroll_id, course_id, stud_id) VALUES (NULL, '"+enroll.CourseID+"', '"+enroll.StudID+"')";

            /*Checks if db_conn is avail*/
            if (start())
            {
                try
                {
                    MySqlCommand scomm = new MySqlCommand(squery, Database_Connection);
                    scomm.ExecuteNonQuery();
                }
                catch (Exception ex) { value = false; }
                end();
            }
            else { value = false; }

            return value;
        }
       
        /*Accessors*/
        internal string Database_Username
        {
            get { return db_uid; }
            set { db_uid = value; }
        }
        internal string Database_Password
        {
            get { return db_password; }
            set { db_password = value; }
        }

        internal MySqlConnection Database_Connection
        {
            get { return db_conn; }
        }
        internal string generateDb_info_string()
        {
            return "SERVER=" + db_server + ";DATABASE=" + db_name + ";UID=" + db_uid + ";PASSWORD=" + db_password;
        }

        /*OTHERS*/
        internal List<int> getSortedStudID()
        {
            /*Query*/
            string squery = "SELECT stud_id FROM student ORDER BY date_added ASC";

            /*Storage*/
            List<int> id_data = new List<int>();

            if (start())
            {
                MySqlCommand scmd = new MySqlCommand(squery, Database_Connection);
                MySqlDataReader sqlDataReader = scmd.ExecuteReader();

                /*read data*/
                while (sqlDataReader.Read())
                {
                    id_data.Add(int.Parse(sqlDataReader["stud_id"] + ""));
                }
            }
            return id_data;
        }
        internal bool cleanStudID(List<int> id_data)
        {
            bool value = false;
            return value;
        }
    }
}
