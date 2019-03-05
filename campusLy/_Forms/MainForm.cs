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

namespace campusLy
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            Database DB = new Database();

            if (DB.start())
            {
            }
            else
            {
            }

            this.label_status.Text = DB.updateConnectionState();
        }

        private void button_formCreate_OnClick(object sender, EventArgs e)
        {

        }

        private void button_formUpdate_OnClick(object sender, EventArgs e)
        {

        }

        private void button_formView_OnClick(object sender, EventArgs e)
        {

        }
    }
}
