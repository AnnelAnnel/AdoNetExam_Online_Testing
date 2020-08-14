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
    public partial class AllExams : Form
    {
        public int subjectId;
        public int studentId;
        public AllExams(int subjectId, int studentId)
        {
            
            InitializeComponent();
            this.subjectId = subjectId;
            this.studentId = studentId;
            
        }

        private void AllExams_Load(object sender, EventArgs e)
        {
            using(var db=new AcademyEntities())
            {
                //if (db.Exams.Where(em => em.SubjectId == subjectId).Any() 
                //    && db.REQs.Where(exm => exm.Exam.SubjectId==subjectId).Any())
                //{
                var exams = from ems in db.Exams
                            where ems.SubjectId == subjectId

                            select new
                            {
                                Id = ems.Id,
                                Name = ems.Name,
                                Date = ems.Date,
                                Subject = ems.Subject.Name
                            };

                //var exams2 = db.Exams.Where(ems => ems.SubjectId == subjectId);
                //List<IQueryable> available = new List<IQueryable>();
                //foreach(var ex in exams2)
                //{
                //    var test = db.Student_Answer.Where(u => u.UserId == studentId).Where(em => em.ExamId == ex.Id).Any();
                //    if (test==false)
                //    {
                //        var exm = from en in db.Exams
                //                  where en.Id == ex.Id
                //                  //where en.SubjectId == subjectId
                //                  select new
                //                  {
                //                      Id = en.Id,
                //                      Name = en.Name,
                //                      Date = en.Date,
                //                      Subject = en.Subject.Name
                //                  };


                //        available.Add(exm);
                //    }
                //}

                
                    ExamsView.DataSource = exams.ToList();
                //}
                //else
                //{

                //    MessageBox.Show("!!!");
                //}
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void PassExam_Click(object sender, EventArgs e)
        {
            using(var db=new AcademyEntities())
            {
                
                var examId = Convert.ToInt32(ExamsView.CurrentRow.Cells["Id"].Value);

                if (db.REQs.Where(exm => exm.ExamId == examId).Any())
                {

                    //MessageBox.Show("Has questions");
                    if (!db.Student_Answer.Where(ex => ex.ExamId == examId).Where(s => s.UserId == studentId).Any())
                    {
                        this.Hide();
                        TakeExam takeExam = new TakeExam(examId, studentId);
                        takeExam.Show();
                        this.AddOwnedForm(takeExam);
                    }
                    else
                    {
                        MessageBox.Show("You have already passed this exam");
                    }
                    

                }
                else
                {
                    MessageBox.Show("This exam is not ready as it may not have questions prepared yet");
                }
            }
        }
    }
}
