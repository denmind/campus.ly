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
        Student data;

        public Confirm(string type, int id, string message)
        {
            InitializeComponent();

            this.ConfirmId = id;
            this.richTextBox_confirm_delete.Text = message;

            if (type.Equals("UPDATE"))
            {
                label1.Text = "UPDATE?";
            }
            else if (type.Equals("DELETE"))
            {
                label1.Text = "DELETE?";
                this.button_true.Click += new System.EventHandler(this.DELETE_button_true_Click);
            }
        }
        public Confirm(string type, int id, string message , Student info)
        {
            InitializeComponent();

            this.ConfirmId = id;
            this.richTextBox_confirm_delete.Text = message;
            this.StudentInstance = info;

            if (type.Equals("UPDATE"))
            {
                label1.Text = "UPDATE?";
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

        internal Student StudentInstance
        {
            get { return data;  }
            set { data = value; }
        }
    }
}
