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
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(210, 9);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 15);
            this.label_message.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label_message);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "BaseForm";
            this.Text = "CAMPUS.ly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Label label_message;
    }
}