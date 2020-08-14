namespace Academy
{
    partial class StudentMenu
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
            this.Exit = new System.Windows.Forms.Button();
            this.Greeting = new System.Windows.Forms.Label();
            this.PassExams = new System.Windows.Forms.Button();
            this.SeeMarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(205, 309);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(370, 43);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting.Location = new System.Drawing.Point(275, 65);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(53, 20);
            this.Greeting.TabIndex = 3;
            this.Greeting.Text = "label1";
            // 
            // PassExams
            // 
            this.PassExams.Location = new System.Drawing.Point(205, 145);
            this.PassExams.Name = "PassExams";
            this.PassExams.Size = new System.Drawing.Size(370, 43);
            this.PassExams.TabIndex = 4;
            this.PassExams.Text = "All Exams";
            this.PassExams.UseVisualStyleBackColor = true;
            this.PassExams.Click += new System.EventHandler(this.PassExams_Click);
            // 
            // SeeMarks
            // 
            this.SeeMarks.Location = new System.Drawing.Point(205, 227);
            this.SeeMarks.Name = "SeeMarks";
            this.SeeMarks.Size = new System.Drawing.Size(370, 43);
            this.SeeMarks.TabIndex = 5;
            this.SeeMarks.Text = "See Marks";
            this.SeeMarks.UseVisualStyleBackColor = true;
            this.SeeMarks.Click += new System.EventHandler(this.SeeMarks_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeeMarks);
            this.Controls.Add(this.PassExams);
            this.Controls.Add(this.Greeting);
            this.Controls.Add(this.Exit);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button PassExams;
        private System.Windows.Forms.Button SeeMarks;
    }
}