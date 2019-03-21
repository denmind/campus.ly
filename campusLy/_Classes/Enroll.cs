using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    class Enroll
    {
        private int enroll_id;
        private int course_id;
        private int stud_id;

        private Course course_instance;
        private Student student_instance;

        internal Enroll() {
            course_instance = new Course();
            student_instance = new Student();
        }

        internal Enroll(int course_id_new, int stud_id_new)
        {
            course_id = course_id_new;
            stud_id = stud_id_new;

            course_instance = new Course();
            student_instance = new Student();

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
        internal Student StudID
        {
            get { return student_instance; }
            set { student_instance = value; }
        }

        internal Course CourseInst
        {
            get { return course_instance; }
            set { course_instance = value; }
        }

        internal int StudInst
        {
            get { return stud_id; }
            set { stud_id = value; }
        }

    }
}
