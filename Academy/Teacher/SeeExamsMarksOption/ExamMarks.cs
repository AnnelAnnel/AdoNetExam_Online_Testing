using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Teacher.SeeExamsMarksOption
{
    public partial class ExamMarks : Form
    {
        public User teacher;

        public ExamMarks(User teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void ExamMarks_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {

                    var exams = from ex in db.Exams
                                where ex.Subject.TeacherId == teacher.Id

                                select new
                                {
                                    Id = ex.Id,
                                    ExamName = ex.Name,
                                    ExamDate = ex.Date,
                                    Subject = ex.Subject.Name

                                };

                    ExamsView.DataSource = exams.ToList();




                    //if (db.Groups.Any()) { }
                    var groups = from s in db.RSGs
                                 where s.Subject.TeacherId == teacher.Id
                                 select new
                                 {
                                     Id = s.GroupId,
                                     GroupName = s.Group.Name,
                                     SubjectName = s.Subject.Name
                                 };

                    GroupsView.DataSource = groups.ToList();
                
               

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void ShowMarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db=new AcademyEntities())
                {
                    var examId = Convert.ToInt32(ExamsView.CurrentRow.Cells["Id"].Value);
                    var groupId = Convert.ToInt32(GroupsView.CurrentRow.Cells["Id"].Value);

                    var marks = from m in db.Marks
                                where m.ExamId == examId
                                where m.User.GroupId == groupId
                                select new
                                {
                                    Id = m.Id,
                                    Student = m.User.FName + " " + m.User.LName,
                                    Group = m.User.Group.Name,
                                    Exam = m.Exam.Name,
                                    Mark = m.Mark1,
                                    Pass = m.Pass

                                };

                    MarksView.DataSource = marks.ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
