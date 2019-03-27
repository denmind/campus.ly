using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using campusLy._Forms;
using campusLy._Classes;


namespace campusLy
{
    public partial class MainForm : BaseForm
    {
        string[] btn_msg =
        {
            "Create record data",
            "Update record info",
            "View record list",
            "Delete some records"
        };

        string[] form_type =
        {
            "Double click cell to EDIT RECORD!",
            "Double click cell to GENERATE RECORD FILE!",
            "Double click cell to DELETE RECORD immediately!"
        };

        string[] form_op =
        {
            "UPDATE", "VIEW" , "DELETE"
        };

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));

        public MainForm(string type)
        {
            InitializeComponent();
            this.Text += type;

            if(type == "STUDENT")
            {
                this.button_form_1_Create.Click += new System.EventHandler(this.STUDENT_1_CREATE);
                this.button_form_2_Update.Click += new System.EventHandler(this.STUDENT_2_UPDATE);
                this.button_form_3_View.Click += new System.EventHandler(this.STUDENT_3_VIEW);
                this.button_form_4_Delete.Click += new System.EventHandler(this.STUDENT_4_DELETE);
            }else if(type == "COURSE")
            {
                this.button_form_1_Create.Click += new System.EventHandler(this.COURSE_1_CREATE);
                this.button_form_2_Update.Click += new System.EventHandler(this.COURSE_2_UPDATE);
                this.button_form_3_View.Click += new System.EventHandler(this.COURSE_3_VIEW);
                this.button_form_4_Delete.Click += new System.EventHandler(this.COURSE_4_DELETE);
            }
            else if(type == "ENROLL")
            {
                this.button_form_1_Create.Click += new System.EventHandler(this.ENROLL_1_CREATE);
                this.button_form_2_Update.Click += new System.EventHandler(this.ENROLL_2_UPDATE);
                this.button_form_3_View.Click += new System.EventHandler(this.ENROLL_3_VIEW);
                this.button_form_4_Delete.Click += new System.EventHandler(this.ENROLL_4_DELETE);
            }
        }

        //STUDENT
        /*1. CREATE*/
        private void STUDENT_1_CREATE(object sender, EventArgs e)
        {
            //TRUE FOR CREATE
            //FALSE FOR EDIT
            new FormStudent().ShowDialog();
        }
        /*2. UPDATE*/
        private void STUDENT_2_UPDATE(object sender, EventArgs e)
        {
            new FormStudentView(form_op[0], form_type[0]).ShowDialog();
        }
        /*3. VIEW*/
        private void STUDENT_3_VIEW(object sender, EventArgs e)
        {
            new FormStudentView(form_op[1], form_type[1]).ShowDialog();
        }
        /*4. DELETE*/
        private void STUDENT_4_DELETE(object sender, EventArgs e)
        {
            new FormStudentView(form_op[2], form_type[2]).ShowDialog();
        }

        //COURSE
        /*1. CREATE*/
        private void COURSE_1_CREATE(object sender, EventArgs e)
        {
            //TRUE FOR CREATE
            //FALSE FOR EDIT
            new FormCourse().ShowDialog();
        }
        /*2. UPDATE*/
        private void COURSE_2_UPDATE(object sender, EventArgs e)
        {
            new FormCourseView(form_op[0], form_type[0]).ShowDialog();
        }
        /*3. VIEW*/
        private void COURSE_3_VIEW(object sender, EventArgs e)
        {
            new FormCourseView(form_op[1], form_type[1]).ShowDialog();
        }
        /*4. DELETE*/
        private void COURSE_4_DELETE(object sender, EventArgs e)
        {
            new FormCourseView(form_op[2], form_type[2]).ShowDialog();
        }

        //ENROLL
        /*1. CREATE*/
        private void ENROLL_1_CREATE(object sender, EventArgs e)
        {
            //TRUE FOR CREATE
            //FALSE FOR EDIT

            new FormEnroll().ShowDialog();
        }
        /*2. UPDATE*/
        private void ENROLL_2_UPDATE(object sender, EventArgs e)
        {
        }
        /*3. VIEW*/
        private void ENROLL_3_VIEW(object sender, EventArgs e)
        {
        }
        /*4. DELETE*/
        private void ENROLL_4_DELETE(object sender, EventArgs e)
        {
        }


        //HOVER AND LEAVE
        private void button_form_2_Update_OnHover(object sender, EventArgs e)
        {
            button_form_2_Update.Text = btn_msg[1];
            this.button_form_2_Update.BackgroundImage = null;
        }
        private void button_form_2_Update_OnLeave(object sender, EventArgs e)
        {
            button_form_2_Update.Text = "";
            this.button_form_2_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_2_Update.BackgroundImage")));
        }
        private void button_form_3_View_OnHover(object sender, EventArgs e)
        {
            button_form_3_View.Text = btn_msg[2];
            this.button_form_3_View.BackgroundImage = null;
        }
        private void button_form_3_View_OnLeave(object sender, EventArgs e)
        {
            button_form_3_View.Text = "";
            this.button_form_3_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_3_View.BackgroundImage")));
        }
        private void button_form_4_Delete_OnHover(object sender, EventArgs e)
        {
            button_form_4_Delete.Text = btn_msg[3];
            this.button_form_4_Delete.BackgroundImage = null;
        }
        private void button_form_4_Delete_OnLeave(object sender, EventArgs e)
        {
            button_form_4_Delete.Text = "";
            this.button_form_4_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_4_Delete.BackgroundImage")));
        }
        private void button_form_1_Create_OnHover(object sender, EventArgs e)
        {
            button_form_1_Create.Text = btn_msg[0];
            this.button_form_1_Create.BackgroundImage = null;
        }
        private void button_form_1_Create_OnLeave(object sender, EventArgs e)
        {
            button_form_1_Create.Text = "";
            this.button_form_1_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_1_Create.BackgroundImage")));
        }
    }
}
