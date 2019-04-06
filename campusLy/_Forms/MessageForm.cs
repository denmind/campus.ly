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
    public partial class MessageForm : Form
    {
        FileHandler file;
        internal MessageForm(FileHandler XML, string message)
        {
            InitializeComponent();
            msg_text.Text += message;
            file = XML;

            if (XML != null && lbl_records_link.Visible == false)
                lbl_records_link.Visible = true;
        }
        void MessageForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void lbl_records_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(file.FileLocation);
        }
    }
}
