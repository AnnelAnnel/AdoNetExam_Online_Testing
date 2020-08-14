namespace Academy.Student
{
    partial class PassExams
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
            this.SubjectsView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowExams = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsView
            // 
            this.SubjectsView.BackgroundColor = System.Drawing.Color.White;
            this.SubjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsView.Location = new System.Drawing.Point(107, 94);
            this.SubjectsView.Name = "SubjectsView";
            this.SubjectsView.RowTemplate.Height = 24;
            this.SubjectsView.Size = new System.Drawing.Size(559, 148);
            this.SubjectsView.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select a subject:";
            // 
            // ShowExams
            // 
            this.ShowExams.Location = new System.Drawing.Point(107, 295);
            this.ShowExams.Name = "ShowExams";
            this.ShowExams.Size = new System.Drawing.Size(205, 43);
            this.ShowExams.TabIndex = 10;
            this.ShowExams.Text = "Show exams";
            this.ShowExams.UseVisualStyleBackColor = true;
            this.ShowExams.Click += new System.EventHandler(this.ShowExams_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(461, 295);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(205, 43);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PassExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 436);
            this.Controls.Add(this.ShowExams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectsView);
            this.Controls.Add(this.Exit);
            this.Name = "PassExams";
            this.Text = "PassExamsOption";
            this.Load += new System.EventHandler(this.PassExamsOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SubjectsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowExams;
        private System.Windows.Forms.Button Exit;
    }
}