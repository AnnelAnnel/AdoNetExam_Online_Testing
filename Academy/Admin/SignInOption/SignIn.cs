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
    public partial class SignIn : Form
    {

        public User user;

        //public IQueryable UsersView;

        public SignIn(User user)
        {
            InitializeComponent();

            this.user = user;

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                var UsersView = from u in academyDb.Users
                                select new
                                {
                                    Id = u.Id,
                                    FName = u.FName,
                                    LName = u.LName,
                                    Login = u.Login,
                                    Password = u.Password,
                                    RoleId = u.RoleId,
                                    Phone = u.Phone,
                                    Date = u.Date

                                };
                AllUsersView.DataSource = UsersView.ToList();
                AllUsersView.BackgroundColor = Color.White;
                AllUsersView.ReadOnly = true;
                AllUsersView.AllowUserToResizeColumns = true;

            }
        }

        private void AllUsersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserDialog addUserDialog = new AddUserDialog(user);
            addUserDialog.Show();
            this.AddOwnedForm(addUserDialog);

        }



        private void UpdateView_Click(object sender, EventArgs e)
        {

            using (AcademyEntities academyDb = new AcademyEntities())
            {

                var UsersView = from u in academyDb.Users
                                select new
                                {
                                    Id = u.Id,
                                    Login = u.Login,
                                    Password = u.Password,
                                    RoleId = u.RoleId,
                                    LName = u.LName,
                                    FName = u.FName,
                                    Date = u.Date,
                                    Phone = u.Phone

                                };
                AllUsersView.DataSource = UsersView.ToList();
                AllUsersView.BackgroundColor = Color.White;
                AllUsersView.ReadOnly = true;
                AllUsersView.AllowUserToResizeColumns = true;

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Users.Any())
                {

                    this.Hide();

                    var id = Convert.ToInt32(AllUsersView.CurrentRow.Cells["Id"].Value);


                    EditUserDialog editUserDialog = new EditUserDialog(id);
                    editUserDialog.Show();
                    this.AddOwnedForm(editUserDialog);


                }
                else
                {
                    MessageBox.Show("No users existed!");
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Users.Any())
                {

                    var id = Convert.ToInt32(AllUsersView.CurrentRow.Cells["Id"].Value);
                    var userToDelete = academyDb.Users.Find(id);
                    if (id != user.Id)
                    {
                        if (userToDelete.Id != 1)
                        {
                            if (userToDelete.RoleId == 2)
                            {
                                if (!academyDb.Subjects.Where(s => s.TeacherId == userToDelete.Id).Any())

                                {

                                    academyDb.Users.Remove(userToDelete);

                                    academyDb.SaveChanges();
                                    MessageBox.Show("User info about " + userToDelete.FName + " " + userToDelete.LName + " was deleted");
                                }
                                else
                                {
                                    MessageBox.Show("You cannot delete this user as he/she has subjects. Revoke the subjects first");
                                }
                            }
                            if (userToDelete.RoleId == 3)
                            {
                                if (!academyDb.Marks.Where(m => m.StudentId == userToDelete.Id).Any())

                                {
                                    academyDb.Users.Remove(userToDelete);
                                    academyDb.SaveChanges();
                                    MessageBox.Show("User info about " + userToDelete.FName + " " + userToDelete.LName + " was deleted");
                                }
                                else
                                {
                                    MessageBox.Show("You cannot delete this user as he/she has marks");
                                }
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("You cannot destroy your Creator!!!!!");
                        }

                    }                
                    else
                    {
                        MessageBox.Show("You cannot delete yourself!");
                    }

                }
                else
                {
                    MessageBox.Show("No users existed!");
                }                


            }
        }
    }
}
