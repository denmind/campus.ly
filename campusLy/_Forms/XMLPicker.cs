using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using campusLy._Classes;

namespace campusLy._Forms
{
    public partial class XMLPicker : campusLy._Forms.BaseForm
    {
        FileHandler XML = new FileHandler();

        //Don't instantiate
        //is modified in XMLPicker constructor
        Student stud_inst;
        Course course_inst;

        string FinalFileRead;

        string xml_group;
        string xml_file_name;

        //FormStudentView.cs
        public XMLPicker(string tableType, Student studata)
        {
            InitializeComponent();

            //Changes directory in where to find XML templates
            XML.selectFolderRead(tableType);

            xml_group = tableType;
            stud_inst = studata;
            xml_file_name = studata.IdNo + "";

            //Helps user in identifying which data is being used
            this.Text += " | " + studata.IdNo + " " + studata.NameLast;
        }
        //FormCourseView.cs
        public XMLPicker(string tableType, Course coursedata)
        {
            InitializeComponent();

            //Changes directory in where to find XML templates
            XML.selectFolderRead(tableType);

            xml_group = tableType;
            course_inst = coursedata;
            xml_file_name = coursedata.CourseCode + "";

            //Helps user in identifying which data is being used
            this.Text += " | " + coursedata.CourseCode;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string dataWrite = richTxtBox_preview.Text;
            string message = "GENERATION: ";

            XML.selectFolderWrite(xml_group);

            message += (XML.WriteFile(dataWrite, xml_file_name)) ? "SUCCESS" : "FAILED";

            new MessageForm(XML, message).ShowDialog();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XMLPicker_Load(object sender, EventArgs e)
        {
            //Counts files in folder and displays in form title
            int count = XML.countFilesInFolder();

            this.Text += " | (" + count + ") FILES";

            FileInfo[] myFiles = new FileInfo[count];

            //There is more than 1 file in the folder
            if (XML.getFilesInFolder(myFiles))
            {
                cmBox_files.Enabled = true;
                richTxtBox_preview.Enabled = true;

                for (int i = 0; i < count; i++)
                {
                    cmBox_files.Items.Add(myFiles[i].Name);
                }
            }
            else
            {
                richTxtBox_preview.Text = "NO XML TEMPLATE IN DIRECTORY!";
            }
        }

        private void link_open_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(FinalFileRead);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void cmBox_files_ValueChanged(object sender, EventArgs e)
        {
            string filetemplate = "";
            string preview = "";

            if (false == link_open.Visible)
                link_open.Visible = true;

            try
            {
                FinalFileRead = XML.FileLocation + @"\" + cmBox_files.Text;

                filetemplate = File.ReadAllText(FinalFileRead);

                //CHOOSES WHICH DATA TO PREVIEW
                if (stud_inst != null)
                    preview = XML.buildStudent(filetemplate, stud_inst);

                if (course_inst != null)
                    preview = XML.buildCourse(filetemplate, course_inst);

                richTxtBox_preview.Text = preview;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }


            if (false == btn_confirm.Enabled)
                btn_confirm.Enabled = true;

        }
    }
}
