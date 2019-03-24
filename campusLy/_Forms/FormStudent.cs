using campusLy._Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campusLy._Forms
{
    public partial class FormStudent : BaseForm
    {
        const int MAX_NO_SIZE = 11;
        const int MAX_STRING_SIZE = 48;

        int inst_id;

        //no argument for create
        //instance for edit
        public FormStudent()
        {
            InitializeComponent();

            this.btn_submit.Click += ADD_btn_submit_Click;
        }
        public FormStudent(Student student)
        {
            InitializeComponent();

            //Stud ID
            inst_id = student.Id;

            this.Text = "EDIT | STUDENT";
            this.btn_submit.Click += EDIT_btn_submit_Click;

            txt_stud_name_first.Text = student.NameFirst + "";
            txt_stud_name_middle.Text = student.NameMiddle + "";
            txt_stud_name_last.Text = student.NameLast + "";
            dtp_stud_date_of_birth.Text = student.DateOfBirth + "";
            txt_stud_id_no.Text = student.IdNo + "";

            if (student.Gender == "Male")
                gbx_stud_gender_male.Checked = true;
            else if (student.Gender == "Female")
                gbx_stud_gender_female.Checked = true;

            switch (student.Course)
            {
                case "BSIT": gbx_stud_course_bs_it.Checked = true; break;
                case "BSCS": gbx_stud_course_bs_cs.Checked = true; break;
                case "BSIS": gbx_stud_course_bs_is.Checked = true; break;
                case "BSLIS": gbx_stud_course_bs_lis.Checked = true; break;
            }

            switch (student.CourseYr)
            {
                case 1: gbx_stud_course_yr_one.Checked = true; break;
                case 2: gbx_stud_course_yr_two.Checked = true; break;
                case 3: gbx_stud_course_yr_three.Checked = true; break;
                case 4: gbx_stud_course_yr_four.Checked = true; break;
                case 5: gbx_stud_course_yr_fifth.Checked = true; break;
            }
        }

        //ADD
        //STUDENT
        private void ADD_btn_submit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            Database DB = new Database();
            Student S;

            /*Get inputs from modules that can directly be converted to string using Text*/
            string stud_name_first = txt_stud_name_first.Text;
            string stud_name_middle_name = txt_stud_name_middle.Text;
            string stud_name_last = txt_stud_name_last.Text;
            string stud_date_of_birt = dtp_stud_date_of_birth.Text;

            int stud_id_no;


            if (txt_stud_id_no.Text.Equals(""))
                stud_id_no = 0;
            else
                stud_id_no = int.Parse(txt_stud_id_no.Text);

            string stud_gender = "";
            string stud_course = "";
            int stud_course_yr = 1;

            /*Gets input from the radio buttons*/

            /*Course*/
            if (gbx_stud_course_bs_cs.Checked)
            {
                stud_course = "BSCS";
            }
            if (gbx_stud_course_bs_it.Checked)
            {
                stud_course = "BSIT";
            }
            if (gbx_stud_course_bs_lis.Checked)
            {
                stud_course = "BSLIS";
            }
            if (gbx_stud_course_bs_is.Checked)
            {
                stud_course = "BSIS";
            }

            /*CourseYr*/
            if (gbx_stud_course_yr_one.Checked)
            {
                stud_course_yr = 1;
            }
            if (gbx_stud_course_yr_two.Checked)
            {
                stud_course_yr = 2;
            }
            if (gbx_stud_course_yr_three.Checked)
            {
                stud_course_yr = 3;
            }
            if (gbx_stud_course_yr_four.Checked)
            {
                stud_course_yr = 4;
            }
            if (gbx_stud_course_yr_fifth.Checked)
            {
                stud_course_yr = 5;
            }

            /*Gender*/
            if (gbx_stud_gender_male.Checked)
            {
                stud_gender = "Male";
            }
            if (gbx_stud_gender_female.Checked)
            {
                stud_gender = "Female";
            }

            /*Student Constructors goes here, first checking if middle name exists or not*/
            if (stud_name_middle_name.Equals(""))
            {
                S = new Student(stud_id_no, stud_name_first, stud_name_last, stud_course, stud_course_yr, stud_date_of_birt, stud_gender);
            }
            else
            {
                S = new Student(stud_id_no, stud_name_first, stud_name_middle_name, stud_name_last, stud_course, stud_course_yr, stud_date_of_birt, stud_gender);
            }

            flag = DB.insert(S);

            this.Close();
            new InfoForm(flag).ShowDialog();
        }
        private void EDIT_btn_submit_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Database DB = new Database();
            Student S;

            /*Get inputs from modules that can directly be converted to string using Text*/
            string stud_name_first = txt_stud_name_first.Text;
            string stud_name_middle_name = txt_stud_name_middle.Text;
            string stud_name_last = txt_stud_name_last.Text;
            string stud_date_of_birt = dtp_stud_date_of_birth.Text;

            int stud_id_no;


            if (txt_stud_id_no.Text.Equals(""))
                stud_id_no = 0;
            else
                stud_id_no = int.Parse(txt_stud_id_no.Text);

            string stud_gender = "";
            string stud_course = "";
            int stud_course_yr = 1;

            /*Gets input from the radio buttons*/

            /*Course*/
            if (gbx_stud_course_bs_cs.Checked)
            {
                stud_course = "BSCS";
            }
            if (gbx_stud_course_bs_it.Checked)
            {
                stud_course = "BSIT";
            }
            if (gbx_stud_course_bs_lis.Checked)
            {
                stud_course = "BSLIS";
            }
            if (gbx_stud_course_bs_is.Checked)
            {
                stud_course = "BSIS";
            }

            /*CourseYr*/
            if (gbx_stud_course_yr_one.Checked)
            {
                stud_course_yr = 1;
            }
            if (gbx_stud_course_yr_two.Checked)
            {
                stud_course_yr = 2;
            }
            if (gbx_stud_course_yr_three.Checked)
            {
                stud_course_yr = 3;
            }
            if (gbx_stud_course_yr_four.Checked)
            {
                stud_course_yr = 4;
            }
            if (gbx_stud_course_yr_fifth.Checked)
            {
                stud_course_yr = 5;
            }

            /*Gender*/
            if (gbx_stud_gender_male.Checked)
            {
                stud_gender = "Male";
            }
            if (gbx_stud_gender_female.Checked)
            {
                stud_gender = "Female";
            }

            /*Student Constructors goes here, first checking if middle name exists or not*/
            if (stud_name_middle_name.Equals(""))
            {
                S = new Student(stud_id_no, stud_name_first, stud_name_last, stud_course, stud_course_yr, stud_date_of_birt, stud_gender);
            }
            else
            {
                S = new Student(stud_id_no, stud_name_first, stud_name_middle_name, stud_name_last, stud_course, stud_course_yr, stud_date_of_birt, stud_gender);
            }
            S.Id = inst_id;

            flag = DB.update(S);
            this.Close();
            new InfoForm(flag).ShowDialog();
        }

        //OTHERS
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

            TextBox txtField = ((TextBox)sender);

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
