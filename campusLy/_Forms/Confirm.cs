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
        private Student stud_data;

        public Confirm(string type, int id, string message)
        {
            InitializeComponent();

            this.ConfirmId = id;
            this.richTextBox_confirm_delete.Text = message;

            if (type.Equals("UPDATE"))
            {
                label1.Text = "UPDATE?";
                this.button_true.Click += new System.EventHandler(this.UPDATE_button_true_Click);
            }
            else if (type.Equals("DELETE"))
            {
                label1.Text = "DELETE?";
                this.button_true.Click += new System.EventHandler(this.DELETE_button_true_Click);
            }
        }
        public Confirm(string type, int id, string message, Student data)
        {
            InitializeComponent();

            this.ConfirmId = id;
            this.richTextBox_confirm_delete.Text = message;
            this.StudData = data;

            if (type.Equals("UPDATE"))
            {
                label1.Text = "UPDATE?";
                this.button_true.Click += new System.EventHandler(this.UPDATE_button_true_Click);
            }
            else if (type.Equals("DELETE"))
            {
                label1.Text = "DELETE?";
                this.button_true.Click += new System.EventHandler(this.DELETE_button_true_Click);
            }
        }
        private void DELETE_button_true_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            new InfoForm(DB.delete(ConfirmId)).ShowDialog();

            this.Close();
        }
        private void UPDATE_button_true_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            if (DB.delete(ConfirmId))
            {
                new InfoForm(DB.insert(StudData)).ShowDialog();
            }
            else { new InfoForm(false).ShowDialog(); }


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
        internal Student StudData
        {
            get { return stud_data; }
            set { stud_data = value; }
        }
    }
}
