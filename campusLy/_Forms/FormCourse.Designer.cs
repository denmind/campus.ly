namespace campusLy._Forms
{
    partial class FormCourse
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_info_1 = new System.Windows.Forms.Label();
            this.gbx_course = new System.Windows.Forms.GroupBox();
            this.gbx_course_bs_lis = new System.Windows.Forms.RadioButton();
            this.gbx_course_bs_it = new System.Windows.Forms.RadioButton();
            this.gbx_course_bs_cs = new System.Windows.Forms.RadioButton();
            this.gbx_course_bs_is = new System.Windows.Forms.RadioButton();
            this.lbl_course_type = new System.Windows.Forms.Label();
            this.txt_course_code = new System.Windows.Forms.TextBox();
            this.lbl_course_code = new System.Windows.Forms.Label();
            this.txt_course_title = new System.Windows.Forms.RichTextBox();
            this.lbl_course_title = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.gbx_course.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Black;
            this.lbl_message.Location = new System.Drawing.Point(32, 24);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(366, 24);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Fill out information below properly\r\n";
            // 
            // lbl_info_1
            // 
            this.lbl_info_1.AutoSize = true;
            this.lbl_info_1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_1.Location = new System.Drawing.Point(26, 407);
            this.lbl_info_1.Name = "lbl_info_1";
            this.lbl_info_1.Size = new System.Drawing.Size(90, 18);
            this.lbl_info_1.TabIndex = 23;
            this.lbl_info_1.Text = "*Number only!";
            // 
            // gbx_course
            // 
            this.gbx_course.Controls.Add(this.gbx_course_bs_lis);
            this.gbx_course.Controls.Add(this.gbx_course_bs_it);
            this.gbx_course.Controls.Add(this.gbx_course_bs_cs);
            this.gbx_course.Controls.Add(this.gbx_course_bs_is);
            this.gbx_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbx_course.Location = new System.Drawing.Point(128, 76);
            this.gbx_course.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_course.Name = "gbx_course";
            this.gbx_course.Padding = new System.Windows.Forms.Padding(0);
            this.gbx_course.Size = new System.Drawing.Size(274, 37);
            this.gbx_course.TabIndex = 25;
            this.gbx_course.TabStop = false;
            // 
            // gbx_course_bs_lis
            // 
            this.gbx_course_bs_lis.AutoSize = true;
            this.gbx_course_bs_lis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_course_bs_lis.ForeColor = System.Drawing.Color.Black;
            this.gbx_course_bs_lis.Location = new System.Drawing.Point(194, 9);
            this.gbx_course_bs_lis.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_course_bs_lis.Name = "gbx_course_bs_lis";
            this.gbx_course_bs_lis.Size = new System.Drawing.Size(71, 21);
            this.gbx_course_bs_lis.TabIndex = 19;
            this.gbx_course_bs_lis.TabStop = true;
            this.gbx_course_bs_lis.Text = "BSLIS";
            this.gbx_course_bs_lis.UseVisualStyleBackColor = true;
            // 
            // gbx_course_bs_it
            // 
            this.gbx_course_bs_it.AutoSize = true;
            this.gbx_course_bs_it.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_course_bs_it.ForeColor = System.Drawing.Color.Black;
            this.gbx_course_bs_it.Location = new System.Drawing.Point(133, 9);
            this.gbx_course_bs_it.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_course_bs_it.Name = "gbx_course_bs_it";
            this.gbx_course_bs_it.Size = new System.Drawing.Size(61, 21);
            this.gbx_course_bs_it.TabIndex = 20;
            this.gbx_course_bs_it.TabStop = true;
            this.gbx_course_bs_it.Text = "BSIT";
            this.gbx_course_bs_it.UseVisualStyleBackColor = true;
            // 
            // gbx_course_bs_cs
            // 
            this.gbx_course_bs_cs.AutoSize = true;
            this.gbx_course_bs_cs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_course_bs_cs.ForeColor = System.Drawing.Color.Black;
            this.gbx_course_bs_cs.Location = new System.Drawing.Point(65, 9);
            this.gbx_course_bs_cs.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_course_bs_cs.Name = "gbx_course_bs_cs";
            this.gbx_course_bs_cs.Size = new System.Drawing.Size(68, 21);
            this.gbx_course_bs_cs.TabIndex = 19;
            this.gbx_course_bs_cs.TabStop = true;
            this.gbx_course_bs_cs.Text = "BSCS";
            this.gbx_course_bs_cs.UseVisualStyleBackColor = true;
            // 
            // gbx_course_bs_is
            // 
            this.gbx_course_bs_is.AutoSize = true;
            this.gbx_course_bs_is.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_course_bs_is.ForeColor = System.Drawing.Color.Black;
            this.gbx_course_bs_is.Location = new System.Drawing.Point(3, 9);
            this.gbx_course_bs_is.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_course_bs_is.Name = "gbx_course_bs_is";
            this.gbx_course_bs_is.Size = new System.Drawing.Size(62, 21);
            this.gbx_course_bs_is.TabIndex = 0;
            this.gbx_course_bs_is.TabStop = true;
            this.gbx_course_bs_is.Text = "BSIS";
            this.gbx_course_bs_is.UseVisualStyleBackColor = true;
            // 
            // lbl_course_type
            // 
            this.lbl_course_type.AutoSize = true;
            this.lbl_course_type.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_course_type.Location = new System.Drawing.Point(26, 85);
            this.lbl_course_type.Name = "lbl_course_type";
            this.lbl_course_type.Size = new System.Drawing.Size(71, 18);
            this.lbl_course_type.TabIndex = 24;
            this.lbl_course_type.Text = "Course:";
            // 
            // txt_course_code
            // 
            this.txt_course_code.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course_code.ForeColor = System.Drawing.Color.Black;
            this.txt_course_code.Location = new System.Drawing.Point(251, 133);
            this.txt_course_code.Name = "txt_course_code";
            this.txt_course_code.Size = new System.Drawing.Size(151, 25);
            this.txt_course_code.TabIndex = 27;
            this.txt_course_code.LostFocus += txt_field_ValidDigitOnly;
            // 
            // lbl_course_code
            // 
            this.lbl_course_code.AutoSize = true;
            this.lbl_course_code.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_code.ForeColor = System.Drawing.Color.Black;
            this.lbl_course_code.Location = new System.Drawing.Point(26, 136);
            this.lbl_course_code.Name = "lbl_course_code";
            this.lbl_course_code.Size = new System.Drawing.Size(124, 18);
            this.lbl_course_code.TabIndex = 26;
            this.lbl_course_code.Text = "*Course Code:";
            // 
            // txt_course_title
            // 
            this.txt_course_title.Location = new System.Drawing.Point(26, 315);
            this.txt_course_title.Name = "txt_course_title";
            this.txt_course_title.Size = new System.Drawing.Size(376, 67);
            this.txt_course_title.TabIndex = 28;
            this.txt_course_title.Text = "";
            this.txt_course_title.LostFocus += txt_field_ValidCharOnly;
            // 
            // lbl_course_title
            // 
            this.lbl_course_title.AutoSize = true;
            this.lbl_course_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_course_title.Location = new System.Drawing.Point(26, 279);
            this.lbl_course_title.Name = "lbl_course_title";
            this.lbl_course_title.Size = new System.Drawing.Size(205, 18);
            this.lbl_course_title.TabIndex = 29;
            this.lbl_course_title.Text = "Course Title/Description:";
            // 
            // btn_submit
            // 
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Location = new System.Drawing.Point(312, 403);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(90, 27);
            this.btn_submit.TabIndex = 30;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(430, 457);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_course_title);
            this.Controls.Add(this.txt_course_title);
            this.Controls.Add(this.txt_course_code);
            this.Controls.Add(this.lbl_course_code);
            this.Controls.Add(this.gbx_course);
            this.Controls.Add(this.lbl_course_type);
            this.Controls.Add(this.lbl_info_1);
            this.Controls.Add(this.lbl_message);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "FormCourse";
            this.Controls.SetChildIndex(this.lbl_message, 0);
            this.Controls.SetChildIndex(this.lbl_info_1, 0);
            this.Controls.SetChildIndex(this.lbl_course_type, 0);
            this.Controls.SetChildIndex(this.gbx_course, 0);
            this.Controls.SetChildIndex(this.lbl_course_code, 0);
            this.Controls.SetChildIndex(this.txt_course_code, 0);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.txt_course_title, 0);
            this.Controls.SetChildIndex(this.lbl_course_title, 0);
            this.Controls.SetChildIndex(this.btn_submit, 0);
            this.gbx_course.ResumeLayout(false);
            this.gbx_course.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Text = "CREATE | COURSE";

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        protected internal System.Windows.Forms.Label lbl_info_1;
        protected internal System.Windows.Forms.GroupBox gbx_course;
        protected internal System.Windows.Forms.RadioButton gbx_course_bs_lis;
        protected internal System.Windows.Forms.RadioButton gbx_course_bs_it;
        protected internal System.Windows.Forms.RadioButton gbx_course_bs_cs;
        protected internal System.Windows.Forms.RadioButton gbx_course_bs_is;
        protected internal System.Windows.Forms.Label lbl_course_type;
        protected internal System.Windows.Forms.Label lbl_course_code;


        protected internal System.Windows.Forms.TextBox txt_course_code;
        private System.Windows.Forms.RichTextBox txt_course_title;
        protected internal System.Windows.Forms.Label lbl_course_title;
        protected internal System.Windows.Forms.Button btn_submit;
    }
}
