namespace campusLy._Forms
{
    partial class XMLPicker
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
            this.richTxtBox_preview = new System.Windows.Forms.RichTextBox();
            this.cmBox_files = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.link_open = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Location = new System.Drawing.Point(219, 19);
            // 
            // richTxtBox_preview
            // 
            this.richTxtBox_preview.BackColor = System.Drawing.Color.White;
            this.richTxtBox_preview.Enabled = false;
            this.richTxtBox_preview.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox_preview.Location = new System.Drawing.Point(20, 129);
            this.richTxtBox_preview.Name = "richTxtBox_preview";
            this.richTxtBox_preview.ReadOnly = true;
            this.richTxtBox_preview.Size = new System.Drawing.Size(553, 279);
            this.richTxtBox_preview.TabIndex = 2;
            this.richTxtBox_preview.Text = "";
            // 
            // cmBox_files
            // 
            this.cmBox_files.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_files.Enabled = false;
            this.cmBox_files.FormattingEnabled = true;
            this.cmBox_files.Location = new System.Drawing.Point(20, 49);
            this.cmBox_files.Name = "cmBox_files";
            this.cmBox_files.Size = new System.Drawing.Size(305, 23);
            this.cmBox_files.TabIndex = 3;
            this.cmBox_files.SelectedValueChanged += new System.EventHandler(this.cmBox_files_ValueChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Lime;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(20, 444);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(252, 55);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "GENERATE XML";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(321, 444);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(252, 55);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Black;
            this.lbl_message.Location = new System.Drawing.Point(20, 93);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(133, 24);
            this.lbl_message.TabIndex = 10;
            this.lbl_message.Text = "File Preview";
            // 
            // link_open
            // 
            this.link_open.AutoSize = true;
            this.link_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_open.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_open.ForeColor = System.Drawing.Color.Black;
            this.link_open.Location = new System.Drawing.Point(418, 411);
            this.link_open.Name = "link_open";
            this.link_open.Size = new System.Drawing.Size(155, 15);
            this.link_open.TabIndex = 11;
            this.link_open.Text = "Open XML file template";
            this.link_open.Visible = false;
            this.link_open.Click += new System.EventHandler(this.link_open_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select XML Template";
            // 
            // XMLPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(593, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_open);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cmBox_files);
            this.Controls.Add(this.richTxtBox_preview);
            this.MaximumSize = new System.Drawing.Size(613, 565);
            this.MinimumSize = new System.Drawing.Size(613, 565);
            this.Name = "XMLPicker";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "XML Templates";
            this.Load += new System.EventHandler(this.XMLPicker_Load);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.richTxtBox_preview, 0);
            this.Controls.SetChildIndex(this.cmBox_files, 0);
            this.Controls.SetChildIndex(this.btn_confirm, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_message, 0);
            this.Controls.SetChildIndex(this.link_open, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox_preview;
        private System.Windows.Forms.ComboBox cmBox_files;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label link_open;
        private System.Windows.Forms.Label label1;
    }
}
