namespace Academy.Admin
{
    partial class CreateSubjectDialog
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
            this.TeachersView = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.Label();
            this.TeacherId = new System.Windows.Forms.Label();
            this.SubjName = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.CreateSubj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersView
            // 
            this.TeachersView.BackgroundColor = System.Drawing.Color.White;
            this.TeachersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersView.Location = new System.Drawing.Point(68, 168);
            this.TeachersView.Name = "TeachersView";
            this.TeachersView.ReadOnly = true;
            this.TeachersView.RowTemplate.Height = 24;
            this.TeachersView.Size = new System.Drawing.Size(492, 129);
            this.TeachersView.TabIndex = 0;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSize = true;
            this.SubjectName.Location = new System.Drawing.Point(65, 52);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(146, 17);
            this.SubjectName.TabIndex = 1;
            this.SubjectName.Text = "Enter a subject name:";
            // 
            // TeacherId
            // 
            this.TeacherId.AutoSize = true;
            this.TeacherId.Location = new System.Drawing.Point(68, 111);
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Size = new System.Drawing.Size(201, 17);
            this.TeacherId.TabIndex = 2;
            this.TeacherId.Text = "Appoint a teacher from the list:";
            // 
            // SubjName
            // 
            this.SubjName.Location = new System.Drawing.Point(261, 52);
            this.SubjName.Name = "SubjName";
            this.SubjName.Size = new System.Drawing.Size(299, 22);
            this.SubjName.TabIndex = 3;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(359, 356);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(171, 38);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateSubj
            // 
            this.CreateSubj.Location = new System.Drawing.Point(87, 356);
            this.CreateSubj.Name = "CreateSubj";
            this.CreateSubj.Size = new System.Drawing.Size(171, 38);
            this.CreateSubj.TabIndex = 6;
            this.CreateSubj.Text = "Save";
            this.CreateSubj.UseVisualStyleBackColor = true;
            this.CreateSubj.Click += new System.EventHandler(this.CreateSubj_Click);
            // 
            // CreateSubjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 475);
            this.Controls.Add(this.CreateSubj);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SubjName);
            this.Controls.Add(this.TeacherId);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.TeachersView);
            this.Name = "CreateSubjectDialog";
            this.Text = "CreateSubject";
            this.Load += new System.EventHandler(this.CreateSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeachersView;
        private System.Windows.Forms.Label SubjectName;
        private System.Windows.Forms.Label TeacherId;
        private System.Windows.Forms.TextBox SubjName;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button CreateSubj;
    }
}