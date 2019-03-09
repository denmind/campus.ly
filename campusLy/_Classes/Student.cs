using System;

namespace campusLy._Classes
{
    public sealed class Student
    {
        private const int varCharLength = 32;
        private const int NULL_INT = -1;

        private int stud_id;
        private int stud_id_no;
        private string stud_name_first;
        private string stud_name_mi;
        private string stud_name_last;
        private string stud_course;
        private int stud_course_yr;
        private string stud_date_of_birth;
        private string stud_gender;

        internal Student()
        {

        }
        
        /*YES  MIDDLE NAME*/
        internal Student(int id_no, string name_first, string name_mi, string name_last, string course, int courseyr, string date_of_birth, string gender)
        {
            stud_id = NULL_INT;
            stud_id_no = id_no;
            stud_name_first = name_first;

            stud_name_mi = (name_mi.Length > varCharLength) ? name_mi.Substring(0, varCharLength) : name_mi;

            stud_name_last = name_last;
            stud_course = course;
            stud_course_yr = courseyr;
            stud_date_of_birth = date_of_birth;
            stud_gender = gender;
        }
        
        /*NO  MIDDLE NAME*/
        internal Student(int id_no, string name_first, string name_last, string course, int courseyr, string date_of_birth, string gender)
        {
            stud_id = NULL_INT;
            stud_id_no = id_no;
            stud_name_first = name_first;

            stud_name_mi = "";

            stud_name_last = name_last;
            stud_course = course;
            stud_course_yr = courseyr;
            stud_date_of_birth = date_of_birth;
            stud_gender = gender;
        }
       
        /*Set*/
        internal void setStudCourse(string course)
        {
            stud_course = course;
        }
        internal void setStudCourseYr(int courseyr)
        {
            stud_course_yr = courseyr;
        }
        internal void setStudGender(string gender)
        {
            stud_gender = gender;
        }
        internal void setStudDateOfBirth(string date_of_birth)
        {
            stud_date_of_birth = date_of_birth;
        }
        internal void setStudId(int id)
        {
            stud_id = id;
        }
        internal void setStudIdNo(int id_no)
        {
            stud_id_no = id_no;
        }
        internal void setStudNameFirst(string namefirst)
        {
            stud_name_first = namefirst;
        }
        internal void setStudNameMi(string namemi)
        {
            stud_name_mi = (namemi.Length > varCharLength) ? namemi.Substring(0, varCharLength) : namemi;
        }
        internal void setStudNameLast(string namelast)
        {
            stud_name_last = namelast ;
        }

        /*Get*/
        internal string getStudCourse()
        {
            return stud_course;
        }
        internal string getStudGender()
        {
            return stud_gender;
        }
        internal int getStudCourseYr()
        {
            return stud_course_yr;
        }
        internal string getStudDateOfBirth()
        {
            return stud_date_of_birth;
        }
        internal int getStudId()
        {
            return stud_id;
        }
        internal int getStudIdNo()
        {
            return stud_id_no;
        }
        internal string getStudNameFirst()
        {
            return stud_name_first;
        }
        internal string getStudNameMi()
        {
            return stud_name_mi;
        }
        internal string getStudNameLast()
        {
            return stud_name_last;
        }

        /*Other*/
        internal string getStudName()
        {
            return stud_name_first + stud_name_mi + stud_name_last;
        }
        internal bool midInitIsEmpty()
        {
            return getStudNameMi().Equals("");
        }
    }
}
