using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using campusLy._Classes;

namespace campusLy._Forms
{
    public partial class FormEnroll : campusLy._Forms.BaseForm
    {
        const int MAX_NO_SIZE = 11;
        const int MAX_STRING_SIZE = 64;

        Student e_stud;
        Course e_course;

        public FormEnroll()
        {
            InitializeComponent();

            this.btn_submit.Click += ADD_btn_submit_Click;
        }

        private void ADD_btn_submit_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            Enroll E = new Enroll
            {
                StudId = e_stud.Id,
                CourseID = e_course.CourseId
            };

            this.Close();
            new InfoForm(DB.insert(E)).ShowDialog();
        }
        private void FormEnroll_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_list = DB.selectStud_Sorted_IdNoAsc();

            foreach(Student stud in stud_list)
            {
                cmbox_student.Items.Add(stud.IdNo + "");
            }
        }

        private void cmbox_student_ValueChanged(object sender, EventArgs e)
        {
            //Rest
            cmbox_courses.Text = "";
            cmbox_courses.Items.Clear();
            lbl_course_count.ForeColor = System.Drawing.Color.Black;

            Database DB = new Database();

            //TAKE STUDENT
            e_stud = DB.selectStudViaIdNo(Int32.Parse(cmbox_student.Text));

            //Set Student Info
            txt_enrollee_course_yr.Text = e_stud.Course + " - " + e_stud.CourseYr;
            txt_enrollee_name.Text = e_stud.NameLast + ", " + e_stud.NameFirst + " "+ e_stud.NameMiddle[0] + ".";

            //Refresh Courses via Stud Course
            List<Course> course_list = DB.selectCourseViaCourseType(e_stud.Course);


            //If the course of student has offerings, show list else disable related form controls
            if (course_list.Count > 0)
            {
                string course_code;

                cmbox_courses.Enabled = true;
                //Put info regarding number of courses avail for enrollment
                lbl_course_count.Text = course_list.Count + " courses avail!";

                //Add courses to combobox
                foreach (Course course in course_list)
                {
                    course_code = "";
                    //Extract numbers from course code e.g IT 1101 into 1101
                    foreach(char c in course.CourseCode)
                    {
                        if (char.IsDigit(c))
                        {
                            course_code += c;
                        }
                    }
                    cmbox_courses.Items.Add(course_code);
                }
            }
            else
            {
                lbl_course_count.ForeColor = System.Drawing.Color.Red;
                lbl_course_count.Text = "NO COURSES OFFERED!";
                cmbox_courses.Items.Clear();

                btn_submit.Enabled = false;
                cmbox_courses.Enabled = false;
            }
        }

        private void cmbox_courses_ValueChanged(object sender, EventArgs e)
        {
            Database DB = new Database();

            //TAKE COURSE
            e_course = DB.selectCourseViaCourseCodeAndType(cmbox_courses.Text, e_stud.Course);

            txt_course_title.Text = e_course.CourseTitle + "";

            btn_submit.Enabled = true;
        }
    }
}
