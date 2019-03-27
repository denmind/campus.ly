namespace campusLy._Forms
{
    partial class FormEnroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_submit = new System.Windows.Forms.Button();
            this.cmbox_student = new System.Windows.Forms.ComboBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_info_1 = new System.Windows.Forms.Label();
            this.txt_enrollee_name = new System.Windows.Forms.TextBox();
            this.txt_enrollee_course_yr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_courses = new System.Windows.Forms.ComboBox();
            this.txt_course_title = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_course_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Location = new System.Drawing.Point(213, 30);
            // 
            // btn_submit
            // 
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(195, 407);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(90, 27);
            this.btn_submit.TabIndex = 31;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // cmbox_student
            // 
            this.cmbox_student.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbox_student.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_student.ForeColor = System.Drawing.Color.Black;
            this.cmbox_student.FormattingEnabled = true;
            this.cmbox_student.Location = new System.Drawing.Point(300, 29);
            this.cmbox_student.Name = "cmbox_student";
            this.cmbox_student.Size = new System.Drawing.Size(158, 26);
            this.cmbox_student.TabIndex = 32;
            this.cmbox_student.SelectedValueChanged += new System.EventHandler(this.cmbox_student_ValueChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Black;
            this.lbl_message.Location = new System.Drawing.Point(22, 30);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(248, 24);
            this.lbl_message.TabIndex = 33;
            this.lbl_message.Text = "Select Student Enrollee";
            // 
            // lbl_info_1
            // 
            this.lbl_info_1.AutoSize = true;
            this.lbl_info_1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_1.Location = new System.Drawing.Point(22, 54);
            this.lbl_info_1.Name = "lbl_info_1";
            this.lbl_info_1.Size = new System.Drawing.Size(184, 18);
            this.lbl_info_1.TabIndex = 34;
            this.lbl_info_1.Text = "Search via Student ID Number";
            // 
            // txt_enrollee_name
            // 
            this.txt_enrollee_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enrollee_name.ForeColor = System.Drawing.Color.Black;
            this.txt_enrollee_name.Location = new System.Drawing.Point(22, 286);
            this.txt_enrollee_name.Name = "txt_enrollee_name";
            this.txt_enrollee_name.ReadOnly = true;
            this.txt_enrollee_name.Size = new System.Drawing.Size(286, 25);
            this.txt_enrollee_name.TabIndex = 35;
            // 
            // txt_enrollee_course_yr
            // 
            this.txt_enrollee_course_yr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enrollee_course_yr.ForeColor = System.Drawing.Color.Black;
            this.txt_enrollee_course_yr.Location = new System.Drawing.Point(333, 286);
            this.txt_enrollee_course_yr.Name = "txt_enrollee_course_yr";
            this.txt_enrollee_course_yr.ReadOnly = true;
            this.txt_enrollee_course_yr.Size = new System.Drawing.Size(125, 25);
            this.txt_enrollee_course_yr.TabIndex = 36;
            this.txt_enrollee_course_yr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Student Name (Last, First Middle)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Course and Year";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Select Course to Enroll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Search via Course Code";
            // 
            // cmbox_courses
            // 
            this.cmbox_courses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbox_courses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_courses.Enabled = false;
            this.cmbox_courses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_courses.ForeColor = System.Drawing.Color.Black;
            this.cmbox_courses.FormattingEnabled = true;
            this.cmbox_courses.Location = new System.Drawing.Point(300, 94);
            this.cmbox_courses.Name = "cmbox_courses";
            this.cmbox_courses.Size = new System.Drawing.Size(158, 26);
            this.cmbox_courses.TabIndex = 41;
            this.cmbox_courses.SelectedValueChanged += new System.EventHandler(this.cmbox_courses_ValueChanged);
            // 
            // txt_course_title
            // 
            this.txt_course_title.Location = new System.Drawing.Point(22, 335);
            this.txt_course_title.Name = "txt_course_title";
            this.txt_course_title.ReadOnly = true;
            this.txt_course_title.Size = new System.Drawing.Size(436, 53);
            this.txt_course_title.TabIndex = 42;
            this.txt_course_title.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Course Description";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(116, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Enrollment Information";
            // 
            // lbl_course_count
            // 
            this.lbl_course_count.AutoSize = true;
            this.lbl_course_count.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_count.Location = new System.Drawing.Point(297, 123);
            this.lbl_course_count.Name = "lbl_course_count";
            this.lbl_course_count.Size = new System.Drawing.Size(0, 18);
            this.lbl_course_count.TabIndex = 45;
            // 
            // FormEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.lbl_course_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_course_title);
            this.Controls.Add(this.cmbox_courses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_enrollee_course_yr);
            this.Controls.Add(this.txt_enrollee_name);
            this.Controls.Add(this.lbl_info_1);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.cmbox_student);
            this.Controls.Add(this.btn_submit);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormEnroll";
            this.Text = "CREATE | ENROLL";
            this.Load += new System.EventHandler(this.FormEnroll_Load);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.btn_submit, 0);
            this.Controls.SetChildIndex(this.cmbox_student, 0);
            this.Controls.SetChildIndex(this.lbl_message, 0);
            this.Controls.SetChildIndex(this.lbl_info_1, 0);
            this.Controls.SetChildIndex(this.txt_enrollee_name, 0);
            this.Controls.SetChildIndex(this.txt_enrollee_course_yr, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbox_courses, 0);
            this.Controls.SetChildIndex(this.txt_course_title, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbl_course_count, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cmbox_student;
        private System.Windows.Forms.Label lbl_message;
        protected internal System.Windows.Forms.Label lbl_info_1;
        protected internal System.Windows.Forms.TextBox txt_enrollee_name;
        protected internal System.Windows.Forms.TextBox txt_enrollee_course_yr;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_courses;
        private System.Windows.Forms.RichTextBox txt_course_title;
        protected internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label lbl_course_count;
    }
}
