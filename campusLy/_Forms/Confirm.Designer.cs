namespace campusLy._Forms
{
    partial class Confirm
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
            this.richTextBox_confirm_delete = new System.Windows.Forms.RichTextBox();
            this.button_true = new System.Windows.Forms.Button();
            this.button_false = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_confirm_delete
            // 
            this.richTextBox_confirm_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.richTextBox_confirm_delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_confirm_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_confirm_delete.ForeColor = System.Drawing.Color.White;
            this.richTextBox_confirm_delete.Location = new System.Drawing.Point(17, 123);
            this.richTextBox_confirm_delete.Name = "richTextBox_confirm_delete";
            this.richTextBox_confirm_delete.ReadOnly = true;
            this.richTextBox_confirm_delete.Size = new System.Drawing.Size(232, 185);
            this.richTextBox_confirm_delete.TabIndex = 0;
            this.richTextBox_confirm_delete.Text = "";
            // 
            // button_true
            // 
            this.button_true.BackColor = System.Drawing.Color.GreenYellow;
            this.button_true.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_true.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_true.Location = new System.Drawing.Point(17, 314);
            this.button_true.Name = "button_true";
            this.button_true.Size = new System.Drawing.Size(232, 47);
            this.button_true.TabIndex = 1;
            this.button_true.Text = "CONFIRM";
            this.button_true.UseVisualStyleBackColor = false;
            // 
            // button_false
            // 
            this.button_false.BackColor = System.Drawing.Color.Red;
            this.button_false.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_false.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_false.Location = new System.Drawing.Point(17, 383);
            this.button_false.Name = "button_false";
            this.button_false.Size = new System.Drawing.Size(232, 47);
            this.button_false.TabIndex = 2;
            this.button_false.Text = "CANCEL";
            this.button_false.UseVisualStyleBackColor = false;
            this.button_false.Click += new System.EventHandler(this.button_false_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(17, 29);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(232, 50);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "CONFIRM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "DELETE?";
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_false);
            this.Controls.Add(this.button_true);
            this.Controls.Add(this.richTextBox_confirm_delete);
            this.Name = "Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_confirm_delete;
        private System.Windows.Forms.Button button_true;
        private System.Windows.Forms.Button button_false;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
    }
}