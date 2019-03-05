namespace campusLy._Forms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.label_status = new System.Windows.Forms.Label();
            this.label_status_head = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Black;
            this.label_status.Location = new System.Drawing.Point(294, 260);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(36, 18);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "N/A";
            // 
            // label_status_head
            // 
            this.label_status_head.AutoSize = true;
            this.label_status_head.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_head.Location = new System.Drawing.Point(183, 260);
            this.label_status_head.Name = "label_status_head";
            this.label_status_head.Size = new System.Drawing.Size(105, 18);
            this.label_status_head.TabIndex = 1;
            this.label_status_head.Text = "Connection:";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(512, 301);
            this.Controls.Add(this.label_status_head);
            this.Controls.Add(this.label_status);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 340);
            this.MinimumSize = new System.Drawing.Size(528, 340);
            this.Name = "BaseForm";
            this.Text = "Campus.ly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_status_head;
    }
}