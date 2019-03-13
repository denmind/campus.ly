using System;

namespace campusLy._Classes
{
    public sealed class Student
    {
        private const int varCharLength = 32;

        private int stud_id;
        private int stud_id_no;
        private string stud_name_first;
        private string stud_name_mi;
        private string stud_name_last;
        private string stud_course;
        private int stud_course_yr;
        private string stud_date_of_birth;
        private string stud_gender;
        private string date_added;

        internal Student(){}
        
        /*YES  MIDDLE NAME*/
        internal Student(int id_no, string name_first, string name_mi, string name_last, string course, int courseyr, string date_of_birth, string gender)
        {
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
        internal string Course
        {
            get{ return stud_course; }
            set{ stud_course = value; }
        }
        internal int CourseYr
        {
            get { return stud_course_yr; }
            set { stud_course_yr = value; }
        }
        internal string Gender
        {
            get { return stud_gender; }
            set { stud_gender = value; }
        }
        internal string DateOfBirth
        {
            get { return stud_date_of_birth; }
            set { stud_date_of_birth = value; }
        }
        internal int Id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
        internal int IdNo
        {
            get { return stud_id_no; }
            set { stud_id_no = value; }
        }
        internal string NameFirst
        {
            get { return stud_name_first; }
            set { stud_name_first = value; }
        }
        internal string NameMiddle
        {
            get { return stud_name_mi; }
            set {
                stud_name_mi = (value.Length > varCharLength) ? value.Substring(0, varCharLength) : value;
            }
        }
        internal string NameLast
        {
            get { return stud_name_last; }
            set { stud_name_last = value; }
        }
        internal string DateAdded
        {
            get { return date_added; }
            set { date_added = value; }
        }

        /*Other*/
        internal bool midInitIsEmpty()
        {
            return NameMiddle.Equals("");
        }
        internal string dataGen()
        {
            string data = "";

            data += 1 + ". " + Id + "\n";
            data += 2 + ". " + IdNo + "\n";
            data += 3 + ". " + NameFirst + "\n";
            data += 4 + ". " + NameMiddle + "\n";
            data += 5 + ". " + NameLast + "\n";
            data += 6 + ". " + Course + "\n";
            data += 7 + ". " + CourseYr + "\n";
            data += 8 + ". " + DateOfBirth + "\n";
            data += 9 + ". " + Gender + "\n";
            data += 10 + ". " + DateAdded + "\n";

            return data;
        }
    }
}
