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
    public partial class Authorization : Form
    {        

        public Authorization()
        {
            /// <summary>
            /// most updated version
            /// </summary>
            InitializeComponent();           

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
      
            var login = LoginText.Text;

                var password = PasswordText.Text;

            var loginSearch = from user in academyDb.Users
                              where user.Login == login
                              select user;

            var userResult = loginSearch.FirstOrDefault();

            var role = from roles in academyDb.Roles
                       where roles.Id == userResult.RoleId
                       select roles;
            //var roleName = role.FirstOrDefault();


            try
                {
                    if (LoginText.Text != "" && PasswordText.Text != "")
                    {
                       
                        if (userResult != null)
                        {
                            if (password == userResult.Password)
                            {
                                
                               
                                MessageBox.Show("You have successfully logged in!");
                                this.Hide();
                           
                                if (userResult.RoleId == 1)
                                {
                                   
                                    AdminMenu adminMenu = new AdminMenu(userResult);
                                    adminMenu.Show();
                                   this.AddOwnedForm(adminMenu);
                            }
                                if (userResult.RoleId == 2)
                                {
                                    Teachermenu teacherMenu = new Teachermenu(userResult);
                                    teacherMenu.Show();
                                this.AddOwnedForm(teacherMenu);
                            }
                                if (userResult.RoleId ==3)
                                {
                                    StudentMenu studentMenu = new StudentMenu(userResult);
                                    studentMenu.Show();
                                this.AddOwnedForm(studentMenu);
                            }


                            }
                            else
                            {
                                MessageBox.Show("Wrong password!");
                            }

                        }

                        else
                        {
                            MessageBox.Show("Login not found!");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Fill in all fields!");

                    }
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }



            }
        }         
    

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
