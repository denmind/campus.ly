using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    public sealed class Enroll
    {
        private int enroll_id;
        private int course_id;
        private int stud_id;

        internal int CourseID
        {
            get { return course_id; }
            set { course_id = value; }
        }

        internal int StudId
        {
            get { return stud_id; }
            set { stud_id = value; }
        }
    }
}
