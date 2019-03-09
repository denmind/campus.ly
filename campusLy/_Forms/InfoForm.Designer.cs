namespace campusLy._Forms
{
    partial class InfoForm
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
        private void InitializeComponent(bool message_flag)
        {
            this.lbl_top_label = new System.Windows.Forms.Label();
            this.lbl_top_feedback = new System.Windows.Forms.Label();
            this.lbl_bottom_close_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_top_label
            // 
            this.lbl_top_label.AutoSize = true;
            this.lbl_top_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_label.Location = new System.Drawing.Point(29, 29);
            this.lbl_top_label.Name = "lbl_top_label";
            this.lbl_top_label.Size = new System.Drawing.Size(153, 24);
            this.lbl_top_label.TabIndex = 0;
            this.lbl_top_label.Text = "Operation Status:";
            // 
            // lbl_top_feedback
            // 
            this.lbl_top_feedback.AutoSize = true;
            this.lbl_top_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_feedback.Location = new System.Drawing.Point(188, 29);
            this.lbl_top_feedback.Name = "lbl_top_feedback";
            this.lbl_top_feedback.Size = new System.Drawing.Size(0, 24);
            this.lbl_top_feedback.TabIndex = 1;
            if (message_flag)
            {
                lbl_top_feedback.ForeColor = System.Drawing.Color.Lime;
                lbl_top_feedback.Text = "Success!";
            }
            else
            {
                lbl_top_feedback.ForeColor = System.Drawing.Color.Red;
                lbl_top_feedback.Text = "Failed!";
            }
            // 
            // lbl_bottom_close_link
            // 
            this.lbl_bottom_close_link.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.lbl_bottom_close_link.AutoSize = true;
            this.lbl_bottom_close_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_bottom_close_link.DisabledLinkColor = System.Drawing.Color.White;
            this.lbl_bottom_close_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bottom_close_link.LinkColor = System.Drawing.Color.White;
            this.lbl_bottom_close_link.Location = new System.Drawing.Point(52, 86);
            this.lbl_bottom_close_link.Name = "lbl_bottom_close_link";
            this.lbl_bottom_close_link.Size = new System.Drawing.Size(181, 18);
            this.lbl_bottom_close_link.TabIndex = 2;
            this.lbl_bottom_close_link.TabStop = true;
            this.lbl_bottom_close_link.Text = "Close window to continue!";
            this.lbl_bottom_close_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_bottom_close_link_LinkClicked);

            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lbl_bottom_close_link);
            this.Controls.Add(this.lbl_top_feedback);
            this.Controls.Add(this.lbl_top_label);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_top_label;
        private System.Windows.Forms.Label lbl_top_feedback;
        private System.Windows.Forms.LinkLabel lbl_bottom_close_link;
    }
}