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
        public FormStudentView(string optype, string header_message)
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
            //reset
            if (dataGridView_view.Visible.Equals(false))
            {
                dataGridView_view.Visible = true;
            }

            lbl_form_view_title.Visible = true;
            menuStrip.Visible = true;

            dataGridView_view.Rows.Clear();

            Database DB = new Database();

            string search_term = srch_box.Text;

            List<Student> stud_data = new List<Student>();

            stud_data = DB.searchStudent(search_term);

            displayOnDataGridView(stud_data);
        }
        private void VIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            try
            {
                Student student = new Student
                {
                    Id = (int)hold[0].Value,
                    IdNo = (int)hold[1].Value,
                    NameLast = hold[2].Value + "",
                    NameMiddle = hold[3].Value + "",
                    NameFirst = hold[4].Value + "",
                    Course = hold[5].Value + "",
                    CourseYr = (int)hold[6].Value,
                    DateOfBirth = hold[7].Value + "",
                    Gender = hold[8].Value + "",
                    DateAdded = hold[9].Value + ""
                };

                new XMLPicker("student", student).ShowDialog();
            }
            catch (Exception E) { }
        }
        private void UPDATE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a table row is double clicked a new FormStudent is created, two methods are then executed
            //1. DROP the selected identifier 2. CREATE a new record from the form using same create method in FormStudent

            Database DB = new Database();

            int indx = e.RowIndex;

            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;
            try
            {
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
            catch (Exception E) { }
            
        }
        private void DELETE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int row_size = 10;

            Database DB = new Database();

            int indx = e.RowIndex;
            DataGridViewCellCollection hold = dataGridView_view.Rows[indx].Cells;

            try
            {
                string data = "";

                for (int i = 1; i < row_size; i++)
                    data += i + ". " + hold[i].Value + "\n";

                indx = Int32.Parse(hold[0].Value + "");

                this.Close();
                new Confirm("STUDENT", indx, data).ShowDialog();
            }
            catch (Exception E) { }
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

                lbl_form_view_title.Visible = false;
                menuStrip.Visible = false;
            }
        }

        private void GenerateXMLFromSelectedValues(object sender, EventArgs e)
        {
            //SelectedColumns displays 0 no matter the number of selected cells
            //SelectedRows only works for the entire row
            //SelectedCells can get the row index but they are duped
            int rowCount = dataGridView_view.SelectedCells.Count;

            if (rowCount > 0)
            {
                Selector select = new Selector();
                List<int> indexFinal = new List<int>();

                //Adds row index in collection, but makes sure it is not duped
                //So that the number of selected rows is equiv to number of form modals
                for (int i = 0; i < rowCount; i++)
                    select.AddIfNotExist(indexFinal, dataGridView_view.SelectedCells[i].RowIndex);

                rowCount = indexFinal.Count;

                if (rowCount > 0)
                {
                    DataGridViewCellCollection hold;

                    //Depending on the number of indexes in collection
                    //should be equiv to number of XMLPicker forms shown
                    foreach (int i in indexFinal)
                    {
                        hold = dataGridView_view.Rows[i].Cells;

                        try
                        {
                            Student student = new Student
                            {
                                Id = (int)hold[0].Value,
                                IdNo = (int)hold[1].Value,
                                NameLast = hold[2].Value + "",
                                NameMiddle = hold[3].Value + "",
                                NameFirst = hold[4].Value + "",
                                Course = hold[5].Value + "",
                                CourseYr = (int)hold[6].Value,
                                DateOfBirth = hold[7].Value + "",
                                Gender = hold[8].Value + "",
                                DateAdded = hold[9].Value + ""
                            };

                            new XMLPicker("student", student).ShowDialog();
                        }
                        catch (Exception E) { }
                    }
                }
            }
        }
    }
}
