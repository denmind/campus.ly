namespace campusLy
{
    partial class Form1
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
            this.btn_start_db = new System.Windows.Forms.Button();
            this.lbl_head = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start_db
            // 
            this.btn_start_db.Location = new System.Drawing.Point(12, 12);
            this.btn_start_db.Name = "btn_start_db";
            this.btn_start_db.Size = new System.Drawing.Size(75, 23);
            this.btn_start_db.TabIndex = 0;
            this.btn_start_db.Text = "Start Me Up!";
            this.btn_start_db.UseVisualStyleBackColor = true;
            this.btn_start_db.Click += new System.EventHandler(this.btn_start_db_Click);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Location = new System.Drawing.Point(12, 50);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(27, 13);
            this.lbl_head.TabIndex = 1;
            this.lbl_head.Text = "N/A";
            this.lbl_head.Click += new System.EventHandler(this.lbl_head_Click);
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(12, 114);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(27, 13);
            this.lbl_body.TabIndex = 2;
            this.lbl_body.Text = "N/A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.btn_start_db);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_db;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Button button1;
    }
}

