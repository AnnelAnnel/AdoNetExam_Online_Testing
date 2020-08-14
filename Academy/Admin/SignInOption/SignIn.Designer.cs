namespace Academy
{
    partial class SignIn
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
            this.AllUsers = new System.Windows.Forms.Label();
            this.AllUsersView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.UpdateView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsers
            // 
            this.AllUsers.AutoSize = true;
            this.AllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllUsers.Location = new System.Drawing.Point(79, 43);
            this.AllUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(93, 25);
            this.AllUsers.TabIndex = 0;
            this.AllUsers.Text = "All users:";
            // 
            // AllUsersView
            // 
            this.AllUsersView.BackgroundColor = System.Drawing.Color.White;
            this.AllUsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersView.Location = new System.Drawing.Point(77, 86);
            this.AllUsersView.Margin = new System.Windows.Forms.Padding(4);
            this.AllUsersView.Name = "AllUsersView";
            this.AllUsersView.Size = new System.Drawing.Size(655, 313);
            this.AllUsersView.TabIndex = 1;
            this.AllUsersView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllUsersView_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(824, 362);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(176, 37);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(83, 457);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(176, 37);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(296, 457);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(176, 37);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(505, 457);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(176, 37);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpdateView
            // 
            this.UpdateView.Location = new System.Drawing.Point(824, 292);
            this.UpdateView.Name = "UpdateView";
            this.UpdateView.Size = new System.Drawing.Size(176, 39);
            this.UpdateView.TabIndex = 6;
            this.UpdateView.Text = "Update View";
            this.UpdateView.UseVisualStyleBackColor = true;
            this.UpdateView.Click += new System.EventHandler(this.UpdateView_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.UpdateView);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AllUsersView);
            this.Controls.Add(this.AllUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllUsers;
        private System.Windows.Forms.DataGridView AllUsersView;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button UpdateView;
    }
}