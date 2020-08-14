namespace Academy.Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.PassExam = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ExamsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Exams on the subject:";
            // 
            // PassExam
            // 
            this.PassExam.Location = new System.Drawing.Point(111, 302);
            this.PassExam.Name = "PassExam";
            this.PassExam.Size = new System.Drawing.Size(205, 43);
            this.PassExam.TabIndex = 14;
            this.PassExam.Text = "Pass";
            this.PassExam.UseVisualStyleBackColor = true;
            this.PassExam.Click += new System.EventHandler(this.PassExam_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(488, 302);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(205, 43);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ExamsView
            // 
            this.ExamsView.BackgroundColor = System.Drawing.Color.White;
            this.ExamsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsView.Location = new System.Drawing.Point(111, 144);
            this.ExamsView.Name = "ExamsView";
            this.ExamsView.RowTemplate.Height = 24;
            this.ExamsView.Size = new System.Drawing.Size(582, 122);
            this.ExamsView.TabIndex = 12;
            // 
            // AllExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassExam);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExamsView);
            this.Name = "AllExams";
            this.Text = "AllExams";
            this.Load += new System.EventHandler(this.AllExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PassExam;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView ExamsView;
    }
}