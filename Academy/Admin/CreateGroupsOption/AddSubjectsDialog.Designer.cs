namespace Academy.Admin.CreateGroupsOption
{
    partial class AddSubjectsDialog
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
            this.AllSubjects = new System.Windows.Forms.DataGridView();
            this.AddedSubjects = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.GroupName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name:";
            // 
            // AllSubjects
            // 
            this.AllSubjects.BackgroundColor = System.Drawing.Color.White;
            this.AllSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSubjects.Location = new System.Drawing.Point(71, 146);
            this.AllSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllSubjects.Name = "AllSubjects";
            this.AllSubjects.Size = new System.Drawing.Size(353, 193);
            this.AllSubjects.TabIndex = 1;
            // 
            // AddedSubjects
            // 
            this.AddedSubjects.BackgroundColor = System.Drawing.Color.White;
            this.AddedSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedSubjects.Location = new System.Drawing.Point(657, 146);
            this.AddedSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedSubjects.Name = "AddedSubjects";
            this.AddedSubjects.Size = new System.Drawing.Size(353, 193);
            this.AddedSubjects.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose subjects:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(653, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Added Subjects:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(463, 185);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 38);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(463, 271);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(149, 38);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(463, 428);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(149, 38);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(197, 41);
            this.GroupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Size = new System.Drawing.Size(304, 22);
            this.GroupName.TabIndex = 10;
            // 
            // AddSubjectsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddedSubjects);
            this.Controls.Add(this.AllSubjects);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSubjectsDialog";
            this.Text = "AddSubjectsDialog";
            this.Load += new System.EventHandler(this.AddSubjectsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllSubjects;
        private System.Windows.Forms.DataGridView AddedSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox GroupName;
    }
}