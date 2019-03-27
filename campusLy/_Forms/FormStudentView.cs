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
    public partial class FormStudentView : BaseForm
    {
        public FormStudentView(string optype,string header_message)
        {
            InitializeComponent();
            this.Text = optype + " | STUDENT";
            lbl_form_view_title.Text += header_message;

            if (optype.Equals("VIEW"))
                this.dataGridView_view.CellDoubleClick += this.VIEW_CellClick;
            else if (optype.Equals("UPDATE"))
                this.dataGridView_view.CellDoubleClick += this.UPDATE_CellClick;
            else if (optype.Equals("DELETE"))
                this.dataGridView_view.CellDoubleClick += this.DELETE_CellClick;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_data = new List<Student>();

            stud_data = DB.selectStud();

            displayOnDataGridView(stud_data);

        }
        private void SEARCH_Focus(object sender, EventArgs e)
        {
            this.srch_box.Text = "";
        }
        private void SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_view.Visible.Equals(false))
            {
                dataGridView_view.Visible = true;
            }

            dataGridView_view.Rows.Clear();

            Database DB = new Database();

            string search_term = srch_box.Text;

            List<Student> stud_data = new List<Student>();

            stud_data = DB.searchStudent(search_term);

            displayOnDataGridView(stud_data);
        }

        private void VIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a message box (modal) is displayed and within the control form
            //a open file link is made available
            const int row_size = 10;

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";
            string[] dataGen = new string[row_size];

            Database DB = new Database();
            FileGen fileGen = new FileGen();

            //set i = 0 to include identifier in message form
            for (int i = 1; i < row_size; i++)
            {
               data += hold[i].Value + " ";
                dataGen[i - 1] = hold[i].Value + "";
            }
            Student student = new Student
            {
                Id = Int32.Parse(hold[0].Value + ""),
                IdNo = Int32.Parse(dataGen[0] + ""),
                NameLast = dataGen[1],
                NameMiddle = dataGen[2],
                NameFirst = dataGen[3],
                Course = dataGen[4],
                CourseYr = Int32.Parse(dataGen[5] + ""),
                DateOfBirth = dataGen[6],
                Gender = dataGen[7]
            };

            fileGen.ProduceStudent(student, DB.selectCoursesOfStud(student));

            this.Close();
            new MessageForm(data,fileGen).ShowDialog();
        }
        private void UPDATE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a new FormStudent is created, two methods are then executed
            //1. DROP the selected identifier 2. CREATE a new record from the form using same create method in FormStudent

            Database DB = new Database();

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            Student S = new Student
            {
                Id = (int)hold[0].Value,
                IdNo = (int)hold[1].Value,
                NameFirst = (string)hold[4].Value,
                NameMiddle = (string)hold[3].Value,
                NameLast = (string)hold[2].Value,
                Course = (string)hold[5].Value,
                CourseYr = (int)hold[6].Value,
                DateOfBirth = (string)hold[7].Value,
                Gender = (string)hold[8].Value,
                DateAdded = (string)hold[9].Value
            };

            this.Close();
            new FormStudent(S).ShowDialog();
        }
        private void DELETE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int row_size = 10;

            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";

            for (int i = 1; i < row_size; i++)
                data += i + ". " + hold[i].Value + "\n";

            indx = Int32.Parse(hold[0].Value + "");

            this.Close();
            new Confirm("STUDENT", indx, data).ShowDialog();
        }
        private void displayOnDataGridView(List<Student> stud_data)
        {
            if (stud_data.Count > 0)
            {
                richText_title.Visible = false;

                foreach (Student S in stud_data)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView_view.Rows[0].Clone();

                    //reserver identifier
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
            else
            {
                dataGridView_view.Visible = false;
                richText_title.Visible = true;
                richText_title.ReadOnly = true;
            }
        }

    }
}
