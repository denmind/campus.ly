namespace campusLy._Forms
{
    partial class DataOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataOption));
            this.button_STUDENT = new System.Windows.Forms.Button();
            this.button_COURSE = new System.Windows.Forms.Button();
            this.button_ENROLL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_STUDENT
            // 
            this.button_STUDENT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_STUDENT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_STUDENT.BackgroundImage")));
            this.button_STUDENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_STUDENT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_STUDENT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_STUDENT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.button_STUDENT.Location = new System.Drawing.Point(11, 12);
            this.button_STUDENT.Name = "button_STUDENT";
            this.button_STUDENT.Size = new System.Drawing.Size(274, 65);
            this.button_STUDENT.TabIndex = 0;
            this.button_STUDENT.UseVisualStyleBackColor = false;
            this.button_STUDENT.Click += new System.EventHandler(this.button_STUDENT_OnClick);
            this.button_STUDENT.MouseLeave += new System.EventHandler(this.button_STUDENT_OnLeave);
            this.button_STUDENT.MouseHover += new System.EventHandler(this.button_STUDENT_OnHover);
            // 
            // button_COURSE
            // 
            this.button_COURSE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_COURSE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_COURSE.BackgroundImage")));
            this.button_COURSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_COURSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_COURSE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_COURSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.button_COURSE.Location = new System.Drawing.Point(11, 95);
            this.button_COURSE.Name = "button_COURSE";
            this.button_COURSE.Size = new System.Drawing.Size(275, 65);
            this.button_COURSE.TabIndex = 1;
            this.button_COURSE.UseVisualStyleBackColor = false;
            this.button_COURSE.Click += new System.EventHandler(this.button_COURSE_OnClick);
            this.button_COURSE.MouseLeave += new System.EventHandler(this.button_COURSE_OnLeave);
            this.button_COURSE.MouseHover += new System.EventHandler(this.button_COURSE_OnHover);
            // 
            // button_ENROLL
            // 
            this.button_ENROLL.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_ENROLL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ENROLL.BackgroundImage")));
            this.button_ENROLL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ENROLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ENROLL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ENROLL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.button_ENROLL.Location = new System.Drawing.Point(11, 178);
            this.button_ENROLL.Name = "button_ENROLL";
            this.button_ENROLL.Size = new System.Drawing.Size(275, 65);
            this.button_ENROLL.TabIndex = 2;
            this.button_ENROLL.UseVisualStyleBackColor = false;
            this.button_ENROLL.Click += new System.EventHandler(this.button_ENROLL_OnClick);
            this.button_ENROLL.MouseLeave += new System.EventHandler(this.button_ENROLL_OnLeave);
            this.button_ENROLL.MouseHover += new System.EventHandler(this.button_ENROLL_OnHover);
            // 
            // DataOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.button_ENROLL);
            this.Controls.Add(this.button_COURSE);
            this.Controls.Add(this.button_STUDENT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_STUDENT;
        private System.Windows.Forms.Button button_COURSE;
        private System.Windows.Forms.Button button_ENROLL;
    }
}