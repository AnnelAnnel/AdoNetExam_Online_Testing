using Academy.Admin.CreateSubjesctsOption;
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
    public partial class CreateSubject : Form
    {
        public CreateSubject()
        {
            InitializeComponent();
        }

        private void CreateSubject_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var subjectsView = academyDb.Subjects.Join(academyDb.Users,
                    s => s.TeacherId,
                    t => t.Id,
                    (s, t) => new
                    {
                        Id = s.Id,
                        Name = s.Name,
                        TeacherName = t.FName + " " + t.LName
                    });
    


                SubjectsView.DataSource = subjectsView.ToList();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSubjectDialog createSubjectDialog = new CreateSubjectDialog();
            createSubjectDialog.Show();
            this.AddOwnedForm(createSubjectDialog);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var subjectsView = academyDb.Subjects.Join(academyDb.Users,
                      s => s.TeacherId,
                      t => t.Id,
                      (s, t) => new
                      {
                          Id=s.Id,
                          Name = s.Name,
                          TeacherName = t.FName + " " + t.LName
                      });
                SubjectsView.DataSource = subjectsView.ToList();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Subjects.Any())
                {
                    this.Hide();

                    var id = Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);
              
                    EditSubjectDialog editSubjectDialog = new EditSubjectDialog(id);
                    editSubjectDialog.Show();

                    this.AddOwnedForm(editSubjectDialog);
                }
                
                else
                {
                    MessageBox.Show("No subjects existed!");
                }
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {

                    if (academyDb.Subjects.Any())
                    {
                        var id = Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);
                        var subject = academyDb.Subjects.Find(id);

                        if (academyDb.RSGs.Where(rs => rs.SubjectId == id).Any())
                        {
                            academyDb.RSGs.RemoveRange(academyDb.RSGs.Where(rg => rg.SubjectId == id));
                        }

                            academyDb.Subjects.Remove(subject);

                            academyDb.SaveChanges();
                            MessageBox.Show("Subject " + subject.Name + " was deleted");
                       
                    }
                    
                    else
                    {
                        MessageBox.Show("No subjects existed!");
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
