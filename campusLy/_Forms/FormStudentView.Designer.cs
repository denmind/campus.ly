namespace campusLy._Forms
{
    partial class FormStudentView
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
            this.dataGridView_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srch_box = new System.Windows.Forms.TextBox();
            this.richText_title = new System.Windows.Forms.RichTextBox();
            this.lbl_form_view_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Location = new System.Drawing.Point(236, 10);
            this.label_message.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView_view
            // 
            this.dataGridView_view.AllowUserToDeleteRows = false;
            this.dataGridView_view.AllowUserToOrderColumns = true;
            this.dataGridView_view.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_view.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = " ";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_view.GridColor = System.Drawing.Color.Silver;
            this.dataGridView_view.Location = new System.Drawing.Point(12, 55);
            this.dataGridView_view.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_view.MultiSelect = false;
            this.dataGridView_view.Name = "dataGridView_view";
            this.dataGridView_view.ReadOnly = true;
            this.dataGridView_view.RowHeadersWidth = 19;
            this.dataGridView_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView_view.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_view.ShowEditingIcon = false;
            this.dataGridView_view.Size = new System.Drawing.Size(951, 382);
            this.dataGridView_view.StandardTab = true;
            this.dataGridView_view.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MaxInputLength = 0;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID No";
            this.Column2.MaxInputLength = 0;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.MaxInputLength = 0;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Middle Name";
            this.Column4.MaxInputLength = 0;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "First Name";
            this.Column5.MaxInputLength = 0;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Course";
            this.Column6.MaxInputLength = 0;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Year";
            this.Column7.MaxInputLength = 0;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Birthdate";
            this.Column8.MaxInputLength = 0;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Gender";
            this.Column9.MaxInputLength = 0;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Date Added";
            this.Column10.MaxInputLength = 0;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // srch_box
            // 
            this.srch_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srch_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srch_box.Location = new System.Drawing.Point(12, 12);
            this.srch_box.Name = "srch_box";
            this.srch_box.Size = new System.Drawing.Size(301, 26);
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
            this.richText_title.Location = new System.Drawing.Point(12, 56);
            this.richText_title.Name = "richText_title";
            this.richText_title.ReadOnly = true;
            this.richText_title.Size = new System.Drawing.Size(656, 381);
            this.richText_title.TabIndex = 5;
            this.richText_title.Text = "Database contains no record of such instance!";
            // 
            // lbl_form_view_title
            // 
            this.lbl_form_view_title.AutoSize = true;
            this.lbl_form_view_title.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_view_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_form_view_title.Location = new System.Drawing.Point(369, 17);
            this.lbl_form_view_title.Name = "lbl_form_view_title";
            this.lbl_form_view_title.Size = new System.Drawing.Size(14, 17);
            this.lbl_form_view_title.TabIndex = 6;
            this.lbl_form_view_title.Text = "*";
            // 
            // FormStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.lbl_form_view_title);
            this.Controls.Add(this.srch_box);
            this.Controls.Add(this.dataGridView_view);
            this.Controls.Add(this.richText_title);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormStudentView";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Controls.SetChildIndex(this.richText_title, 0);
            this.Controls.SetChildIndex(this.dataGridView_view, 0);
            this.Controls.SetChildIndex(this.srch_box, 0);
            this.Controls.SetChildIndex(this.label_message, 0);
            this.Controls.SetChildIndex(this.lbl_form_view_title, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox srch_box;
        private System.Windows.Forms.RichTextBox richText_title;
        private System.Windows.Forms.Label lbl_form_view_title;
        internal System.Windows.Forms.DataGridView dataGridView_view;
    }
}
#endregion