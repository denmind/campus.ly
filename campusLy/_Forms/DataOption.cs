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
    public partial class DataOption : Form
    {
        string[] btn_message =
       {
            "Choose STUDENT",
            "Choose COURSE",
            "Choose ENROLLEES"
        };
        string[] form_table =
        {
            "STUDENT",
            "COURSE",
            "ENROLL"
        };

        ComponentResourceManager resources = new ComponentResourceManager(typeof(DataOption));
        public DataOption()
        {
            InitializeComponent();
        }

        //STUDENT
        private void button_STUDENT_OnClick(object sender, EventArgs e)
        {
            new MainForm(form_table[0]).ShowDialog();
        }
        //COURSE
        private void button_COURSE_OnClick(object sender, EventArgs e)
        {
            new MainForm(form_table[1]).ShowDialog(); 
        }
        //ENROLL
        private void button_ENROLL_OnClick(object sender, EventArgs e)
        {
            new MainForm(form_table[2]).ShowDialog();
        }


        //HOVER AND LEAVE
        private void button_STUDENT_OnHover(object sender, EventArgs e)
        {
            button_STUDENT.Text = btn_message[0];
            this.button_STUDENT.BackgroundImage = null;
        }
        private void button_STUDENT_OnLeave(object sender, EventArgs e)
        {
            button_STUDENT.Text = "";
            this.button_STUDENT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_STUDENT.BackgroundImage")));
        }
        private void button_COURSE_OnHover(object sender, EventArgs e)
        {
            button_COURSE.Text = btn_message[1];
            this.button_COURSE.BackgroundImage = null;
        }
        private void button_COURSE_OnLeave(object sender, EventArgs e)
        {
            button_COURSE.Text = "";
            this.button_COURSE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_COURSE.BackgroundImage")));
        }
        private void button_ENROLL_OnHover(object sender, EventArgs e)
        {
            button_ENROLL.Text = btn_message[2];
            this.button_ENROLL.BackgroundImage = null;
        }
        private void button_ENROLL_OnLeave(object sender, EventArgs e)
        {
            button_ENROLL.Text = "";
            this.button_ENROLL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ENROLL.BackgroundImage")));
        }
    }
}
