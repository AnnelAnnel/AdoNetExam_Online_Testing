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
    public partial class EditGroupDialog : Form
    {
        public int id;
        public EditGroupDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EditGroupDialog_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var group = academyDb.Groups.Find(id);

                GroupName.Text = group.Name;                   

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    var editedGroup = academyDb.Groups.Find(id);

                    if (GroupName.Text != "")
                    {


                        editedGroup.Name = GroupName.Text;                        
                        academyDb.SaveChanges();
                        this.Owner.Show();
                        this.Close();


                    }
                    //else if ()
                    //{
                    //    MessageBox.Show("Do not leave any field empty!");
                    //}
                    else
                    {
                        MessageBox.Show("Do not leave any field empty!");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Owner.Show();
                this.Close();
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
