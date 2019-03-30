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
    public partial class FormUnenroll : campusLy._Forms.BaseForm
    {
        Student e_stud;
        Course e_course;

        Enroll E;

        public FormUnenroll()
        {
            InitializeComponent();
        }

        private void FormUnenroll_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_list = DB.selectStud_Sorted_IdNoAsc();

            foreach (Student stud in stud_list)
            {
                cmbox_student.Items.Add(stud.IdNo + "");
            }

            E = new Enroll();
            e_stud = new Student();
            e_course = new Course();
        }

        private void cmbox_student_ValueChanged(object sender, EventArgs e)
        {
            //RESET
            dataGridView_Course.Rows.Clear();
            lbl_course_count.Text = "";
            lbl_course_count.ForeColor = Color.Black;

            Database DB = new Database();

            //TAKE STUDENT
            e_stud = DB.selectStudViaIdNo(Int32.Parse(cmbox_student.Text));

            //Set Student Info
            txt_enrollee_course_yr.Text = e_stud.Course + " - " + e_stud.CourseYr;
            txt_enrollee_name.Text = e_stud.NameLast + ", " + e_stud.NameFirst + " " + e_stud.NameMiddle[0] + ".";

            //Get courses of student
            List<Course> e_stud_courses = DB.selectEnrolledCoursesOfStudent(e_stud);

            //Refresh courses
            displayOnDataGridView(e_stud_courses);

        }
        private void displayOnDataGridView(List<Course> course_list)
        {
            if (course_list.Count > 0)
            {
                int count = 0;
                dataGridView_Course.Enabled = true;

                foreach (Course C in course_list)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView_Course.Rows[0].Clone();

                    //reserver identifier
                    row.Cells[0].Value = C.CourseId;
                    row.Cells[1].Value = C.CourseCode;
                    row.Cells[2].Value = C.CourseTitle;

                    dataGridView_Course.Rows.Add(row);
                    count++;
                }
                lbl_course_count.Text = count + "";
            }
            else
            {
                lbl_course_count.Text = "NONE";
                lbl_course_count.ForeColor = System.Drawing.Color.Red;
                dataGridView_Course.Enabled = false;
            }
        }
        private void dataGridView_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int rowsize = 3;

            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_Course.Rows[indx].Cells;

            string data = "";

            for (int i = 1; i < rowsize; i++)
                data += i + ". " + hold[i].Value + "\n";

            E.StudId = e_stud.Id;
            E.CourseID = int.Parse(hold[0].Value+"");

            new Confirm(data, E).ShowDialog();
            this.Refresh();
        }
    }
}
