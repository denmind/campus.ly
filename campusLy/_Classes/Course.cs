using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    public sealed class Course
    {
        private int course_id;
        private string course_code;
        private string course_title;
        private string course_type;

        internal Course()
        {
            course_id = 0;
            course_code = "";
            course_title = "";
            course_type = "";
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
        internal string CourseType
        {
            get { return course_type; }
            set { course_type = value; }
        }
    }
}
