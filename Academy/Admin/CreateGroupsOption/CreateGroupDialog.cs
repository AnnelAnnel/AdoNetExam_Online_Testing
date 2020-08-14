using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Admin.CreateGroupsOption
{
    public partial class CreateGroupDialog : Form
    {
        public CreateGroupDialog()
        {
            InitializeComponent();
        }

        private void CreateGroupDialog_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                try
                {
                    bool exists = (from g in academyDb.Groups
                                   where g.Name == GroupName.Text
                                   select g).Any();


                    if (GroupName.Text != "")
                    {
                        if (!exists)
                        {
                            var name = GroupName.Text;
                            academyDb.Groups.Add(new Group { Name = name });
                            academyDb.SaveChanges();
                            MessageBox.Show("New group has been successfully created!");
                            this.Owner.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A group with the same name already exists!");
                        }
                    }
                   

                    else
                    {
                        MessageBox.Show("Fill in all fields!");
                    }

                }
                catch (Exception ex)
                {
                    this.Owner.Show();
                    this.Close();
                    MessageBox.Show(ex.Message);

                }
         

            

            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
