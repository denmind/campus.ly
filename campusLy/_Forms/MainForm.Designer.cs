
namespace campusLy
{
  
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_form_1_Create = new System.Windows.Forms.Button();
            this.button_form_2_Update = new System.Windows.Forms.Button();
            this.button_form_3_View = new System.Windows.Forms.Button();
            this.button_form_4_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.Location = new System.Drawing.Point(274, 334);
            // 
            // button_form_1_Create
            // 
            this.button_form_1_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_1_Create.BackgroundImage")));
            this.button_form_1_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_form_1_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_form_1_Create.Location = new System.Drawing.Point(34, 38);
            this.button_form_1_Create.MaximumSize = new System.Drawing.Size(110, 110);
            this.button_form_1_Create.MinimumSize = new System.Drawing.Size(110, 110);
            this.button_form_1_Create.Name = "button_form_1_Create";
            this.button_form_1_Create.Size = new System.Drawing.Size(110, 110);
            this.button_form_1_Create.TabIndex = 1;
            this.button_form_1_Create.UseVisualStyleBackColor = true;
            this.button_form_1_Create.Click += new System.EventHandler(this.button_form_1_Create_OnClick);
            // 
            // button_form_2_Update
            // 
            this.button_form_2_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_2_Update.BackgroundImage")));
            this.button_form_2_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_form_2_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_form_2_Update.Location = new System.Drawing.Point(445, 38);
            this.button_form_2_Update.MaximumSize = new System.Drawing.Size(110, 110);
            this.button_form_2_Update.MinimumSize = new System.Drawing.Size(110, 110);
            this.button_form_2_Update.Name = "button_form_2_Update";
            this.button_form_2_Update.Size = new System.Drawing.Size(110, 110);
            this.button_form_2_Update.TabIndex = 2;
            this.button_form_2_Update.UseVisualStyleBackColor = true;
            this.button_form_2_Update.Click += new System.EventHandler(this.button_form_2_Update_OnClick);
            // 
            // button_form_3_View
            // 
            this.button_form_3_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_3_View.BackgroundImage")));
            this.button_form_3_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_form_3_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_form_3_View.Location = new System.Drawing.Point(34, 216);
            this.button_form_3_View.MaximumSize = new System.Drawing.Size(110, 110);
            this.button_form_3_View.MinimumSize = new System.Drawing.Size(110, 110);
            this.button_form_3_View.Name = "button_form_3_View";
            this.button_form_3_View.Size = new System.Drawing.Size(110, 110);
            this.button_form_3_View.TabIndex = 3;
            this.button_form_3_View.UseVisualStyleBackColor = true;
            this.button_form_3_View.Click += new System.EventHandler(this.button_form_3_View_OnClick);
            // 
            // button_form_4_Delete
            // 
            this.button_form_4_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_form_4_Delete.BackgroundImage")));
            this.button_form_4_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_form_4_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_form_4_Delete.Location = new System.Drawing.Point(445, 216);
            this.button_form_4_Delete.MaximumSize = new System.Drawing.Size(110, 110);
            this.button_form_4_Delete.MinimumSize = new System.Drawing.Size(110, 110);
            this.button_form_4_Delete.Name = "button_form_4_Delete";
            this.button_form_4_Delete.Size = new System.Drawing.Size(110, 110);
            this.button_form_4_Delete.TabIndex = 4;
            this.button_form_4_Delete.UseVisualStyleBackColor = true;
            this.button_form_3_View.Click += new System.EventHandler(this.button_form_4_Delete_OnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button_form_4_Delete);
            this.Controls.Add(this.button_form_3_View);
            this.Controls.Add(this.button_form_2_Update);
            this.Controls.Add(this.button_form_1_Create);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Controls.SetChildIndex(this.label_status, 0);
            this.Controls.SetChildIndex(this.button_form_1_Create, 0);
            this.Controls.SetChildIndex(this.button_form_2_Update, 0);
            this.Controls.SetChildIndex(this.button_form_3_View, 0);
            this.Controls.SetChildIndex(this.button_form_4_Delete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_form_1_Create;
        private System.Windows.Forms.Button button_form_2_Update;
        private System.Windows.Forms.Button button_form_3_View;
        private System.Windows.Forms.Button button_form_4_Delete;
    }
}

