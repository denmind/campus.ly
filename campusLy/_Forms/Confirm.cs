using System;
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
    public partial class Confirm : Form
    {
        private int id;

        public Confirm(string table_type, int id, string message)
        {
            InitializeComponent();

            this.ConfirmId = id;
            this.richTextBox_confirm_delete.Text = message;

            switch (table_type)
            {
                case "STUDENT": this.button_true.Click += new System.EventHandler(this.STUD_DELETE); break;
                case "COURSE": this.button_true.Click += new System.EventHandler(this.COURSE_DELETE); break;
                case "ENROLL": this.button_true.Click += new System.EventHandler(this.ENROLL_DELETE); break;
            }
        }
        private void STUD_DELETE(object sender, EventArgs e)
        {
            Database DB = new Database();

            new InfoForm(DB.deleteStud(ConfirmId)).ShowDialog();
            this.Close();
        }
        private void COURSE_DELETE(object sender, EventArgs e)
        {
            Database DB = new Database();

            new InfoForm(DB.deleteCourse(ConfirmId)).ShowDialog();
            this.Close();
        }
        private void ENROLL_DELETE(object sender, EventArgs e)
        {
            Database DB = new Database();

            //new InfoForm(DB.deleteCourse(ConfirmId)).ShowDialog();

            this.Close();
        }
        private void button_false_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal int ConfirmId
        {
            get { return id; }
            set { id = value; }
        }
    }
}
