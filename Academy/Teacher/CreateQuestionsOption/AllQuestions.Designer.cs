namespace Academy.Teacher
{
    partial class AllQuestions
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
            this.AllQuestionsView = new System.Windows.Forms.DataGridView();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddAnswers = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EditQuestion = new System.Windows.Forms.Button();
            this.DeleteQuestion = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllQuestionsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllQuestionsView
            // 
            this.AllQuestionsView.BackgroundColor = System.Drawing.Color.White;
            this.AllQuestionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllQuestionsView.Location = new System.Drawing.Point(111, 118);
            this.AllQuestionsView.Margin = new System.Windows.Forms.Padding(4);
            this.AllQuestionsView.Name = "AllQuestionsView";
            this.AllQuestionsView.ReadOnly = true;
            this.AllQuestionsView.Size = new System.Drawing.Size(717, 228);
            this.AllQuestionsView.TabIndex = 0;
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(111, 381);
            this.AddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(240, 43);
            this.AddQuestion.TabIndex = 1;
            this.AddQuestion.Text = "Add Question";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(776, 459);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(240, 43);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddAnswers
            // 
            this.AddAnswers.Location = new System.Drawing.Point(397, 459);
            this.AddAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.AddAnswers.Name = "AddAnswers";
            this.AddAnswers.Size = new System.Drawing.Size(240, 43);
            this.AddAnswers.TabIndex = 3;
            this.AddAnswers.Text = "Add Answers";
            this.AddAnswers.UseVisualStyleBackColor = true;
            this.AddAnswers.Click += new System.EventHandler(this.AddAnswers_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(860, 203);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(156, 43);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EditQuestion
            // 
            this.EditQuestion.Location = new System.Drawing.Point(397, 381);
            this.EditQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.EditQuestion.Name = "EditQuestion";
            this.EditQuestion.Size = new System.Drawing.Size(240, 43);
            this.EditQuestion.TabIndex = 6;
            this.EditQuestion.Text = "Edit Question";
            this.EditQuestion.UseVisualStyleBackColor = true;
            this.EditQuestion.Click += new System.EventHandler(this.EditQuestion_Click);
            // 
            // DeleteQuestion
            // 
            this.DeleteQuestion.Location = new System.Drawing.Point(111, 459);
            this.DeleteQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteQuestion.Name = "DeleteQuestion";
            this.DeleteQuestion.Size = new System.Drawing.Size(240, 43);
            this.DeleteQuestion.TabIndex = 7;
            this.DeleteQuestion.Text = "Delete Question";
            this.DeleteQuestion.UseVisualStyleBackColor = true;
            this.DeleteQuestion.Click += new System.EventHandler(this.DeleteQuestion_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(115, 61);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(110, 20);
            this.Info.TabIndex = 8;
            this.Info.Text = "All questions:";
            // 
            // AllQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.DeleteQuestion);
            this.Controls.Add(this.EditQuestion);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddAnswers);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.AllQuestionsView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllQuestions";
            this.Text = "AllQuestions";
            this.Load += new System.EventHandler(this.AllQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllQuestionsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllQuestionsView;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AddAnswers;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button EditQuestion;
        private System.Windows.Forms.Button DeleteQuestion;
        private System.Windows.Forms.Label Info;
    }
}