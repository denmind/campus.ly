namespace campusLy._Forms
{
    partial class FormUnenroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_message = new System.Windows.Forms.Label();
            this.cmbox_student = new System.Windows.Forms.ComboBox();
            this.lbl_info_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_enrollee_course_yr = new System.Windows.Forms.TextBox();
            this.txt_enrollee_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_course_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Black;
            this.lbl_message.Location = new System.Drawing.Point(20, 30);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(248, 24);
            this.lbl_message.TabIndex = 34;
            this.lbl_message.Text = "Select Student Enrollee";
            // 
            // cmbox_student
            // 
            this.cmbox_student.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbox_student.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_student.ForeColor = System.Drawing.Color.Black;
            this.cmbox_student.FormattingEnabled = true;
            this.cmbox_student.Location = new System.Drawing.Point(304, 30);
            this.cmbox_student.Name = "cmbox_student";
            this.cmbox_student.Size = new System.Drawing.Size(158, 26);
            this.cmbox_student.TabIndex = 35;
            this.cmbox_student.SelectedValueChanged += new System.EventHandler(this.cmbox_student_ValueChanged);
            // 
            // lbl_info_1
            // 
            this.lbl_info_1.AutoSize = true;
            this.lbl_info_1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_1.Location = new System.Drawing.Point(20, 54);
            this.lbl_info_1.Name = "lbl_info_1";
            this.lbl_info_1.Size = new System.Drawing.Size(184, 18);
            this.lbl_info_1.TabIndex = 36;
            this.lbl_info_1.Text = "Search via Student ID Number";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Select Course to Unenroll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Double click to remove from course";
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Course.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Course.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_Course.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Course.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Course.Enabled = false;
            this.dataGridView_Course.GridColor = System.Drawing.Color.Silver;
            this.dataGridView_Course.Location = new System.Drawing.Point(20, 203);
            this.dataGridView_Course.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Course.MultiSelect = false;
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.ReadOnly = true;
            this.dataGridView_Course.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView_Course.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Course.ShowEditingIcon = false;
            this.dataGridView_Course.Size = new System.Drawing.Size(442, 245);
            this.dataGridView_Course.StandardTab = true;
            this.dataGridView_Course.TabIndex = 42;
            this.dataGridView_Course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Course_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Title/Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Course and Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Student Name (Last, First Middle)";
            // 
            // txt_enrollee_course_yr
            // 
            this.txt_enrollee_course_yr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enrollee_course_yr.ForeColor = System.Drawing.Color.Black;
            this.txt_enrollee_course_yr.Location = new System.Drawing.Point(337, 107);
            this.txt_enrollee_course_yr.Name = "txt_enrollee_course_yr";
            this.txt_enrollee_course_yr.ReadOnly = true;
            this.txt_enrollee_course_yr.Size = new System.Drawing.Size(125, 25);
            this.txt_enrollee_course_yr.TabIndex = 44;
            this.txt_enrollee_course_yr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_enrollee_name
            // 
            this.txt_enrollee_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enrollee_name.ForeColor = System.Drawing.Color.Black;
            this.txt_enrollee_name.Location = new System.Drawing.Point(20, 107);
            this.txt_enrollee_name.Name = "txt_enrollee_name";
            this.txt_enrollee_name.ReadOnly = true;
            this.txt_enrollee_name.Size = new System.Drawing.Size(286, 25);
            this.txt_enrollee_name.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Courses Enrolled: ";
            // 
            // lbl_course_count
            // 
            this.lbl_course_count.AutoSize = true;
            this.lbl_course_count.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_count.Location = new System.Drawing.Point(416, 173);
            this.lbl_course_count.Name = "lbl_course_count";
            this.lbl_course_count.Size = new System.Drawing.Size(0, 18);
            this.lbl_course_count.TabIndex = 48;
            // 
            // FormUnenroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.lbl_course_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_enrollee_course_yr);
            this.Controls.Add(this.txt_enrollee_name);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_info_1);
            this.Controls.Add(this.cmbox_student);
            this.Controls.Add(this.lbl_message);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormUnenroll";
            this.Text = "DELETE | ENROLL";
            this.Load += new System.EventHandler(this.FormUnenroll_Load);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.lbl_message, 0);
            this.Controls.SetChildIndex(this.cmbox_student, 0);
            this.Controls.SetChildIndex(this.lbl_info_1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGridView_Course, 0);
            this.Controls.SetChildIndex(this.txt_enrollee_name, 0);
            this.Controls.SetChildIndex(this.txt_enrollee_course_yr, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbl_course_count, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.ComboBox cmbox_student;
        protected internal System.Windows.Forms.Label lbl_info_1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dataGridView_Course;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox txt_enrollee_course_yr;
        protected internal System.Windows.Forms.TextBox txt_enrollee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Label lbl_course_count;
    }
}
