namespace Academy
{
    partial class AdminMenu
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
            this.Greeting = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.CreateSubject = new System.Windows.Forms.Button();
            this.CreateGroup = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greeting.Location = new System.Drawing.Point(441, 85);
            this.Greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(95, 25);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Welcome";
            this.Greeting.Click += new System.EventHandler(this.Greeting_Click);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(320, 148);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(439, 46);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign Up New Users";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // CreateSubject
            // 
            this.CreateSubject.Location = new System.Drawing.Point(320, 230);
            this.CreateSubject.Margin = new System.Windows.Forms.Padding(4);
            this.CreateSubject.Name = "CreateSubject";
            this.CreateSubject.Size = new System.Drawing.Size(439, 46);
            this.CreateSubject.TabIndex = 2;
            this.CreateSubject.Text = "Create Subjects";
            this.CreateSubject.UseVisualStyleBackColor = true;
            this.CreateSubject.Click += new System.EventHandler(this.CreateSubject_Click);
            // 
            // CreateGroup
            // 
            this.CreateGroup.Location = new System.Drawing.Point(320, 308);
            this.CreateGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Size = new System.Drawing.Size(439, 46);
            this.CreateGroup.TabIndex = 3;
            this.CreateGroup.Text = "Create Groups";
            this.CreateGroup.UseVisualStyleBackColor = true;
            this.CreateGroup.Click += new System.EventHandler(this.CreateGroup_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(320, 390);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(439, 46);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CreateGroup);
            this.Controls.Add(this.CreateSubject);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Greeting);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button CreateSubject;
        private System.Windows.Forms.Button CreateGroup;
        private System.Windows.Forms.Button Exit;
    }
}