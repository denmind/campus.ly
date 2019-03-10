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
    public partial class FormView : BaseForm
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_data = new List<Student>();

            stud_data = DB.view();

            foreach(Student S in stud_data)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_view.Rows[0].Clone();

                row.Cells[0].Value = S.Id;
                row.Cells[1].Value = S.IdNo;
                row.Cells[2].Value = S.NameLast;
                row.Cells[3].Value = S.NameMiddle;
                row.Cells[4].Value = S.NameFirst;
                row.Cells[5].Value = S.Course;
                row.Cells[6].Value = S.CourseYr;
                row.Cells[7].Value = S.DateOfBirth;
                row.Cells[8].Value = S.Gender;
                row.Cells[9].Value = S.DateAdded;

                dataGridView_view.Rows.Add(row);
            }
        }
    }
}
