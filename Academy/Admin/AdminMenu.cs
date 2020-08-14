using Academy.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class AdminMenu : Form
    {
    /// <summary>
    /// ///////////////////////////////////this one is valid
    /// </summary>

        public User user;
     

        public AdminMenu(User user)
        {
            InitializeComponent();           
            this.user = user;
            Greeting.Text = "Welcome, "+ user.FName+" "+user.LName+"!";

        }

        private void Exit_Click(object sender, EventArgs e)
        {
           
            this.Owner.Show();
            
            this.Close();    
            
          
        }

        private void Greeting_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn(user);
            signIn.Show();
            this.AddOwnedForm(signIn);
        }

        private void CreateSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSubject createSubject = new CreateSubject();
            createSubject.Show();
            this.AddOwnedForm(createSubject);
        }

        private void CreateGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGroup createGroup = new CreateGroup();
            createGroup.Show();
            this.AddOwnedForm(createGroup);          
           
        }
    }
}
