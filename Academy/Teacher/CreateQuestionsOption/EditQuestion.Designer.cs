namespace Academy.Teacher.CreateQuestionsOption
{
    partial class EditQuestion
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.SubjectsView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(520, 333);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(116, 37);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(170, 333);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(116, 37);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // QuestionText
            // 
            this.QuestionText.BackColor = System.Drawing.Color.White;
            this.QuestionText.Location = new System.Drawing.Point(170, 170);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuestionText.Multiline = true;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(467, 107);
            this.QuestionText.TabIndex = 10;
            this.QuestionText.TextChanged += new System.EventHandler(this.QuestionText_TextChanged);
            // 
            // SubjectsView
            // 
            this.SubjectsView.BackgroundColor = System.Drawing.Color.White;
            this.SubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsView.GridColor = System.Drawing.Color.AntiqueWhite;
            this.SubjectsView.Location = new System.Drawing.Point(170, 35);
            this.SubjectsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubjectsView.Name = "SubjectsView";
            this.SubjectsView.ReadOnly = true;
            this.SubjectsView.RowTemplate.Height = 24;
            this.SubjectsView.Size = new System.Drawing.Size(466, 110);
            this.SubjectsView.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Question text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose a subject:";
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 408);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.SubjectsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditQuestion";
            this.Text = "EditQuestion";
            this.Load += new System.EventHandler(this.EditQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.DataGridView SubjectsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}