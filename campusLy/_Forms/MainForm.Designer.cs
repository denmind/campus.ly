
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
            this.button_formCreate = new System.Windows.Forms.Button();
            this.button_formUpdate = new System.Windows.Forms.Button();
            this.button_formView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_formCreate
            // 
            this.button_formCreate.Location = new System.Drawing.Point(22, 49);
            this.button_formCreate.Name = "button_formCreate";
            this.button_formCreate.Size = new System.Drawing.Size(224, 79);
            this.button_formCreate.TabIndex = 1;
            this.button_formCreate.Text = "Create new Student Info";
            this.button_formCreate.UseVisualStyleBackColor = true;
            this.button_formCreate.Click += new System.EventHandler(this.button_formCreate_OnClick);
            // 
            // button_formUpdate
            // 
            this.button_formUpdate.Location = new System.Drawing.Point(288, 49);
            this.button_formUpdate.Name = "button_formUpdate";
            this.button_formUpdate.Size = new System.Drawing.Size(198, 79);
            this.button_formUpdate.TabIndex = 2;
            this.button_formUpdate.Text = "Edit existing Student Info";
            this.button_formUpdate.UseVisualStyleBackColor = true;
            this.button_formUpdate.Click += new System.EventHandler(this.button_formUpdate_OnClick);
            // 
            // button_formView
            // 
            this.button_formView.Location = new System.Drawing.Point(153, 154);
            this.button_formView.Name = "button_formView";
            this.button_formView.Size = new System.Drawing.Size(198, 79);
            this.button_formView.TabIndex = 3;
            this.button_formView.Text = "View all Student Records";
            this.button_formView.UseVisualStyleBackColor = true;
            this.button_formView.Click += new System.EventHandler(this.button_formView_OnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 282);
            this.Controls.Add(this.button_formView);
            this.Controls.Add(this.button_formUpdate);
            this.Controls.Add(this.button_formCreate);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(528, 321);
            this.MinimumSize = new System.Drawing.Size(528, 321);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Controls.SetChildIndex(this.label_status, 0);
            this.Controls.SetChildIndex(this.button_formCreate, 0);
            this.Controls.SetChildIndex(this.button_formUpdate, 0);
            this.Controls.SetChildIndex(this.button_formView, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_formCreate;
        private System.Windows.Forms.Button button_formUpdate;
        private System.Windows.Forms.Button button_formView;
    }
}

