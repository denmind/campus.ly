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

        internal Enroll() {}

        internal Enroll(int course_id_new, int stud_id_new)
        {
            course_id = course_id_new;
            stud_id = stud_id_new;
        }

        internal int EnrollID
        {
            get { return enroll_id; }
            set { enroll_id = value; }
        }
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
