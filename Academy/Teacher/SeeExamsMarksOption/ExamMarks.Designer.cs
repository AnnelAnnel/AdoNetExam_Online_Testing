namespace Academy.Teacher.SeeExamsMarksOption
{
    partial class ExamMarks
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
            this.ExamsView = new System.Windows.Forms.DataGridView();
            this.GroupsView = new System.Windows.Forms.DataGridView();
            this.MarksView = new System.Windows.Forms.DataGridView();
            this.ShowMarksBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamMarksInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamsView
            // 
            this.ExamsView.BackgroundColor = System.Drawing.Color.White;
            this.ExamsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExamsView.Location = new System.Drawing.Point(62, 85);
            this.ExamsView.Name = "ExamsView";
            this.ExamsView.ReadOnly = true;
            this.ExamsView.RowTemplate.Height = 24;
            this.ExamsView.Size = new System.Drawing.Size(405, 101);
            this.ExamsView.TabIndex = 0;
            // 
            // GroupsView
            // 
            this.GroupsView.BackgroundColor = System.Drawing.Color.White;
            this.GroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsView.Location = new System.Drawing.Point(508, 85);
            this.GroupsView.Name = "GroupsView";
            this.GroupsView.RowTemplate.Height = 24;
            this.GroupsView.Size = new System.Drawing.Size(405, 101);
            this.GroupsView.TabIndex = 1;
            // 
            // MarksView
            // 
            this.MarksView.BackgroundColor = System.Drawing.Color.White;
            this.MarksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksView.Location = new System.Drawing.Point(62, 254);
            this.MarksView.Name = "MarksView";
            this.MarksView.RowTemplate.Height = 24;
            this.MarksView.Size = new System.Drawing.Size(851, 169);
            this.MarksView.TabIndex = 2;
            // 
            // ShowMarksBtn
            // 
            this.ShowMarksBtn.Location = new System.Drawing.Point(177, 466);
            this.ShowMarksBtn.Name = "ShowMarksBtn";
            this.ShowMarksBtn.Size = new System.Drawing.Size(222, 46);
            this.ShowMarksBtn.TabIndex = 3;
            this.ShowMarksBtn.Text = "Show Marks";
            this.ShowMarksBtn.UseVisualStyleBackColor = true;
            this.ShowMarksBtn.Click += new System.EventHandler(this.ShowMarksBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(576, 466);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(222, 46);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select an exam:";
            // 
            // ExamMarksInfo
            // 
            this.ExamMarksInfo.AutoSize = true;
            this.ExamMarksInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamMarksInfo.Location = new System.Drawing.Point(68, 213);
            this.ExamMarksInfo.Name = "ExamMarksInfo";
            this.ExamMarksInfo.Size = new System.Drawing.Size(213, 20);
            this.ExamMarksInfo.TabIndex = 6;
            this.ExamMarksInfo.Text = "Marks will be shown below:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(505, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a group:";
            // 
            // ExamMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExamMarksInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ShowMarksBtn);
            this.Controls.Add(this.MarksView);
            this.Controls.Add(this.GroupsView);
            this.Controls.Add(this.ExamsView);
            this.Name = "ExamMarks";
            this.Text = "ExamMarks";
            this.Load += new System.EventHandler(this.ExamMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamsView;
        private System.Windows.Forms.DataGridView GroupsView;
        private System.Windows.Forms.DataGridView MarksView;
        private System.Windows.Forms.Button ShowMarksBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExamMarksInfo;
        private System.Windows.Forms.Label label3;
    }
}