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
    public partial class AddSubjectsDialog : Form
    {
        public int id;
        public AddSubjectsDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AddSubjectsDialog_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {

                var subjects = from s in db.Subjects
                               select new
                               {

                                   Id = s.Id,
                                   Name = s.Name
                               };

                AllSubjects.DataSource = subjects.ToList();

                
                var group = db.Groups.Find(id);
                GroupName.Text = group.Name;
                var groupSubjects = from r in db.RSGs
                                    where r.GroupId == id
                                    select new
                                    {
                                        Id = r.Id,
                                        Name= r.Subject.Name,
                                        GroupId = r.Group.Name
                                    };

                AddedSubjects.DataSource = groupSubjects.ToList();

            }            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AcademyEntities())
                {
                    int subjectId = Convert.ToInt32(AllSubjects.CurrentRow.Cells["Id"].Value);

                    var testName = db.RSGs.Where(gr => gr.GroupId == id).Where(sj => sj.SubjectId== subjectId).FirstOrDefault();

                    if (testName == null)
                    {
                        
                        db.RSGs.Add(new RSG { SubjectId = subjectId, GroupId = id });
                        db.SaveChanges();
                        var groupSubjects = from r in db.RSGs
                                            where r.GroupId == id
                                            select new
                                            {
                                                Id = r.Id,
                                                Name = r.Subject.Name,
                                                GroupId = r.Group.Name
                                            };

                        AddedSubjects.DataSource = groupSubjects.ToList();
                        var subjects = from s in db.Subjects
                                       select new
                                       {

                                           Id = s.Id,
                                           Name = s.Name
                                       };

                        AllSubjects.DataSource = subjects.ToList();

                    }

                    else
                    {
                        MessageBox.Show("Such subject has already been added!");
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

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AcademyEntities())
                {

                    //var studentsOfGroup = db.Users.Where(d => d.RoleId == 3).Where(f => f.GroupId == id).FirstOrDefault();

                    var subjectsOfGroup = db.RSGs.Where(g => g.GroupId == id).FirstOrDefault();
                    if (subjectsOfGroup != null)
                    {
                        //var subjectToDelete = AddedSubjects.CurrentRow.Cells["Id"].Value;
                        int subjectToDelete = Convert.ToInt32(AddedSubjects.CurrentRow.Cells["Id"].Value);

                        //int subjectToDeleteId = Convert.ToInt32(db.RSGs.Where(s => s.GroupId == id).
                        //    Where(g => g.Subject.Name == subjectToDelete).Select(i=>i.Id));

                        var subjectToRemove = db.RSGs.Find(subjectToDelete);

                        //MessageBox.Show(subjectToDelete.ToString());
                        db.RSGs.Remove(subjectToRemove);

                        db.SaveChanges();

                        var groupSubjects = from r in db.RSGs
                                            where r.GroupId == id
                                            select new
                                            {
                                                Id = r.Id,
                                                Name = r.Subject.Name,
                                                GroupId = r.Group.Name
                                            };

                        AddedSubjects.DataSource = groupSubjects.ToList();
                        var subjects = from s in db.Subjects
                                       select new
                                       {

                                           Id = s.Id,
                                           Name = s.Name
                                       };

                        AllSubjects.DataSource = subjects.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No subjects for the group!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
