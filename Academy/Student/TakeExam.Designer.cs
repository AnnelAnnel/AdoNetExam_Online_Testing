namespace Academy.Student
{
    partial class TakeExam
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
            this.QuestionGroup = new System.Windows.Forms.GroupBox();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.QuestionText = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.EndTest = new System.Windows.Forms.Button();
            this.NextQuestion = new System.Windows.Forms.Button();
            this.QuestionsCount = new System.Windows.Forms.Label();
            this.ExamInfo = new System.Windows.Forms.Label();
            this.StartExam = new System.Windows.Forms.Button();
            this.QuestionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionGroup
            // 
            this.QuestionGroup.Controls.Add(this.Answer4);
            this.QuestionGroup.Controls.Add(this.Answer3);
            this.QuestionGroup.Controls.Add(this.Answer2);
            this.QuestionGroup.Controls.Add(this.Answer1);
            this.QuestionGroup.Controls.Add(this.QuestionText);
            this.QuestionGroup.Location = new System.Drawing.Point(86, 212);
            this.QuestionGroup.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionGroup.Name = "QuestionGroup";
            this.QuestionGroup.Padding = new System.Windows.Forms.Padding(4);
            this.QuestionGroup.Size = new System.Drawing.Size(931, 310);
            this.QuestionGroup.TabIndex = 20;
            this.QuestionGroup.TabStop = false;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(489, 259);
            this.Answer4.Margin = new System.Windows.Forms.Padding(4);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(110, 21);
            this.Answer4.TabIndex = 6;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "radioButton4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.CheckedChanged += new System.EventHandler(this.Answer4_CheckedChanged);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(489, 172);
            this.Answer3.Margin = new System.Windows.Forms.Padding(4);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(110, 21);
            this.Answer3.TabIndex = 5;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.CheckedChanged += new System.EventHandler(this.Answer3_CheckedChanged);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(28, 259);
            this.Answer2.Margin = new System.Windows.Forms.Padding(4);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(110, 21);
            this.Answer2.TabIndex = 4;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.CheckedChanged += new System.EventHandler(this.Answer2_CheckedChanged);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(28, 172);
            this.Answer1.Margin = new System.Windows.Forms.Padding(4);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(110, 21);
            this.Answer1.TabIndex = 3;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.CheckedChanged += new System.EventHandler(this.Answer1_CheckedChanged);
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(28, 69);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(46, 17);
            this.QuestionText.TabIndex = 15;
            this.QuestionText.Text = "label3";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(99, 575);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 50);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // EndTest
            // 
            this.EndTest.Location = new System.Drawing.Point(650, 575);
            this.EndTest.Margin = new System.Windows.Forms.Padding(4);
            this.EndTest.Name = "EndTest";
            this.EndTest.Size = new System.Drawing.Size(163, 50);
            this.EndTest.TabIndex = 18;
            this.EndTest.Text = "SubmitTest";
            this.EndTest.UseVisualStyleBackColor = true;
            this.EndTest.Click += new System.EventHandler(this.EndTest_Click_1);
            // 
            // NextQuestion
            // 
            this.NextQuestion.Location = new System.Drawing.Point(854, 575);
            this.NextQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.NextQuestion.Name = "NextQuestion";
            this.NextQuestion.Size = new System.Drawing.Size(163, 50);
            this.NextQuestion.TabIndex = 17;
            this.NextQuestion.Text = "Next";
            this.NextQuestion.UseVisualStyleBackColor = true;
            this.NextQuestion.Click += new System.EventHandler(this.NextQuestion_Click_1);
            // 
            // QuestionsCount
            // 
            this.QuestionsCount.AutoSize = true;
            this.QuestionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsCount.Location = new System.Drawing.Point(870, 87);
            this.QuestionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionsCount.Name = "QuestionsCount";
            this.QuestionsCount.Size = new System.Drawing.Size(46, 18);
            this.QuestionsCount.TabIndex = 14;
            this.QuestionsCount.Text = "label2";
            // 
            // ExamInfo
            // 
            this.ExamInfo.AutoSize = true;
            this.ExamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamInfo.Location = new System.Drawing.Point(114, 87);
            this.ExamInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExamInfo.Name = "ExamInfo";
            this.ExamInfo.Size = new System.Drawing.Size(46, 18);
            this.ExamInfo.TabIndex = 13;
            this.ExamInfo.Text = "label1";
            // 
            // StartExam
            // 
            this.StartExam.Location = new System.Drawing.Point(776, 148);
            this.StartExam.Name = "StartExam";
            this.StartExam.Size = new System.Drawing.Size(222, 34);
            this.StartExam.TabIndex = 21;
            this.StartExam.Text = "Start Exam";
            this.StartExam.UseVisualStyleBackColor = true;
            this.StartExam.Click += new System.EventHandler(this.StartExam_Click);
            // 
            // TakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 713);
            this.Controls.Add(this.StartExam);
            this.Controls.Add(this.QuestionGroup);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EndTest);
            this.Controls.Add(this.NextQuestion);
            this.Controls.Add(this.QuestionsCount);
            this.Controls.Add(this.ExamInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TakeExam";
            this.Text = "TakeExam";
            this.Load += new System.EventHandler(this.TakeExam_Load);
            this.QuestionGroup.ResumeLayout(false);
            this.QuestionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox QuestionGroup;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EndTest;
        private System.Windows.Forms.Button NextQuestion;
        private System.Windows.Forms.Label QuestionsCount;
        private System.Windows.Forms.Label ExamInfo;
        private System.Windows.Forms.Button StartExam;
    }
}