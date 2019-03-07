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
    public partial class FormView : BaseForm
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            const int data_head_set = 10;
            
            Database DB = new Database();

            int data_set = DB.viewSize() * data_head_set;

            List<string>[] data_list = new List<string>[data_set];

            data_list = DB.view();

            foreach (List<string> list in data_list)
            {

            }
        }
    }
}
