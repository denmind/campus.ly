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
    public partial class FormCourseView : BaseForm
    {
        public FormCourseView(string optype, string header_message)
        {
            InitializeComponent();
            this.Text = optype + " | COURSE";
            lbl_form_view_title.Text += header_message;

            if (optype.Equals("VIEW"))
                this.dataGridView_Course.CellDoubleClick += this.VIEW_CellClick;
            else if (optype.Equals("UPDATE"))
                this.dataGridView_Course.CellDoubleClick += this.UPDATE_CellClick;
            else if (optype.Equals("DELETE"))
                this.dataGridView_Course.CellDoubleClick += this.DELETE_CellClick;
        }

        private void FormCourseView_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Course> courses = DB.selectCourse();

            displayOnDataGridView(courses);

        }
        private void displayOnDataGridView(List<Course> course_list)
        {
            if (course_list.Count > 0)
            {
                richText_title.Visible = false;

                foreach (Course C in course_list)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView_Course.Rows[0].Clone();

                    //reserver identifier
                    row.Cells[0].Value = C.CourseId;
                    row.Cells[1].Value = C.CourseCode;
                    row.Cells[2].Value = C.CourseTitle;
                    row.Cells[3].Value = C.CourseType;

                    dataGridView_Course.Rows.Add(row);
                }
            }
            else
            {
                dataGridView_Course.Visible = false;
                richText_title.Visible = true;
                richText_title.ReadOnly = true;
            }
        }
        private void VIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_Course.Rows[indx].Cells;

            Database DB = new Database();

            Course C = new Course
            {
                CourseId = (int)hold[0].Value,
                CourseCode = hold[1].Value + "",
                CourseTitle = hold[2].Value + "",
                CourseType = hold[3].Value + ""
            };

            new XMLPicker("course", C).ShowDialog();
        }
        private void UPDATE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Database DB = new Database();

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_Course.Rows[indx].Cells;

            Course C = new Course
            {
                CourseId = (int)hold[0].Value,
                CourseCode = hold[1].Value + "",
                CourseTitle = hold[2].Value + "",
                CourseType = hold[3].Value + ""
            };

            this.Close();
            new FormCourse(C).ShowDialog();
        }
        private void DELETE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int rowsize = 4;

            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_Course.Rows[indx].Cells;

            string data = "";

            for (int i = 1; i < rowsize; i++)
                data += i + ". " + hold[i].Value + "\n";

            indx = Int32.Parse(hold[0].Value + "");

            this.Close();
            new Confirm("COURSE", indx, data).ShowDialog();
        }
        private void SEARCH_Focus(object sender, EventArgs e)
        {
            this.srch_box.Text = "";
        }
        private void SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_Course.Visible.Equals(false))
            {
                dataGridView_Course.Visible = true;
            }

            dataGridView_Course.Rows.Clear();

            Database DB = new Database();

            string search_term = srch_box.Text;

            List<Course> course_list = new List<Course>();

            course_list = DB.searchCourse(search_term);

            displayOnDataGridView(course_list);
        }
    }
}
