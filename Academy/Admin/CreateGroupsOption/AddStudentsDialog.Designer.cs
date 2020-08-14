namespace Academy.Admin.CreateGroupsOption
{
    partial class AddStudentsDialog
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
            this.GroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentsChoiceView = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.AddedStudents = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChoiceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group name:";
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(179, 51);
            this.GroupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Size = new System.Drawing.Size(389, 22);
            this.GroupName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose students:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentsChoiceView
            // 
            this.StudentsChoiceView.BackgroundColor = System.Drawing.Color.White;
            this.StudentsChoiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsChoiceView.Location = new System.Drawing.Point(69, 117);
            this.StudentsChoiceView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentsChoiceView.Name = "StudentsChoiceView";
            this.StudentsChoiceView.Size = new System.Drawing.Size(328, 352);
            this.StudentsChoiceView.TabIndex = 3;
            this.StudentsChoiceView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsChoiceView_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(432, 223);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 33);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddedStudents
            // 
            this.AddedStudents.BackgroundColor = System.Drawing.Color.White;
            this.AddedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedStudents.Location = new System.Drawing.Point(645, 117);
            this.AddedStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedStudents.Name = "AddedStudents";
            this.AddedStudents.Size = new System.Drawing.Size(324, 352);
            this.AddedStudents.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(432, 545);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cancel.Size = new System.Drawing.Size(169, 33);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Back";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(432, 322);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(169, 33);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(641, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Added students:";
            // 
            // AddStudentsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddedStudents);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.StudentsChoiceView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudentsDialog";
            this.Text = "AddStudents";
            this.Load += new System.EventHandler(this.CreateGroupDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChoiceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StudentsChoiceView;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView AddedStudents;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label3;
    }
}