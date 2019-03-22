namespace campusLy._Forms
{
    partial class MessageForm
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
            this.msg_text = new System.Windows.Forms.RichTextBox();
            this.lbl_footnote = new System.Windows.Forms.Label();
            this.lbl_records_link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msg_text
            // 
            this.msg_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.msg_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msg_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_text.ForeColor = System.Drawing.Color.White;
            this.msg_text.Location = new System.Drawing.Point(12, 21);
            this.msg_text.Name = "msg_text";
            this.msg_text.ReadOnly = true;
            this.msg_text.Size = new System.Drawing.Size(428, 85);
            this.msg_text.TabIndex = 1;
            this.msg_text.Text = "";
            // 
            // lbl_footnote
            // 
            this.lbl_footnote.AutoSize = true;
            this.lbl_footnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footnote.Location = new System.Drawing.Point(12, 102);
            this.lbl_footnote.Name = "lbl_footnote";
            this.lbl_footnote.Size = new System.Drawing.Size(241, 18);
            this.lbl_footnote.TabIndex = 2;
            this.lbl_footnote.Text = "*Generated record and data copied!";
            // 
            // lbl_records_link
            // 
            this.lbl_records_link.AutoSize = true;
            this.lbl_records_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_records_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_records_link.Location = new System.Drawing.Point(360, 102);
            this.lbl_records_link.Name = "lbl_records_link";
            this.lbl_records_link.Size = new System.Drawing.Size(80, 18);
            this.lbl_records_link.TabIndex = 3;
            this.lbl_records_link.Text = "Open File";
            this.lbl_records_link.Click += new System.EventHandler(this.lbl_records_link_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(462, 129);
            this.Controls.Add(this.lbl_records_link);
            this.Controls.Add(this.lbl_footnote);
            this.Controls.Add(this.msg_text);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Sheet";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox msg_text;
        private System.Windows.Forms.Label lbl_footnote;
        private System.Windows.Forms.Label lbl_records_link;
    }
}