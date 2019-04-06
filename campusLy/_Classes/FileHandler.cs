using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    internal class FileHandler
    {
        string file_location;

        internal const string FileLocReading = @"_templates\";
        internal const string FileLocWriting = @"_records\";
        internal const string FileType = ".xml";

        internal FileHandler()
        {
            file_location = "";
        }
        internal string FileLocation
        {
            get { return file_location; }
            set { file_location = value; }
        }
        internal void selectFolderRead(string folder_type)
        {
            FileLocation = FileLocReading + "_" + folder_type;
        }
        internal void selectFolderWrite(string folder_type)
        {
            FileLocation = FileLocWriting + "_" + folder_type;
        }
        internal int countFilesInFolder()
        {
            DirectoryInfo info = new System.IO.DirectoryInfo(FileLocation);

            return info.GetFiles().Length;
        }
        internal void getFilesInFolder(FileInfo[] storage)
        {
            int filecount = this.countFilesInFolder();
            DirectoryInfo info = new System.IO.DirectoryInfo(FileLocation);

            FileInfo[] fileInfos = info.GetFiles();

            for (int i = 0; i < filecount; i++)
                storage[i] = fileInfos[i];
        }

        //FOR STUDENT
        internal string buildStudent(string data, Student stdat)
        {
            Database DB = new Database();
            string search_term = "";
            string final_term = "";
            string stud_final_output = this.findAndCapture(data, "<student>", "</student>");
            string course_final_output = this.findAndCapture(data, "<course>", "</course>");

            //STUDENT BUILDER
            if (stud_final_output != "")
            {
                //CHANGE PARAMETER APPROPRIATE TO DATABASE TABLE NAME
                List<string> attributes = DB.getAttributesFromTable("student");

                foreach (string tagData in attributes)
                {
                    search_term = "<" + tagData + "></" + tagData + ">";

                    final_term = "<" + tagData + ">";

                    //EDIT THIS CASE PART IF ANY NEW ATTRIBUTE IS ADDED TO DATABASE
                    //ALONG WITH APPROPRIATE ACCESSOR
                    switch (tagData)
                    {
                        case "stud_id": final_term += stdat.Id + ""; break;
                        case "stud_id_no": final_term += stdat.IdNo + ""; break;
                        case "stud_name_first": final_term += stdat.NameFirst + ""; break;
                        case "stud_name_mi": final_term += stdat.NameMiddle + ""; break;
                        case "stud_name_last": final_term += stdat.NameLast + ""; break;
                        case "stud_course": final_term += stdat.Course + ""; break;
                        case "stud_course_yr": final_term += stdat.CourseYr + ""; break;
                        case "stud_date_of_birth": final_term += stdat.DateOfBirth + ""; break;
                        case "stud_gender": final_term += stdat.Gender + ""; break;
                        case "date_added": final_term += stdat.DateAdded + ""; break;
                    }

                    final_term += "</" + tagData + ">";

                    //at this point search_term and final_term is well built
                    stud_final_output = stud_final_output.Replace(search_term, final_term);
                }
            }

            //COURSE BUILDER
            if (course_final_output != "")
            {
                //CHANGE PARAMETER APPROPRIATE TO DATABASE TABLE NAME
                List<string> attributes = DB.getAttributesFromTable("course");
                List<Course> subjects = DB.selectEnrolledCoursesOfStudent(stdat);

                //course_backbone exists, since this method is meant for determining the student
                //and its enrolled courses regardless if there exists or none, a student may have 0 or more
                //enrolled courses, hence the need for a List<Course>, course_backbone serves as a 'money plate' for
                //'printing' courses
                string course_backbone = course_final_output;
                course_final_output = "";

                foreach (Course course in subjects)
                {
                    course_final_output += "\n" + course_backbone;
                    foreach (string tagData in attributes)
                    {
                        search_term = "<" + tagData + "></" + tagData + ">";

                        final_term = "<" + tagData + ">";

                        //EDIT THIS CASE PART IF ANY NEW ATTRIBUTE IS ADDED TO DATABASE
                        //ALONG WITH APPROPRIATE ACCESSOR
                        switch (tagData)
                        {
                            case "course_id": final_term += course.CourseId + ""; break;
                            case "course_code": final_term += course.CourseCode + ""; break;
                            case "course_title": final_term += course.CourseTitle + ""; break;
                            case "course_type": final_term += course.CourseType + ""; break;
                        }

                        final_term += "</" + tagData + ">";

                        //at this point search_term and final_term is well built
                        course_final_output = course_final_output.Replace(search_term, final_term);
                    }
                }

            }

            //ADD BOTH STUDENT AND COURSE DATA

            return stud_final_output + "" + course_final_output;
        }

        internal string findAndCapture(string data, string begin, string end)
        {
            string final = "";

            //WHERE TO END DURING SEARCH
            int end_length = end.Length - 1;

            int indx_begin = data.IndexOf(begin);
            int indx_end = data.IndexOf(end);

            //FUNCTION WILL RETURN BLANK STRING IF
            //SEARCH STRINGS ARE NOT FOUND
            if (indx_begin != indx_end)
            {
                indx_end += end_length;

                //COPY EACH CHARACTER FROM data TO final
                for (int i = indx_begin; i <= indx_end; i++)
                    final += data[i];
            }

            return final;
        }

        internal bool WriteFile(string fileData,string filename)
        {
            bool value = true;
            try
            {
                DirectoryInfo info = Directory.CreateDirectory(FileLocation);

                this.FileLocation += @"\" + filename + FileType;

                File.WriteAllText(FileLocation, fileData);
            }
            catch (Exception E)
            {
                value = false;
            }
            return value;
        }
    }
}

