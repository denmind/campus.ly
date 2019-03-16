using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    class FileGen
    {
        Student FileData;
        internal const int FileDataSize = 8;
        internal FileGen() { }

        internal FileGen(Student student) { FileData = student; }

        internal Student Data
        {
            get { return FileData; }
            set { FileData = value; }
        }
        internal int DataSize
        {
            get { return FileDataSize;  }
        }
        internal bool ProduceFile()
        {
            bool value = true;
            try
            {
                string file_path = @"_records\";
                string file_type = ".xml";


                DirectoryInfo info = Directory.CreateDirectory(file_path);


                file_path += FileData.IdNo + file_type;


                string file_template = (Data.midInitIsEmpty()) ?

                /*if mid name is empty*/
                "<student>\n\t<stud_id_no>" + Data.IdNo + "</stud_id_no>\n\t<stud_name_first>" + Data.NameFirst + "</stud_name_first>\n\t<stud_name_last>" + Data.NameLast + "</stud_name_last>\n\t<stud_course>" + Data.Course + "</stud_course>\n\t<stud_course_yr>" + Data.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + Data.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + Data.Gender + "</stud_gender>\n</student>"

                :

                /*if mid name exists*/
                "<student>\n\t<stud_id_no>" + Data.IdNo + "</stud_id_no>\n\t<stud_name_first>" + Data.NameFirst + "</stud_name_first>\n\t<stud_name_mi>" + Data.NameMiddle + "</stud_name_mi>\n\t<stud_name_last>" + Data.NameLast + "</stud_name_last>\n\t<stud_course>" + Data.Course + "</stud_course>\n\t<stud_course_yr>" + Data.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + Data.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + Data.Gender + "</stud_gender>\n</student>"

                ;

                File.WriteAllText(file_path, file_template);

            }
            catch (Exception E) { value = false; }


            return value;
        }

    }
}
