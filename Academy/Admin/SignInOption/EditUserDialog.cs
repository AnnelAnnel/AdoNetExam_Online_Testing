using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Admin
{
    public partial class EditUserDialog : Form
    {
        public int id;

       
        public EditUserDialog(int id)
        {

            InitializeComponent();
            this.id = id;         
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void EditUserDialog_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var user = academyDb.Users.Find(id);

                LName.Text = user.LName;
                FName.Text = user.FName;
                Phone.Text = user.Phone;
                Login.Text = user.Login;
                Password.Text = user.Password;

                RolesChoice.Items.AddRange(new string[] { "Admin", "Teacher", "Student" });

                if (user.RoleId == 1)
                    RolesChoice.Items[0] += " - Current";
                if (user.RoleId == 2)
                    RolesChoice.Items[1] += " - Current";
                if (user.RoleId == 3)
                    RolesChoice.Items[2] += "  Current";
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    var editedDUser = academyDb.Users.Find(id);
                    if (Login.Text != "" && Password.Text != "" && LName.Text != "" && FName.Text != ""
                        && Phone.Text != ""&& RolesChoice.Text!="")
                    {
                        
                            editedDUser.LName = LName.Text;
                            editedDUser.FName = FName.Text;
                            editedDUser.Phone = Phone.Text;
                            editedDUser.Login = Login.Text;
                            editedDUser.Password = Password.Text;
                        if (editedDUser.Id == 1)
                        {
                            editedDUser.RoleId = editedDUser.RoleId;
                            MessageBox.Show("You cannot change your role! Leave it as Admin!");
                        }
                        else
                        {
                            editedDUser.RoleId = RolesChoice.SelectedIndex + 1;
                        }                      
                            

                            academyDb.SaveChanges();

                            this.Owner.Show();
                            this.Close();
                        

                    }
                    else
                    {
                        MessageBox.Show("Do not leave any field empty!");
                    }

                        
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }                              
        }

        private void RolesChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = RolesChoice.SelectedItem.ToString();
      
        }
    }
}
