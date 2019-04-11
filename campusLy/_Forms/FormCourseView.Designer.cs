namespace campusLy._Forms
{
    partial class FormCourseView
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
            this.srch_box = new System.Windows.Forms.TextBox();
            this.richText_title = new System.Windows.Forms.RichTextBox();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_form_view_title = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Location = new System.Drawing.Point(205, 37);
            this.label_message.Size = new System.Drawing.Size(0, 17);
            // 
            // srch_box
            // 
            this.srch_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srch_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srch_box.Location = new System.Drawing.Point(9, 32);
            this.srch_box.Name = "srch_box";
            this.srch_box.Size = new System.Drawing.Size(254, 26);
            this.srch_box.TabIndex = 3;
            this.srch_box.Text = "Search anything...";
            this.srch_box.TextChanged += new System.EventHandler(this.SEARCH_TextChanged);
            this.srch_box.GotFocus += new System.EventHandler(this.SEARCH_Focus);
            // 
            // richText_title
            // 
            this.richText_title.BackColor = System.Drawing.Color.Moccasin;
            this.richText_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_title.Font = new System.Drawing.Font("OCR A Extended", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.richText_title.Location = new System.Drawing.Point(9, 84);
            this.richText_title.Name = "richText_title";
            this.richText_title.ReadOnly = true;
            this.richText_title.Size = new System.Drawing.Size(656, 381);
            this.richText_title.TabIndex = 5;
            this.richText_title.Text = "Database contains no record of such instance!";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_Course.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Course.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Course.GridColor = System.Drawing.Color.Silver;
            this.dataGridView_Course.Location = new System.Drawing.Point(9, 83);
            this.dataGridView_Course.Margin = new System.Windows.Forms.Padding(0);
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
            this.dataGridView_Course.Size = new System.Drawing.Size(656, 381);
            this.dataGridView_Course.StandardTab = true;
            this.dataGridView_Course.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Title/Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Course";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 88;
            // 
            // lbl_form_view_title
            // 
            this.lbl_form_view_title.AutoSize = true;
            this.lbl_form_view_title.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_view_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_form_view_title.Location = new System.Drawing.Point(267, 36);
            this.lbl_form_view_title.Name = "lbl_form_view_title";
            this.lbl_form_view_title.Size = new System.Drawing.Size(14, 18);
            this.lbl_form_view_title.TabIndex = 6;
            this.lbl_form_view_title.Text = "*";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(680, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiGenerateToolStripMenuItem});
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // multiGenerateToolStripMenuItem
            // 
            this.multiGenerateToolStripMenuItem.Name = "multiGenerateToolStripMenuItem";
            this.multiGenerateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiGenerateToolStripMenuItem.Text = "Generate File(s)";
            this.multiGenerateToolStripMenuItem.ToolTipText = "Produce XML Files based on selected data";
            this.multiGenerateToolStripMenuItem.Click += new System.EventHandler(this.GenerateXMLFromSelectedValues);
            // 
            // FormCourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.lbl_form_view_title);
            this.Controls.Add(this.srch_box);
            this.Controls.Add(this.richText_title);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormCourseView";
            this.Load += new System.EventHandler(this.FormCourseView_Load);
            this.Controls.SetChildIndex(this.richText_title, 0);
            this.Controls.SetChildIndex(this.srch_box, 0);
            this.Controls.SetChildIndex(this.lbl_form_view_title, 0);
            this.Controls.SetChildIndex(this.dataGridView_Course, 0);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.menuStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox srch_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridView dataGridView_Course;
        private System.Windows.Forms.RichTextBox richText_title;
        private System.Windows.Forms.Label lbl_form_view_title;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiGenerateToolStripMenuItem;
    }
}
