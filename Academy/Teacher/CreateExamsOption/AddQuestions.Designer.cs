namespace Academy.Teacher.CreateExamsOption
{
    partial class AddQuestions
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
            this.Back = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddedQuestions = new System.Windows.Forms.DataGridView();
            this.AllQuestions = new System.Windows.Forms.DataGridView();
            this.ExamName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(721, 455);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(248, 38);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(855, 290);
            this.Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(114, 38);
            this.Remove.TabIndex = 17;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(854, 186);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 38);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Added questions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose questions:";
            // 
            // AddedQuestions
            // 
            this.AddedQuestions.BackgroundColor = System.Drawing.Color.White;
            this.AddedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedQuestions.Location = new System.Drawing.Point(32, 290);
            this.AddedQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.AddedQuestions.Name = "AddedQuestions";
            this.AddedQuestions.ReadOnly = true;
            this.AddedQuestions.Size = new System.Drawing.Size(795, 113);
            this.AddedQuestions.TabIndex = 13;
            // 
            // AllQuestions
            // 
            this.AllQuestions.BackgroundColor = System.Drawing.Color.White;
            this.AllQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllQuestions.Location = new System.Drawing.Point(31, 113);
            this.AllQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.AllQuestions.Name = "AllQuestions";
            this.AllQuestions.ReadOnly = true;
            this.AllQuestions.Size = new System.Drawing.Size(796, 111);
            this.AllQuestions.TabIndex = 12;
            // 
            // ExamName
            // 
            this.ExamName.AutoSize = true;
            this.ExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamName.Location = new System.Drawing.Point(29, 40);
            this.ExamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExamName.Name = "ExamName";
            this.ExamName.Size = new System.Drawing.Size(100, 20);
            this.ExamName.TabIndex = 11;
            this.ExamName.Text = "Exam Name";
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 540);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddedQuestions);
            this.Controls.Add(this.AllQuestions);
            this.Controls.Add(this.ExamName);
            this.Name = "AddQuestions";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.AddQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AddedQuestions;
        private System.Windows.Forms.DataGridView AllQuestions;
        private System.Windows.Forms.Label ExamName;
    }
}