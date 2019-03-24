﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    internal class FileGen
    {
        string file_location;

        internal const string FileLoc = @"_records\";

        internal FileGen()
        {
            file_location = "";
        }
        internal string FileLocation
        {
            get { return file_location; }
            set { file_location = value; }
        }

        //STUDENT
        internal string ProduceCourses(List<Course> studCourses)
        {
            string total = "";
            foreach (Course data in studCourses)
            {
                string template = "\n<course>\n\t<course_code>" + data.CourseCode + "</course_code>\n\t<course_title>" + data.CourseTitle + "</course_title>\n</course>";

                total += template;
            }
            return total;
        }
        internal void ProduceStudent(Student StudData, List<Course> studCourses)
        {
            string file_template = "none";
            string file_type = ".xml";
            
            //Folder Name
            FileLocation = FileLoc + @"_student\";

            DirectoryInfo info = Directory.CreateDirectory(FileLocation);

            //FileName + dir
            FileLocation += StudData.IdNo + file_type;


            /*string */
            file_template = (StudData.midInitIsEmpty()) ?

            /*if mid name is empty*/
            "<student>\n\t<stud_id_no>" + StudData.IdNo + "</stud_id_no>\n\t<stud_name_first>" + StudData.NameFirst + "</stud_name_first>\n\t<stud_name_last>" + StudData.NameLast + "</stud_name_last>\n\t<stud_course>" + StudData.Course + "</stud_course>\n\t<stud_course_yr>" + StudData.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + StudData.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + StudData.Gender + "</stud_gender>\n</student>"
        
            :

            /*if mid name exists*/
            "<student>\n\t<stud_id_no>" + StudData.IdNo + "</stud_id_no>\n\t<stud_name_first>" + StudData.NameFirst + "</stud_name_first>\n\t<stud_name_mi>" + StudData.NameMiddle + "</stud_name_mi>\n\t<stud_name_last>" + StudData.NameLast + "</stud_name_last>\n\t<stud_course>" + StudData.Course + "</stud_course>\n\t<stud_course_yr>" + StudData.CourseYr + "</stud_course_yr>\n\t<stud_date_of_birth>" + StudData.DateOfBirth + "</stud_date_of_birth>\n\t<stud_gender>" + StudData.Gender + "</stud_gender>\n</student>"

            ;

            //Additional data
            file_template += ProduceCourses(studCourses);

            File.WriteAllText(FileLocation, file_template);
        }

        //COURSE
        internal void ProduceCourse(Course course)
        {
            string file_template = "none";
            string file_type = ".xml";

            //Folder Name
            FileLocation = FileLoc + @"_course\";

            DirectoryInfo info = Directory.CreateDirectory(FileLocation);

            file_template = "<course>\n\t<course_code>"+course.CourseCode+ "</course_code>\n\t<course_title>" + course.CourseTitle + "</course_title>\n\t<course_type>" + course.CourseType + "</course_type>\n</course>";

            //FileName + dir
            FileLocation += course.CourseCode + file_type;

            File.WriteAllText(FileLocation, file_template);
        }

        //ENROLL
    }
}
