namespace Academy.Teacher.CreateExamsOption
{
    partial class AllExams
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
            this.TeacherName = new System.Windows.Forms.Label();
            this.ExamsView = new System.Windows.Forms.DataGridView();
            this.CreateExam = new System.Windows.Forms.Button();
            this.EditExam = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddQuestions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherName.Location = new System.Drawing.Point(59, 50);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(195, 20);
            this.TeacherName.TabIndex = 0;
            this.TeacherName.Text = "All exams of the teacher:";
            // 
            // ExamsView
            // 
            this.ExamsView.BackgroundColor = System.Drawing.Color.White;
            this.ExamsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsView.Location = new System.Drawing.Point(61, 103);
            this.ExamsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExamsView.Name = "ExamsView";
            this.ExamsView.ReadOnly = true;
            this.ExamsView.RowTemplate.Height = 24;
            this.ExamsView.Size = new System.Drawing.Size(493, 162);
            this.ExamsView.TabIndex = 1;
            // 
            // CreateExam
            // 
            this.CreateExam.Location = new System.Drawing.Point(61, 319);
            this.CreateExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateExam.Name = "CreateExam";
            this.CreateExam.Size = new System.Drawing.Size(197, 38);
            this.CreateExam.TabIndex = 2;
            this.CreateExam.Text = "Create New";
            this.CreateExam.UseVisualStyleBackColor = true;
            this.CreateExam.Click += new System.EventHandler(this.CreateExam_Click);
            // 
            // EditExam
            // 
            this.EditExam.Location = new System.Drawing.Point(299, 319);
            this.EditExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditExam.Name = "EditExam";
            this.EditExam.Size = new System.Drawing.Size(197, 38);
            this.EditExam.TabIndex = 3;
            this.EditExam.Text = "Edit";
            this.EditExam.UseVisualStyleBackColor = true;
            this.EditExam.Click += new System.EventHandler(this.EcitExam_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(561, 380);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(197, 38);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(618, 170);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(140, 38);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(62, 380);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 38);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddQuestions
            // 
            this.AddQuestions.Location = new System.Drawing.Point(299, 380);
            this.AddQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddQuestions.Name = "AddQuestions";
            this.AddQuestions.Size = new System.Drawing.Size(197, 38);
            this.AddQuestions.TabIndex = 7;
            this.AddQuestions.Text = "Add Questions";
            this.AddQuestions.UseVisualStyleBackColor = true;
            this.AddQuestions.Click += new System.EventHandler(this.AddQuestions_Click);
            // 
            // AllExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddQuestions);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditExam);
            this.Controls.Add(this.CreateExam);
            this.Controls.Add(this.ExamsView);
            this.Controls.Add(this.TeacherName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllExams";
            this.Text = "AllExams";
            this.Load += new System.EventHandler(this.AllExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeacherName;
        private System.Windows.Forms.DataGridView ExamsView;
        private System.Windows.Forms.Button CreateExam;
        private System.Windows.Forms.Button EditExam;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddQuestions;
    }
}