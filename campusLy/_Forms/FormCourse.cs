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
    public partial class FormCourse : campusLy._Forms.BaseForm
    {
        const int MAX_NO_SIZE = 11;
        const int MAX_STRING_SIZE = 64;

        Course instance;
        public FormCourse(bool value)
        {
            InitializeComponent();

            if (value)
            {
                this.Text = "CREATE | COURSE";
                this.btn_submit.Click += new System.EventHandler(this.ADD_btn_submit_Click);
            }
        }
        public FormCourse(bool value, Course course)
        {
            InitializeComponent();

            if (value == false)
            {
                instance = course;

                this.Text = "EDIT | COURSE";

            }
        }

        private void ADD_btn_submit_Click(object sender, EventArgs e)
        {
            Course C = new Course();
            Database DB = new Database();

            string ccode = "";

            //Course Type
            if (gbx_course_bs_cs.Checked)
            {
                ccode += "CS ";
                C.CourseType = "BSCS";
            }
            else if (gbx_course_bs_is.Checked)
            {
                ccode += "IS ";
                C.CourseType = "BSIS";
            }
            else if (gbx_course_bs_it.Checked)
            {
                ccode += "IT ";
                C.CourseType = "BSIT";
            }
            else if (gbx_course_bs_lis.Checked)
            {
                ccode += "LIS ";
                C.CourseType = "BSLIS";
            }

            ccode += txt_course_code.Text;

            //Course Code
            C.CourseCode = ccode;

            //Course Title
            C.CourseTitle = txt_course_title.Text;
            
            new InfoForm(DB.insert(C)).ShowDialog();
        }

        //VALIDATORS
        private void txt_field_ValidDigitOnly(object sender, EventArgs e)
        {
            string input, clean;
            clean = "";
            input = "";

            TextBox txtId = ((TextBox)sender);

            //CUT INPUT IF GREATER THAN MAX_NO_SIZE
            if (txtId.Text.Length > MAX_NO_SIZE)
                input = txtId.Text.Substring(0, MAX_NO_SIZE);
            else
                input = txtId.Text;

            foreach (char c in input)
            {
                if (char.IsDigit(c) == true)
                    clean += c + "";
            }

            txtId.Text = clean;
        }
        private void txt_field_ValidCharOnly(object sender, EventArgs e)
        {
            string input, clean;
            clean = "";
            input = "";

            RichTextBox txtField = ((RichTextBox)sender);

            //CUT INPUT IF GREATER THAN MAX_NO_SIZE
            if (txtField.Text.Length > MAX_STRING_SIZE)
                input = txtField.Text.Substring(0, MAX_STRING_SIZE);
            else
                input = txtField.Text;

            foreach (char c in input)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                    clean += c + "";
            }

            txtField.Text = clean;
        }
    }
}
