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
    public partial class FormCreate : BaseForm
    {
        private int key_id;
        private Student stud_instance;

        public FormCreate()
        {
            InitializeComponent();
        }
        public FormCreate(Student data)
        {
            InitializeComponent();

            label_message.Text = "Edit information below!";
            IdDelete = data.Id;
            //Integers
            txt_stud_id_no.Text = data.IdNo.ToString();

            //Strings + Text
            txt_stud_name_first.Text = data.NameFirst;
            txt_stud_name_middle.Text = data.NameMiddle;
            txt_stud_name_last.Text = data.NameLast;
            dtp_stud_date_of_birth.Text = data.DateOfBirth;


            //Checkboxes
            switch (data.CourseYr)
            {
                case 1: gbx_stud_course_yr_one.Checked = true; break;
                case 2: gbx_stud_course_yr_two.Checked = true; break;
                case 3: gbx_stud_course_yr_three.Checked = true; break;
                case 4: gbx_stud_course_yr_four.Checked = true; break;
                case 5: gbx_stud_course_yr_fifth.Checked = true; break;
            }

            //Course
            if (data.Course.Equals("BSIT"))
                gbx_stud_course_bs_it.Checked = true;
            else if (data.Course.Equals("BSCS"))
                gbx_stud_course_bs_cs.Checked = true;
            else if (data.Course.Equals("BSIS"))
                gbx_stud_course_bs_is.Checked = true;
            else if (data.Course.Equals("BSLIS"))
                gbx_stud_course_bs_lis.Checked = true;

            //Gender
            if (data.Gender.Equals("Male"))
                gbx_stud_gender_male.Checked = true;
            else if (data.Gender.Equals("Female"))
                gbx_stud_gender_female.Checked = true;

            this.btn_submit.Click += new System.EventHandler(this.UPDATE_btn_submit_Click);

        }
        private void UPDATE_btn_submit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            Database DB = new Database();
            Student S = StudInstance;

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

            new Confirm("UPDATE", IdDelete, S.dataGen(),S).ShowDialog();
            this.Close();
        }
        private void btn_submit_Click(object sender, EventArgs e)
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

        internal int IdDelete
        {
            get { return key_id; }
            set { key_id = value; }
        }
        internal Student StudInstance
        {
            get { return stud_instance; }
            set { stud_instance = value; }
        }
    }
}
