using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
     internal class FileGen
    {
        Student studentData;
        List<Course> studCourses;

        string file_location;

        internal const int StudDataSize = 8;
        internal const string FileLoc= @"_records\";
        internal FileGen()
        {
            file_location = FileLoc;
        }
        internal string FileLocation
        {
            get { return file_location; }
            set { file_location = value; }
        }
        internal FileGen(Student student) { studentData = student; }
        
        internal Student StudData
        {
            get { return studentData; }
            set { studentData = value; }
        }
        internal List<Course> StudCourses
        {
            get { return studCourses; }
            set { studCourses = value; }
        }

        internal string ProduceCourses()
        {
            string total = "";
            foreach (Course data in studCourses)
            {
                string template = "\n<course>\n\t<course_code>" + data.CourseCode + "</course_code>\n\t<course_title>" + data.CourseTitle + "</course_title>\n</course>";

                total += template;
            }
            return total;
        }
        internal string ProduceFile()
        {
            bool value = true;
            string file_template = "none";
            try
            {
                string file_type = ".xml";

                DirectoryInfo info = Directory.CreateDirectory(FileLocation);
                
                FileLocation += StudData.IdNo + file_type;


                /*string */file_template = (StudData.midInitIsEmpty()) ?

                /*if mid name is empty*/
                "<student>\n\t<stud_id_no>" + StudData.IdNo + "</stud_id_no>\n\t<stud_name_first>" + StudData.NameFirst + "</stud_name_first>\n\t<stud_name_last>" + StudData.NameLast + "</stud_name_last>\n\t<stud_course>" + StudData.Course + "</stud_course>\n\t<stud_course_yr>" + StudData.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + StudData.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + StudData.Gender + "</stud_gender>\n</student>"

                :

                /*if mid name exists*/
                "<student>\n\t<stud_id_no>" + StudData.IdNo + "</stud_id_no>\n\t<stud_name_first>" + StudData.NameFirst + "</stud_name_first>\n\t<stud_name_mi>" + StudData.NameMiddle + "</stud_name_mi>\n\t<stud_name_last>" + StudData.NameLast + "</stud_name_last>\n\t<stud_course>" + StudData.Course + "</stud_course>\n\t<stud_course_yr>" + StudData.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + StudData.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + StudData.Gender + "</stud_gender>\n</student>"

                ;

                file_template += ProduceCourses();

                File.WriteAllText(FileLocation, file_template);

            }
            catch (Exception E) { value = false; }


            return file_template;
        }

    }
}
