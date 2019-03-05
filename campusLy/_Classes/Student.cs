using System;

namespace campusLy._Classes
{
    public sealed class Student
    {
        private const int varCharSize = 32;
        private const int NULL_INT = -1;

        internal  enum Gender {
            Male,Female
        };
        internal  enum Course {
            BSIT, BSCS, BSIS, BSLIS
        };
        internal enum CourseYr : int{
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4,
            Fifth = 5
        };

        private int stud_id;
        private int stud_id_no;
        private string stud_name_first;
        private string stud_name_mi;
        private string stud_name_last;
        private Course stud_course;
        private CourseYr stud_course_yr;
        private string stud_date_of_birth;
        private Gender stud_gender;

        private string date_added;

        internal Student()
        {
            stud_id = NULL_INT;
            stud_id_no = NULL_INT;
            stud_name_first = "";
            stud_name_mi = "";
            stud_name_last = "";

            stud_course_yr = CourseYr.First;

            date_added = DateTime.Now.ToString();
        }
        internal Student(int id, int id_no, string name_first, string name_mi, string name_last, Course course, CourseYr courseyr, string date_of_birth, Gender gender)
        {
            stud_id = id;
            stud_id_no = id_no;
            stud_name_first = name_first;
            stud_name_mi = name_mi;
            stud_name_last = name_last;
            stud_course = course;
            stud_course_yr = courseyr;
            stud_date_of_birth = date_of_birth;
            stud_gender = gender;

            date_added = DateTime.Now.ToString();
        }
        internal Student(int id, int id_no, string name_first, string name_last, Course course, CourseYr courseyr, string date_of_birth, Gender gender)
        {
            stud_id = id;
            stud_id_no = id_no;
            stud_name_first = name_first;
            stud_name_mi = "";
            stud_name_last = name_last;
            stud_course = course;
            stud_course_yr = courseyr;
            stud_date_of_birth = date_of_birth;
            stud_gender = gender;

            date_added = DateTime.Now.ToString();
        }
        internal string studGender_ToString()
        {
            string value = "";
            switch (getStudGender()){
                case Gender.Female: value = "Female"; break;
                case Gender.Male: value = "Male"; break;
            }
            return value;
        }
        internal string studCourse_ToString()
        {
            string value = "";
            switch (getStudCourse()){
                case Course.BSIT: value = "BSIT"; break;
                case Course.BSLIS: value = "BSLIS"; break;
                case Course.BSIS: value = "BSIS"; break;
                case Course.BSCS: value = "BSCS"; break;
            }
            return value;
        }
        internal Course getStudCourse()
        {
            return stud_course;
        }
        internal Gender getStudGender()
        {
            return stud_gender;
        }
        internal bool finalizeData()
        {
            bool value;
            try
            {

                value = true;
            }catch(Exception ex)
            {
                value = false;
            }

            return value;
        }

        /*make accessors for all attributes*/

    }
}
