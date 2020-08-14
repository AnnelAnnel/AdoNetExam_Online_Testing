using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Student
{
    public partial class PassExams : Form
    {
        public User student;
        public PassExams(User student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void PassExamsOption_Load(object sender, EventArgs e)
        {
            using(var db=new AcademyEntities())
            {
                var subjectsOfGroup = from rs in db.RSGs
                                      where rs.GroupId == student.GroupId

                                      select new
                                      {
                                          Id = rs.Subject.Id,
                                          Name = rs.Subject.Name,
                                          Group = rs.Group.Name
                                      };

                SubjectsView.DataSource = subjectsOfGroup.ToList();


            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ShowExams_Click(object sender, EventArgs e)
        {
            using(var db=new AcademyEntities())
            {
                var subjectId = Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);

                if (db.Exams.Where(em=>em.SubjectId==subjectId).Any())
                {
                    this.Hide();

                    AllExams allExams = new AllExams(subjectId, student.Id);
                    allExams.Show();
                    this.AddOwnedForm(allExams);
                }

                else
                {
                    MessageBox.Show("No exams on the selected subject existed!");
                }
            }
        }
    }
}
