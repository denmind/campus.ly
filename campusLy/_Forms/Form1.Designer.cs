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
            this.SuspendLayout();
            // 
            // btn_start_db
            // 
            this.btn_start_db.Location = new System.Drawing.Point(106, 40);
            this.btn_start_db.Name = "btn_start_db";
            this.btn_start_db.Size = new System.Drawing.Size(75, 23);
            this.btn_start_db.TabIndex = 0;
            this.btn_start_db.Text = "Start Me Up!";
            this.btn_start_db.UseVisualStyleBackColor = true;
            this.btn_start_db.Click += new System.EventHandler(this.btn_start_db_Click);
            // 
            // label1
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Location = new System.Drawing.Point(106, 122);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(35, 13);
            this.lbl_head.TabIndex = 1;
            this.lbl_head.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.btn_start_db);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_db;
        private System.Windows.Forms.Label lbl_head;
    }
}

