using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    class Course
    {
        private int course_id;
        private string course_code;
        private string course_title;

        internal Course() { }

        internal Course(string course_code_new, string course_title_new)
        {
            course_code = course_code_new;
            course_title = course_title_new;
        }

        internal int CourseId{
            get{ return course_id; }
            set { course_id = value; }
        }
        internal string CourseCode
        {
            get { return course_code; }
            set { course_code = value; }
        }
        internal string CourseTitle
        {
            get { return course_title; }
            set { course_title = value; }
        }
    }
}
