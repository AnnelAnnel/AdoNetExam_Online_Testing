namespace Academy.Admin.CreateSubjesctsOption
{
    partial class EditSubjectDialog
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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.TeachersBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(126, 291);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(199, 54);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(432, 291);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(199, 54);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher:";
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(282, 70);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(349, 22);
            this.SNameTextBox.TabIndex = 4;
            // 
            // TeachersBox
            // 
            this.TeachersBox.FormattingEnabled = true;
            this.TeachersBox.Location = new System.Drawing.Point(282, 176);
            this.TeachersBox.Name = "TeachersBox";
            this.TeachersBox.Size = new System.Drawing.Size(349, 24);
            this.TeachersBox.TabIndex = 5;
            // 
            // EditSubjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeachersBox);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Name = "EditSubjectDialog";
            this.Text = "EditSubjectDialog";
            this.Load += new System.EventHandler(this.EditSubjectDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.ComboBox TeachersBox;
    }
}