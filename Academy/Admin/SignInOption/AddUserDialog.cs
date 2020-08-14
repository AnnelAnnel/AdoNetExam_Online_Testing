using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Academy
{
    public partial class AddUserDialog : Form
    {
        public User user;
        

        public AddUserDialog(User user)
        {
            InitializeComponent();
            this.user = user;

            


        }

        private void AddUserDialog_Load(object sender, EventArgs e)
        {      
            RolesChoice.Items.AddRange(new string[] { "Admin", "Teacher", "Student"});
            
        }

      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void RolesChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = RolesChoice.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            
            this.Close();
        }

      

        private void Ok_Click(object sender, EventArgs e)
        {
            
            using (AcademyEntities academyDb = new AcademyEntities())
            {
            //AcademyEntities academyDb = new AcademyEntities();
            try
                {
                if (Login.Text != "" && Password.Text != "" && LName.Text != "" && FName.Text != ""
                        && RolesChoice.Text != "" && Phone.Text != "")
                {
                    
                    var loginTest = academyDb.Users.FirstOrDefault(l => l.Login == Login.Text);
                        if (loginTest==null)
                        {
                            var newUser = new User
                            {
                                Login = Login.Text,
                                Password = Password.Text,
                                LName = LName.Text,
                                FName = FName.Text,
                                RoleId = RolesChoice.SelectedIndex + 1,
                                Phone = Phone.Text,
                                Date = DateTime.Now
                            };
                            academyDb.Users.Add(newUser);
                            academyDb.SaveChanges();

                            this.Owner.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A user with the same Login already exists!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Fill in all fields!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
