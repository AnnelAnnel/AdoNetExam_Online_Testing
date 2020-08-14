namespace Academy
{
    partial class Teachermenu
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
            this.Greeting = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SeeExams = new System.Windows.Forms.Button();
            this.ExamMarks = new System.Windows.Forms.Button();
            this.CreateQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting.Location = new System.Drawing.Point(293, 54);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(95, 25);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Welcome";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(163, 338);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(443, 48);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SeeExams
            // 
            this.SeeExams.Location = new System.Drawing.Point(163, 127);
            this.SeeExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeExams.Name = "SeeExams";
            this.SeeExams.Size = new System.Drawing.Size(443, 46);
            this.SeeExams.TabIndex = 2;
            this.SeeExams.Text = "See All Exams";
            this.SeeExams.UseVisualStyleBackColor = true;
            this.SeeExams.Click += new System.EventHandler(this.SeeExams_Click);
            // 
            // ExamMarks
            // 
            this.ExamMarks.Location = new System.Drawing.Point(163, 269);
            this.ExamMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExamMarks.Name = "ExamMarks";
            this.ExamMarks.Size = new System.Drawing.Size(443, 46);
            this.ExamMarks.TabIndex = 3;
            this.ExamMarks.Text = "See Exam Marks";
            this.ExamMarks.UseVisualStyleBackColor = true;
            this.ExamMarks.Click += new System.EventHandler(this.ExamMarks_Click);
            // 
            // CreateQuestions
            // 
            this.CreateQuestions.Location = new System.Drawing.Point(163, 201);
            this.CreateQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateQuestions.Name = "CreateQuestions";
            this.CreateQuestions.Size = new System.Drawing.Size(443, 46);
            this.CreateQuestions.TabIndex = 4;
            this.CreateQuestions.Text = "Create Questions";
            this.CreateQuestions.UseVisualStyleBackColor = true;
            this.CreateQuestions.Click += new System.EventHandler(this.CreateQuestions_Click);
            // 
            // Teachermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.CreateQuestions);
            this.Controls.Add(this.ExamMarks);
            this.Controls.Add(this.SeeExams);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Greeting);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Teachermenu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Teachermenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SeeExams;
        private System.Windows.Forms.Button ExamMarks;
        private System.Windows.Forms.Button CreateQuestions;
    }
}