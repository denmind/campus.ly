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
    public partial class MessageForm : Form
    {
        public MessageForm(string data)
        {
            InitializeComponent();
            msg_text.Text += data;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            Clipboard.SetText(msg_text.Text);
        }
    }
}
