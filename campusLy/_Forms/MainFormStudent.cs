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
    public partial class MainFormStudent : BaseForm
    {
        string[] btn_msg = {
            "Create record data",
            "Update record info",
            "View record list",
            "Delete some records" };

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainFormStudent));

        public MainFormStudent()
        {
            InitializeComponent();

            this.Text = "Campus.ly | STUDENT";
        }


        /*1. CREATE*/
        private void button_form_1_Create_OnClick(object sender, EventArgs e)
        {
            new FormCreate().ShowDialog();
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


        /*2. UPDATE*/
        private void button_form_2_Update_OnClick(object sender, EventArgs e)
        {
            string title = "UPDATE a student record";
            string message = "Double click on a row cell to EDIT RECORD!";
            string type = "UPDATE";

            new FormView(true, type, title, message).ShowDialog();
        }
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



        /*3. VIEW*/
        private void button_form_3_View_OnClick(object sender, EventArgs e)
        {
            string title = "VIEW Student Records";
            string message = "Double click on a row cell to GENERATE RECORD FILE!";
            string type = "VIEW";

            new FormView(true, type, title, message).ShowDialog();
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



        /*4. DELETE*/
        private void button_form_4_Delete_Click(object sender, EventArgs e)
        {
            string title = "DELETE a student record";
            string message = "Double click on a row cell to DELETE RECORD immediately!";
            string type = "DELETE";

            new FormView(true,type, title, message).ShowDialog();
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

        private void mainMenuTools_CleanIdentifiers_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<int> id_data = DB.getSortedStudID();

            new InfoForm(DB.cleanStudID(id_data)).ShowDialog();
        }

    }
}
