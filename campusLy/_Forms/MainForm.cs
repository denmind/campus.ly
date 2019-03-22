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
        internal string form_type;

        string[] btn_msg = {
            "Create record data",
            "Update record info",
            "View record list",
            "Delete some records" };

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));

        public MainForm(string type)
        {
            InitializeComponent();
            form_type = type;

            this.Text += type;

            if(type == "STUDENT")
            {
                this.button_form_1_Create.Click += new System.EventHandler(this.STUDENT_button_form_1_Create_OnClick);
                this.button_form_2_Update.Click += new System.EventHandler(this.STUDENT_button_form_2_Update_OnClick);
                this.button_form_3_View.Click += new System.EventHandler(this.STUDENT_button_form_3_View_OnClick);
                this.button_form_4_Delete.Click += new System.EventHandler(this.STUDENT_button_form_4_Delete_Click);
            }else if(type == "COURSE")
            {

            }else if(type == "ENROLL")
            {

            }
        }

        internal string FormType
        {
            get { return form_type; }
        }

        //STUDENT
        /*1. CREATE*/
        private void STUDENT_button_form_1_Create_OnClick(object sender, EventArgs e)
        {
            new FormCreate(FormType).ShowDialog();
        }
        /*2. UPDATE*/
        private void STUDENT_button_form_2_Update_OnClick(object sender, EventArgs e)
        {
            string title = "UPDATE a student record";
            string message = "Double click on a row cell to EDIT RECORD!";
            string type = "UPDATE";

            new FormView(true, type, title, message).ShowDialog();
        }
        /*3. VIEW*/
        private void STUDENT_button_form_3_View_OnClick(object sender, EventArgs e)
        {
            string title = "VIEW Student Records";
            string message = "Double click on a row cell to GENERATE RECORD FILE!";
            string type = "VIEW";

            new FormView(true, type, title, message).ShowDialog();
        }
        /*4. DELETE*/
        private void STUDENT_button_form_4_Delete_Click(object sender, EventArgs e)
        {
            string title = "DELETE a student record";
            string message = "Double click on a row cell to DELETE RECORD immediately!";
            string type = "DELETE";

            new FormView(true,type, title, message).ShowDialog();
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
