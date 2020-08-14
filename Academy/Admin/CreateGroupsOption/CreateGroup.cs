using Academy.Admin.CreateGroupsOption;
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
    public partial class CreateGroup : Form
    {
        public int updatedGroupId;
        public CreateGroup()
        {
            InitializeComponent();
        }

       

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            using(var db=new AcademyEntities())
            {
               
                var groups = from g in db.Groups
                             select new
                             {
                                 Id = g.Id,
                                 Name = g.Name
                             };
                GroupsView.DataSource = groups.ToList();

                
            }

        }

       
       
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsOfGroupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                updatedGroupId = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);
                var updatedGroup = db.Groups.Find(updatedGroupId);
                if (updatedGroup != null)
                {
                    label2.Text = "Students of " + updatedGroup.Name + ":";
                }
                var groups = from g in db.Groups
                             select new
                             {
                                 Id = g.Id,
                                 Name = g.Name
                             };
                GroupsView.DataSource = groups.ToList();
            

                if (groups.Any())

                {
                    


                    var students2 = from u in db.Users
                                   where u.RoleId == 3
                                   where u.GroupId == updatedGroupId
                                    select new
                                   {

                                       Id = u.Id,
                                       FName = u.FName,
                                       LName = u.LName,
                                       Phone = u.Phone

                                   };

                    StudentsOfGroupView.DataSource = students2.ToList();
                }
                else
                {
                    MessageBox.Show("No groups created yet");
                
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGroupDialog createGroupDialog = new CreateGroupDialog();
            createGroupDialog.Show();
            this.AddOwnedForm(createGroupDialog);
        }

        private void AddStudents_Click(object sender, EventArgs e)
        {            
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Groups.Any())
                {                   

                    var id = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);
                  
                    this.Hide();

                    AddStudentsDialog addStudentsDialog = new AddStudentsDialog(id);
                    addStudentsDialog.Show();
                    this.AddOwnedForm(addStudentsDialog);
                }
                else
                {
                    MessageBox.Show("No groups existed!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Groups.Any())
                {

                    this.Hide();

                    var id = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);
                    //EditSubjectDialog 
                    EditGroupDialog editGroupDialog = new EditGroupDialog(id);
                    editGroupDialog.Show();

                    this.AddOwnedForm(editGroupDialog);
                }
                else
                {
                    MessageBox.Show("No groups existed!");
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                if (academyDb.Groups.Any())
                {
                    var grId = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);
                    var group = academyDb.Groups.Find(grId);
                    if (academyDb.RSGs.Where(rg => rg.GroupId == grId).Any())
                    {
                        academyDb.RSGs.RemoveRange(academyDb.RSGs.Where(rg => rg.GroupId == grId));
                            
                    }

                    if (academyDb.Users.Where(u => u.GroupId == grId).Any())
                    {
                        var studentsOfgroup = academyDb.Users.Where(u => u.GroupId == grId);
                        foreach (var student in studentsOfgroup)
                        {
                            student.GroupId = null;
                        }
                    }

                    academyDb.Groups.Remove(group);

                    academyDb.SaveChanges();
                    MessageBox.Show("Group " + group.Name + " was deleted");
                    var groups = from g in academyDb.Groups
                                 select new
                                 {
                                     Id = g.Id,
                                     Name = g.Name
                                 };
                    GroupsView.DataSource = groups.ToList();




                }
                else
                {
                    MessageBox.Show("No groups existed!");
                }

            }
        }

        private void AddSubjects_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Groups.Any())
                {

                    var id = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);

                    this.Hide();

                    AddSubjectsDialog addSubjectsDialog = new AddSubjectsDialog(id);
                    addSubjectsDialog.Show();
                    this.AddOwnedForm(addSubjectsDialog);
                }
                else
                {
                    MessageBox.Show("No groups existed!");
                }
            }
        }
    }
}
