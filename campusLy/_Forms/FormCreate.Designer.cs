namespace campusLy._Forms
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            this.lbl_stud_id_no = new System.Windows.Forms.Label();
            this.lbl_stud_name_first = new System.Windows.Forms.Label();
            this.lbl_stud_name_middle_name = new System.Windows.Forms.Label();
            this.lbl_stud_name_last = new System.Windows.Forms.Label();
            this.lbl_stud_course = new System.Windows.Forms.Label();
            this.lbl_stud_course_yr = new System.Windows.Forms.Label();
            this.lbl_stud_date_of_birth = new System.Windows.Forms.Label();
            this.lbl_stud_gender = new System.Windows.Forms.Label();
            this.txt_stud_id_no = new System.Windows.Forms.TextBox();
            this.txt_stud_name_first = new System.Windows.Forms.TextBox();
            this.txt_stud_name_middle = new System.Windows.Forms.TextBox();
            this.txt_stud_name_last = new System.Windows.Forms.TextBox();
            this.dtp_stud_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.gbx_stud_course = new System.Windows.Forms.GroupBox();
            this.gbx_stud_course_bs_lis = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_bs_it = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_bs_cs = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_bs_is = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_yr = new System.Windows.Forms.GroupBox();
            this.gbx_stud_course_yr_fifth = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_yr_one = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_yr_two = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_yr_three = new System.Windows.Forms.RadioButton();
            this.gbx_stud_course_yr_four = new System.Windows.Forms.RadioButton();
            this.gbx_stud_gender = new System.Windows.Forms.GroupBox();
            this.gbx_stud_gender_male = new System.Windows.Forms.RadioButton();
            this.gbx_stud_gender_female = new System.Windows.Forms.RadioButton();
            this.lbl_info_1 = new System.Windows.Forms.Label();
            this.lbl_info_2 = new System.Windows.Forms.Label();
            this.gbx_stud_course.SuspendLayout();
            this.gbx_stud_course_yr.SuspendLayout();
            this.gbx_stud_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.Black;
            this.label_message.Location = new System.Drawing.Point(27, 19);
            this.label_message.Size = new System.Drawing.Size(366, 24);
            this.label_message.Text = "Fill out information below properly:";
            // 
            // lbl_stud_id_no
            // 
            this.lbl_stud_id_no.AutoSize = true;
            this.lbl_stud_id_no.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_id_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_id_no.Location = new System.Drawing.Point(386, 76);
            this.lbl_stud_id_no.Name = "lbl_stud_id_no";
            this.lbl_stud_id_no.Size = new System.Drawing.Size(70, 18);
            this.lbl_stud_id_no.TabIndex = 2;
            this.lbl_stud_id_no.Text = "**ID No:";
            // 
            // lbl_stud_name_first
            // 
            this.lbl_stud_name_first.AutoSize = true;
            this.lbl_stud_name_first.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_name_first.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_name_first.Location = new System.Drawing.Point(28, 76);
            this.lbl_stud_name_first.Name = "lbl_stud_name_first";
            this.lbl_stud_name_first.Size = new System.Drawing.Size(99, 18);
            this.lbl_stud_name_first.TabIndex = 3;
            this.lbl_stud_name_first.Text = "First Name:";
            // 
            // lbl_stud_name_middle_name
            // 
            this.lbl_stud_name_middle_name.AutoSize = true;
            this.lbl_stud_name_middle_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_name_middle_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_name_middle_name.Location = new System.Drawing.Point(28, 109);
            this.lbl_stud_name_middle_name.Name = "lbl_stud_name_middle_name";
            this.lbl_stud_name_middle_name.Size = new System.Drawing.Size(121, 18);
            this.lbl_stud_name_middle_name.TabIndex = 4;
            this.lbl_stud_name_middle_name.Text = "*Middle Name:";
            // 
            // lbl_stud_name_last
            // 
            this.lbl_stud_name_last.AutoSize = true;
            this.lbl_stud_name_last.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_name_last.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_name_last.Location = new System.Drawing.Point(28, 142);
            this.lbl_stud_name_last.Name = "lbl_stud_name_last";
            this.lbl_stud_name_last.Size = new System.Drawing.Size(89, 18);
            this.lbl_stud_name_last.TabIndex = 7;
            this.lbl_stud_name_last.Text = "Surname: ";
            // 
            // lbl_stud_course
            // 
            this.lbl_stud_course.AutoSize = true;
            this.lbl_stud_course.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_course.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_course.Location = new System.Drawing.Point(28, 296);
            this.lbl_stud_course.Name = "lbl_stud_course";
            this.lbl_stud_course.Size = new System.Drawing.Size(71, 18);
            this.lbl_stud_course.TabIndex = 6;
            this.lbl_stud_course.Text = "Course:";
            // 
            // lbl_stud_course_yr
            // 
            this.lbl_stud_course_yr.AutoSize = true;
            this.lbl_stud_course_yr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_course_yr.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_course_yr.Location = new System.Drawing.Point(28, 347);
            this.lbl_stud_course_yr.Name = "lbl_stud_course_yr";
            this.lbl_stud_course_yr.Size = new System.Drawing.Size(62, 18);
            this.lbl_stud_course_yr.TabIndex = 5;
            this.lbl_stud_course_yr.Text = "Yr. Lvl:";
            // 
            // lbl_stud_date_of_birth
            // 
            this.lbl_stud_date_of_birth.AutoSize = true;
            this.lbl_stud_date_of_birth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_date_of_birth.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_date_of_birth.Location = new System.Drawing.Point(28, 175);
            this.lbl_stud_date_of_birth.Name = "lbl_stud_date_of_birth";
            this.lbl_stud_date_of_birth.Size = new System.Drawing.Size(113, 18);
            this.lbl_stud_date_of_birth.TabIndex = 10;
            this.lbl_stud_date_of_birth.Text = "Date of Birth:";
            // 
            // lbl_stud_gender
            // 
            this.lbl_stud_gender.AutoSize = true;
            this.lbl_stud_gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_stud_gender.Location = new System.Drawing.Point(386, 109);
            this.lbl_stud_gender.Name = "lbl_stud_gender";
            this.lbl_stud_gender.Size = new System.Drawing.Size(73, 18);
            this.lbl_stud_gender.TabIndex = 9;
            this.lbl_stud_gender.Text = "Gender:";
            // 
            // txt_stud_id_no
            // 
            this.txt_stud_id_no.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_id_no.ForeColor = System.Drawing.Color.Black;
            this.txt_stud_id_no.Location = new System.Drawing.Point(497, 73);
            this.txt_stud_id_no.Name = "txt_stud_id_no";
            this.txt_stud_id_no.Size = new System.Drawing.Size(151, 25);
            this.txt_stud_id_no.TabIndex = 11;
            // 
            // txt_stud_name_first
            // 
            this.txt_stud_name_first.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_name_first.ForeColor = System.Drawing.Color.Black;
            this.txt_stud_name_first.Location = new System.Drawing.Point(194, 73);
            this.txt_stud_name_first.Name = "txt_stud_name_first";
            this.txt_stud_name_first.Size = new System.Drawing.Size(157, 25);
            this.txt_stud_name_first.TabIndex = 12;
            // 
            // txt_stud_name_middle
            // 
            this.txt_stud_name_middle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_name_middle.ForeColor = System.Drawing.Color.Black;
            this.txt_stud_name_middle.Location = new System.Drawing.Point(194, 106);
            this.txt_stud_name_middle.Name = "txt_stud_name_middle";
            this.txt_stud_name_middle.Size = new System.Drawing.Size(157, 25);
            this.txt_stud_name_middle.TabIndex = 13;
            // 
            // txt_stud_name_last
            // 
            this.txt_stud_name_last.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stud_name_last.ForeColor = System.Drawing.Color.Black;
            this.txt_stud_name_last.Location = new System.Drawing.Point(194, 139);
            this.txt_stud_name_last.Name = "txt_stud_name_last";
            this.txt_stud_name_last.Size = new System.Drawing.Size(157, 25);
            this.txt_stud_name_last.TabIndex = 14;
            // 
            // dtp_stud_date_of_birth
            // 
            this.dtp_stud_date_of_birth.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_stud_date_of_birth.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtp_stud_date_of_birth.CustomFormat = "yyyy-MM-dd";
            this.dtp_stud_date_of_birth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stud_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_stud_date_of_birth.Location = new System.Drawing.Point(194, 172);
            this.dtp_stud_date_of_birth.Name = "dtp_stud_date_of_birth";
            this.dtp_stud_date_of_birth.Size = new System.Drawing.Size(157, 25);
            this.dtp_stud_date_of_birth.TabIndex = 15;
            // 
            // btn_submit
            // 
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Location = new System.Drawing.Point(295, 402);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(90, 27);
            this.btn_submit.TabIndex = 17;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // gbx_stud_course
            // 
            this.gbx_stud_course.Controls.Add(this.gbx_stud_course_bs_lis);
            this.gbx_stud_course.Controls.Add(this.gbx_stud_course_bs_it);
            this.gbx_stud_course.Controls.Add(this.gbx_stud_course_bs_cs);
            this.gbx_stud_course.Controls.Add(this.gbx_stud_course_bs_is);
            this.gbx_stud_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbx_stud_course.Location = new System.Drawing.Point(190, 287);
            this.gbx_stud_course.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course.Name = "gbx_stud_course";
            this.gbx_stud_course.Padding = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course.Size = new System.Drawing.Size(274, 37);
            this.gbx_stud_course.TabIndex = 18;
            this.gbx_stud_course.TabStop = false;
            // 
            // gbx_stud_course_bs_lis
            // 
            this.gbx_stud_course_bs_lis.AutoSize = true;
            this.gbx_stud_course_bs_lis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_bs_lis.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_bs_lis.Location = new System.Drawing.Point(194, 9);
            this.gbx_stud_course_bs_lis.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_bs_lis.Name = "gbx_stud_course_bs_lis";
            this.gbx_stud_course_bs_lis.Size = new System.Drawing.Size(71, 21);
            this.gbx_stud_course_bs_lis.TabIndex = 19;
            this.gbx_stud_course_bs_lis.TabStop = true;
            this.gbx_stud_course_bs_lis.Text = "BSLIS";
            this.gbx_stud_course_bs_lis.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_bs_it
            // 
            this.gbx_stud_course_bs_it.AutoSize = true;
            this.gbx_stud_course_bs_it.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_bs_it.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_bs_it.Location = new System.Drawing.Point(133, 9);
            this.gbx_stud_course_bs_it.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_bs_it.Name = "gbx_stud_course_bs_it";
            this.gbx_stud_course_bs_it.Size = new System.Drawing.Size(61, 21);
            this.gbx_stud_course_bs_it.TabIndex = 20;
            this.gbx_stud_course_bs_it.TabStop = true;
            this.gbx_stud_course_bs_it.Text = "BSIT";
            this.gbx_stud_course_bs_it.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_bs_cs
            // 
            this.gbx_stud_course_bs_cs.AutoSize = true;
            this.gbx_stud_course_bs_cs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_bs_cs.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_bs_cs.Location = new System.Drawing.Point(65, 9);
            this.gbx_stud_course_bs_cs.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_bs_cs.Name = "gbx_stud_course_bs_cs";
            this.gbx_stud_course_bs_cs.Size = new System.Drawing.Size(68, 21);
            this.gbx_stud_course_bs_cs.TabIndex = 19;
            this.gbx_stud_course_bs_cs.TabStop = true;
            this.gbx_stud_course_bs_cs.Text = "BSCS";
            this.gbx_stud_course_bs_cs.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_bs_is
            // 
            this.gbx_stud_course_bs_is.AutoSize = true;
            this.gbx_stud_course_bs_is.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_bs_is.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_bs_is.Location = new System.Drawing.Point(3, 9);
            this.gbx_stud_course_bs_is.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_bs_is.Name = "gbx_stud_course_bs_is";
            this.gbx_stud_course_bs_is.Size = new System.Drawing.Size(62, 21);
            this.gbx_stud_course_bs_is.TabIndex = 0;
            this.gbx_stud_course_bs_is.TabStop = true;
            this.gbx_stud_course_bs_is.Text = "BSIS";
            this.gbx_stud_course_bs_is.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_yr
            // 
            this.gbx_stud_course_yr.Controls.Add(this.gbx_stud_course_yr_fifth);
            this.gbx_stud_course_yr.Controls.Add(this.gbx_stud_course_yr_one);
            this.gbx_stud_course_yr.Controls.Add(this.gbx_stud_course_yr_two);
            this.gbx_stud_course_yr.Controls.Add(this.gbx_stud_course_yr_three);
            this.gbx_stud_course_yr.Controls.Add(this.gbx_stud_course_yr_four);
            this.gbx_stud_course_yr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbx_stud_course_yr.Location = new System.Drawing.Point(190, 338);
            this.gbx_stud_course_yr.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr.Name = "gbx_stud_course_yr";
            this.gbx_stud_course_yr.Padding = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr.Size = new System.Drawing.Size(313, 37);
            this.gbx_stud_course_yr.TabIndex = 19;
            this.gbx_stud_course_yr.TabStop = false;
            // 
            // gbx_stud_course_yr_fifth
            // 
            this.gbx_stud_course_yr_fifth.AutoSize = true;
            this.gbx_stud_course_yr_fifth.FlatAppearance.BorderSize = 0;
            this.gbx_stud_course_yr_fifth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_yr_fifth.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_yr_fifth.Location = new System.Drawing.Point(244, 11);
            this.gbx_stud_course_yr_fifth.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr_fifth.Name = "gbx_stud_course_yr_fifth";
            this.gbx_stud_course_yr_fifth.Size = new System.Drawing.Size(49, 21);
            this.gbx_stud_course_yr_fifth.TabIndex = 21;
            this.gbx_stud_course_yr_fifth.TabStop = true;
            this.gbx_stud_course_yr_fifth.Text = "5th";
            this.gbx_stud_course_yr_fifth.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_yr_one
            // 
            this.gbx_stud_course_yr_one.AutoSize = true;
            this.gbx_stud_course_yr_one.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_yr_one.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_yr_one.Location = new System.Drawing.Point(3, 11);
            this.gbx_stud_course_yr_one.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr_one.Name = "gbx_stud_course_yr_one";
            this.gbx_stud_course_yr_one.Size = new System.Drawing.Size(48, 21);
            this.gbx_stud_course_yr_one.TabIndex = 19;
            this.gbx_stud_course_yr_one.TabStop = true;
            this.gbx_stud_course_yr_one.Text = "1st";
            this.gbx_stud_course_yr_one.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_yr_two
            // 
            this.gbx_stud_course_yr_two.AutoSize = true;
            this.gbx_stud_course_yr_two.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_yr_two.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_yr_two.Location = new System.Drawing.Point(61, 11);
            this.gbx_stud_course_yr_two.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr_two.Name = "gbx_stud_course_yr_two";
            this.gbx_stud_course_yr_two.Size = new System.Drawing.Size(53, 21);
            this.gbx_stud_course_yr_two.TabIndex = 20;
            this.gbx_stud_course_yr_two.TabStop = true;
            this.gbx_stud_course_yr_two.Text = "2nd";
            this.gbx_stud_course_yr_two.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_yr_three
            // 
            this.gbx_stud_course_yr_three.AutoSize = true;
            this.gbx_stud_course_yr_three.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_yr_three.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_yr_three.Location = new System.Drawing.Point(124, 11);
            this.gbx_stud_course_yr_three.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr_three.Name = "gbx_stud_course_yr_three";
            this.gbx_stud_course_yr_three.Size = new System.Drawing.Size(51, 21);
            this.gbx_stud_course_yr_three.TabIndex = 19;
            this.gbx_stud_course_yr_three.TabStop = true;
            this.gbx_stud_course_yr_three.Text = "3rd";
            this.gbx_stud_course_yr_three.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_course_yr_four
            // 
            this.gbx_stud_course_yr_four.AutoSize = true;
            this.gbx_stud_course_yr_four.FlatAppearance.BorderSize = 0;
            this.gbx_stud_course_yr_four.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_course_yr_four.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_course_yr_four.Location = new System.Drawing.Point(185, 11);
            this.gbx_stud_course_yr_four.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_course_yr_four.Name = "gbx_stud_course_yr_four";
            this.gbx_stud_course_yr_four.Size = new System.Drawing.Size(49, 21);
            this.gbx_stud_course_yr_four.TabIndex = 0;
            this.gbx_stud_course_yr_four.TabStop = true;
            this.gbx_stud_course_yr_four.Text = "4th";
            this.gbx_stud_course_yr_four.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_gender
            // 
            this.gbx_stud_gender.Controls.Add(this.gbx_stud_gender_male);
            this.gbx_stud_gender.Controls.Add(this.gbx_stud_gender_female);
            this.gbx_stud_gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbx_stud_gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_stud_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.gbx_stud_gender.Location = new System.Drawing.Point(497, 107);
            this.gbx_stud_gender.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_gender.Name = "gbx_stud_gender";
            this.gbx_stud_gender.Padding = new System.Windows.Forms.Padding(0);
            this.gbx_stud_gender.Size = new System.Drawing.Size(85, 53);
            this.gbx_stud_gender.TabIndex = 20;
            this.gbx_stud_gender.TabStop = false;
            // 
            // gbx_stud_gender_male
            // 
            this.gbx_stud_gender_male.AutoSize = true;
            this.gbx_stud_gender_male.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_gender_male.Location = new System.Drawing.Point(0, 26);
            this.gbx_stud_gender_male.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_gender_male.Name = "gbx_stud_gender_male";
            this.gbx_stud_gender_male.Size = new System.Drawing.Size(60, 21);
            this.gbx_stud_gender_male.TabIndex = 19;
            this.gbx_stud_gender_male.TabStop = true;
            this.gbx_stud_gender_male.Text = "Male";
            this.gbx_stud_gender_male.UseVisualStyleBackColor = true;
            // 
            // gbx_stud_gender_female
            // 
            this.gbx_stud_gender_female.AutoSize = true;
            this.gbx_stud_gender_female.ForeColor = System.Drawing.Color.Black;
            this.gbx_stud_gender_female.Location = new System.Drawing.Point(0, 3);
            this.gbx_stud_gender_female.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_stud_gender_female.Name = "gbx_stud_gender_female";
            this.gbx_stud_gender_female.Size = new System.Drawing.Size(79, 21);
            this.gbx_stud_gender_female.TabIndex = 0;
            this.gbx_stud_gender_female.TabStop = true;
            this.gbx_stud_gender_female.Text = "Female";
            this.gbx_stud_gender_female.UseVisualStyleBackColor = true;
            // 
            // lbl_info_1
            // 
            this.lbl_info_1.AutoSize = true;
            this.lbl_info_1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_1.Location = new System.Drawing.Point(28, 402);
            this.lbl_info_1.Name = "lbl_info_1";
            this.lbl_info_1.Size = new System.Drawing.Size(181, 18);
            this.lbl_info_1.TabIndex = 21;
            this.lbl_info_1.Text = "*Leave empty if unnecessary!";
            // 
            // lbl_info_2
            // 
            this.lbl_info_2.AutoSize = true;
            this.lbl_info_2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_2.Location = new System.Drawing.Point(28, 420);
            this.lbl_info_2.Name = "lbl_info_2";
            this.lbl_info_2.Size = new System.Drawing.Size(181, 18);
            this.lbl_info_2.TabIndex = 22;
            this.lbl_info_2.Text = "**Number only!";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.lbl_info_2);
            this.Controls.Add(this.lbl_info_1);
            this.Controls.Add(this.gbx_stud_gender);
            this.Controls.Add(this.gbx_stud_course_yr);
            this.Controls.Add(this.gbx_stud_course);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dtp_stud_date_of_birth);
            this.Controls.Add(this.txt_stud_name_last);
            this.Controls.Add(this.txt_stud_name_middle);
            this.Controls.Add(this.txt_stud_name_first);
            this.Controls.Add(this.txt_stud_id_no);
            this.Controls.Add(this.lbl_stud_date_of_birth);
            this.Controls.Add(this.lbl_stud_gender);
            this.Controls.Add(this.lbl_stud_name_last);
            this.Controls.Add(this.lbl_stud_course);
            this.Controls.Add(this.lbl_stud_course_yr);
            this.Controls.Add(this.lbl_stud_name_middle_name);
            this.Controls.Add(this.lbl_stud_name_first);
            this.Controls.Add(this.lbl_stud_id_no);
            this.Name = "FormCreate";
            this.Text = "CREATE Student Record";
            this.Controls.SetChildIndex(this.lbl_stud_id_no, 0);
            this.Controls.SetChildIndex(this.lbl_stud_name_first, 0);
            this.Controls.SetChildIndex(this.lbl_stud_name_middle_name, 0);
            this.Controls.SetChildIndex(this.lbl_stud_course_yr, 0);
            this.Controls.SetChildIndex(this.lbl_stud_course, 0);
            this.Controls.SetChildIndex(this.lbl_stud_name_last, 0);
            this.Controls.SetChildIndex(this.lbl_stud_gender, 0);
            this.Controls.SetChildIndex(this.lbl_stud_date_of_birth, 0);
            this.Controls.SetChildIndex(this.txt_stud_id_no, 0);
            this.Controls.SetChildIndex(this.txt_stud_name_first, 0);
            this.Controls.SetChildIndex(this.txt_stud_name_middle, 0);
            this.Controls.SetChildIndex(this.txt_stud_name_last, 0);
            this.Controls.SetChildIndex(this.dtp_stud_date_of_birth, 0);
            this.Controls.SetChildIndex(this.btn_submit, 0);
            this.Controls.SetChildIndex(this.gbx_stud_course, 0);
            this.Controls.SetChildIndex(this.gbx_stud_course_yr, 0);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.gbx_stud_gender, 0);
            this.Controls.SetChildIndex(this.lbl_info_1, 0);
            this.Controls.SetChildIndex(this.lbl_info_2, 0);
            this.gbx_stud_course.ResumeLayout(false);
            this.gbx_stud_course.PerformLayout();
            this.gbx_stud_course_yr.ResumeLayout(false);
            this.gbx_stud_course_yr.PerformLayout();
            this.gbx_stud_gender.ResumeLayout(false);
            this.gbx_stud_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /*Labels*/
        protected internal System.Windows.Forms.Label lbl_stud_id_no;
        protected internal System.Windows.Forms.Label lbl_stud_name_first;
        protected internal System.Windows.Forms.Label lbl_stud_name_middle_name;
        protected internal System.Windows.Forms.Label lbl_stud_name_last;
        protected internal System.Windows.Forms.Label lbl_stud_course;
        protected internal System.Windows.Forms.Label lbl_stud_course_yr;
        protected internal System.Windows.Forms.Label lbl_stud_date_of_birth;
        protected internal System.Windows.Forms.Label lbl_stud_gender;
        protected internal System.Windows.Forms.Label lbl_info_1;
        protected internal System.Windows.Forms.Label lbl_info_2;

        /*Input*/
        protected internal System.Windows.Forms.TextBox txt_stud_id_no;
        protected internal System.Windows.Forms.TextBox txt_stud_name_first;
        protected internal System.Windows.Forms.TextBox txt_stud_name_middle;
        protected internal System.Windows.Forms.TextBox txt_stud_name_last;
        protected internal System.Windows.Forms.DateTimePicker dtp_stud_date_of_birth;

        /*Course*/
        protected internal System.Windows.Forms.GroupBox gbx_stud_course;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_bs_it;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_bs_cs;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_bs_is;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_bs_lis;

        /*CourseYr*/
        protected internal System.Windows.Forms.GroupBox gbx_stud_course_yr;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_yr_one;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_yr_two;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_yr_three;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_yr_four;
        protected internal System.Windows.Forms.RadioButton gbx_stud_course_yr_fifth;

        /*Gender*/
        protected internal System.Windows.Forms.GroupBox gbx_stud_gender;
        protected internal System.Windows.Forms.RadioButton gbx_stud_gender_male;
        protected internal System.Windows.Forms.RadioButton gbx_stud_gender_female;

        /*Other*/
        protected internal System.Windows.Forms.Button btn_submit;
    }
}