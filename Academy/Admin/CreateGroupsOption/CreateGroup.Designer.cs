namespace Academy.Admin
{
    partial class CreateGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.GroupsView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.StudentsOfGroupView = new System.Windows.Forms.DataGridView();
            this.AddStudents = new System.Windows.Forms.Button();
            this.AddSubjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsOfGroupView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "All groups:";
            // 
            // GroupsView
            // 
            this.GroupsView.BackgroundColor = System.Drawing.Color.White;
            this.GroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsView.Location = new System.Drawing.Point(53, 87);
            this.GroupsView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupsView.Name = "GroupsView";
            this.GroupsView.Size = new System.Drawing.Size(449, 220);
            this.GroupsView.TabIndex = 1;
            this.GroupsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(555, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students of the group:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(53, 342);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(199, 36);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(53, 401);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(199, 36);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(304, 342);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(199, 36);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(809, 420);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(199, 36);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(304, 401);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(199, 36);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // StudentsOfGroupView
            // 
            this.StudentsOfGroupView.BackgroundColor = System.Drawing.Color.White;
            this.StudentsOfGroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsOfGroupView.Location = new System.Drawing.Point(559, 87);
            this.StudentsOfGroupView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentsOfGroupView.Name = "StudentsOfGroupView";
            this.StudentsOfGroupView.Size = new System.Drawing.Size(449, 290);
            this.StudentsOfGroupView.TabIndex = 9;
            this.StudentsOfGroupView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsOfGroupView_CellContentClick);
            // 
            // AddStudents
            // 
            this.AddStudents.Location = new System.Drawing.Point(559, 420);
            this.AddStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStudents.Name = "AddStudents";
            this.AddStudents.Size = new System.Drawing.Size(199, 36);
            this.AddStudents.TabIndex = 10;
            this.AddStudents.Text = "Add Students";
            this.AddStudents.UseVisualStyleBackColor = true;
            this.AddStudents.Click += new System.EventHandler(this.AddStudents_Click);
            // 
            // AddSubjects
            // 
            this.AddSubjects.Location = new System.Drawing.Point(559, 474);
            this.AddSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSubjects.Name = "AddSubjects";
            this.AddSubjects.Size = new System.Drawing.Size(199, 36);
            this.AddSubjects.TabIndex = 11;
            this.AddSubjects.Text = "Add Subjects";
            this.AddSubjects.UseVisualStyleBackColor = true;
            this.AddSubjects.Click += new System.EventHandler(this.AddSubjects_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AddSubjects);
            this.Controls.Add(this.AddStudents);
            this.Controls.Add(this.StudentsOfGroupView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupsView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsOfGroupView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GroupsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView StudentsOfGroupView;
        private System.Windows.Forms.Button AddStudents;
        private System.Windows.Forms.Button AddSubjects;
    }
}