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
        FileGen file;
        internal MessageForm(string data)
        {
            InitializeComponent();
            msg_text.Text += data;
            //Clipboard.SetText(msg_text.Text);

            lbl_records_link.Visible = false;
        }
        internal MessageForm(string data, FileGen instance)
        {
            InitializeComponent();
            msg_text.Text += data;
            Clipboard.SetText(msg_text.Text);

            file = instance;
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
