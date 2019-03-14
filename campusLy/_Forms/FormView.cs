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
        public FormView(bool allowSearch, string optype , string title, string header_message)
        {
            InitializeComponent();
            this.srch_box.Visible = allowSearch;
            this.Text = title;
            lbl_form_view_title.Text += header_message;

            if (optype.Equals("VIEW"))
            {
                this.dataGridView_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VIEW_dataGridView_view_CellContentClick);
            }
            else if(optype.Equals("UPDATE"))
            {
                this.dataGridView_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UPDATE_dataGridView_view_CellContentClick);
            }
            else if (optype.Equals("DELETE"))
            {
                this.dataGridView_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DELETE_dataGridView_view_CellContentClick);
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            Database DB = new Database();

            List<Student> stud_data = new List<Student>();

            stud_data = DB.view();

            displayOnDataGridView(stud_data);

        }
        private void srch_box_GotFocus(object sender, EventArgs e)
        {
            this.srch_box.Text = "";
        }
        private void srch_box_TextChanged(object sender, EventArgs e)
        {
            Database DB = new Database();

            string search_term = srch_box.Text;

            List<Student> stud_data = new List<Student>();

            stud_data = DB.search(search_term);

            displayOnDataGridView(stud_data);
        }

        private void VIEW_dataGridView_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a message box (modal) is displayed and within the control form
            //a copy button to clipboard is made available
            

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";

            for(int i = 1; i < 10; i++) { 
                data += hold[i].Value + " ";
            }

            new MessageForm(data).ShowDialog();
        }
        private void UPDATE_dataGridView_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a new FormCreate is created, two methods are then executed
            //1. DROP the selected identifier 2. CREATE a new record from the form using same create method in FormCreate

            Database DB = new Database();

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            Student S = new Student();
            

            S.IdNo = (int)hold[1].Value;
            S.NameLast = (string)hold[2].Value;
            S.NameMiddle = (string)hold[3].Value;
            S.NameFirst = (string)hold[4].Value;
            S.Course = (string)hold[5].Value;
            S.CourseYr = (int)hold[6].Value;
            S.DateOfBirth = (string)hold[7].Value;
            S.Gender = (string)hold[8].Value;
            S.DateAdded = (string)hold[9].Value;

            new Confirm("UPDATE", indx, S.dataGen(), S).ShowDialog();
        }
        private void DELETE_dataGridView_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            string data = "";

            for (int i = 1; i < 10; i++)
            {
                data += i + ". " + hold[i].Value + "\n";
            }

            indx = Int32.Parse(hold[0].Value + "");

            new Confirm("DELETE",indx, data).ShowDialog();
        }

        private void displayOnDataGridView(List<Student> stud_data)
        {
            if (stud_data.Count > 0)
            {
                dataGridView_view.Rows.Clear();

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
            }else{
                dataGridView_view.Rows.Clear();
            }
        }
    }
}
