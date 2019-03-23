﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using campusLy._Classes;

namespace campusLy._Forms
{
    public partial class FormStudentView : BaseForm
    {
        public FormStudentView(string optype,string header_message)
        {
            InitializeComponent();
            this.Text = optype + " | STUDENT";
            lbl_form_view_title.Text += header_message;

            if (optype.Equals("VIEW"))
                this.dataGridView_view.CellDoubleClick += this.VIEW_CellClick;
            else if (optype.Equals("UPDATE"))
                this.dataGridView_view.CellDoubleClick += this.UPDATE_CellClick;
            else if (optype.Equals("DELETE"))
                this.dataGridView_view.CellDoubleClick += this.DELETE_CellClick;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_data = new List<Student>();

            stud_data = DB.selectStud();

            displayOnDataGridView(stud_data);

        }
        private void SEARCH_Focus(object sender, EventArgs e)
        {
            this.srch_box.Text = "";
        }
        private void SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_view.Visible.Equals(false))
            {
                dataGridView_view.Visible = true;
            }

            dataGridView_view.Rows.Clear();

            Database DB = new Database();

            string search_term = srch_box.Text;

            List<Student> stud_data = new List<Student>();

            stud_data = DB.searchStudent(search_term);

            displayOnDataGridView(stud_data);
        }

        private void VIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a message box (modal) is displayed and within the control form
            //a copy button to clipboard is made available


            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";

            Database DB = new Database();
            
            string[] dataGen = new string[10];
            Student student = new Student();
            FileGen fileGen = new FileGen();

            for (int i = 1; i < 10; i++)
            {
               data += hold[i].Value + " ";
                dataGen[i - 1] = hold[i].Value + "";
            }

            student.Id = Int32.Parse(hold[0].Value + "");
            student.IdNo = Int32.Parse(dataGen[0] + "");
            student.NameLast = dataGen[1];
            student.NameMiddle = dataGen[2];
            student.NameFirst = dataGen[3];
            student.Course = dataGen[4];
            student.CourseYr = Int32.Parse(dataGen[5] + "");
            student.DateOfBirth = dataGen[6];
            student.Gender = dataGen[7];

            fileGen.StudData = student;
            fileGen.StudCourses = DB.selectCourseStud(student);
            fileGen.ProduceFile();

            new MessageForm(data,fileGen).ShowDialog();
        }
        private void UPDATE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a new FormStudent is created, two methods are then executed
            //1. DROP the selected identifier 2. CREATE a new record from the form using same create method in FormStudent

            Database DB = new Database();

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            Student S = new Student();

            S.Id = (int)hold[0].Value;
            S.IdNo = (int)hold[1].Value;
            S.NameFirst = (string)hold[4].Value;
            S.NameMiddle = (string)hold[3].Value;
            S.NameLast = (string)hold[2].Value;
            S.Course = (string)hold[5].Value;
            S.CourseYr = (int)hold[6].Value;
            S.DateOfBirth = (string)hold[7].Value;
            S.Gender = (string)hold[8].Value;
            S.DateAdded = (string)hold[9].Value;
            
            new FormStudent(false, S).ShowDialog();
        }
        private void DELETE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";

            for (int i = 1; i < 10; i++)
            {
                data += i + ". " + hold[i].Value + "\n";
            }

            indx = Int32.Parse(hold[0].Value + "");

            new Confirm("DELETE", indx, data).ShowDialog();
        }
        private void displayOnDataGridView(List<Student> stud_data)
        {
            if (stud_data.Count > 0)
            {
                richText_title.Visible = false;

                foreach (Student S in stud_data)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView_view.Rows[0].Clone();

                    //reserver identifier
                    row.Cells[0].Value = S.Id;
                    row.Cells[1].Value = S.IdNo;
                    row.Cells[2].Value = S.NameLast;
                    row.Cells[3].Value = S.NameMiddle;
                    row.Cells[4].Value = S.NameFirst;
                    row.Cells[5].Value = S.Course;
                    row.Cells[6].Value = S.CourseYr;
                    row.Cells[7].Value = S.DateOfBirth;
                    row.Cells[8].Value = S.Gender;
                    row.Cells[9].Value = S.DateAdded;

                    dataGridView_view.Rows.Add(row);
                }
            }
            else
            {
                dataGridView_view.Visible = false;
                richText_title.Visible = true;
                richText_title.ReadOnly = true;
            }
        }

    }
}
