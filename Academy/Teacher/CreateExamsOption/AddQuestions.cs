using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Teacher.CreateExamsOption
{
    public partial class AddQuestions : Form
    {
        public int id;

        public AddQuestions(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {

                var exam = db.Exams.Find(id);
                var questions = from q in db.Questions
                                where q.SubjectId==exam.SubjectId
                               select new
                               {
                                   Id=q.Id,
                                   Text=q.Name,
                                   Subject=q.Subject.Name
                               };

                AllQuestions.DataSource = questions.ToList();


                
                ExamName.Text = exam.Name;

                //if (db.REQs.Any())
                //{
                var addedQuestions = from rq in db.REQs
                                     where rq.ExamId == id
                                     select new
                                     {
                                         Id = rq.Id,
                                         Text = rq.Question.Name,
                                         Subject = rq.Question.Subject.Name
                                     };

                AddedQuestions.DataSource = addedQuestions.ToList();


                //var groupSubjects = from r in db.RSGs
                //                    where r.GroupId == id
                //                    select new
                //                    {
                //                        Id = r.Id,
                //                        Name = r.Subject.Name,
                //                        GroupId = r.Group.Name
                //                    };

                //AddedSubjects.DataSource = groupSubjects.ToList();

                //}
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
                    int questionToAddId = Convert.ToInt32(AllQuestions.CurrentRow.Cells["Id"].Value);

                    var testQuestion = db.REQs.Where(t => t.ExamId == id).Where(qe => qe.QuestionId == questionToAddId).FirstOrDefault();
                        

                    if (testQuestion == null)
                    {

                        db.REQs.Add(new REQ { ExamId = id, QuestionId = questionToAddId });
                        db.SaveChanges();

                        var addedQuestions = from rq in db.REQs
                                             where rq.ExamId ==id
                                             select new
                                             {
                                                 Id = rq.Id,
                                                 Text = rq.Question.Name,
                                                 Subject = rq.Question.Subject.Name
                                             };

                        AddedQuestions.DataSource = addedQuestions.ToList();


                        //db.RSGs.Add(new RSG { SubjectId = subjectId, GroupId = id });
                        //db.SaveChanges();
                        //var groupSubjects = from r in db.RSGs
                        //                    where r.GroupId == id
                        //                    select new
                        //                    {
                        //                        Id = r.Id,
                        //                        Name = r.Subject.Name,
                        //                        GroupId = r.Group.Name
                        //                    };

                        //AddedSubjects.DataSource = groupSubjects.ToList();
                        //var subjects = from s in db.Subjects
                        //               select new
                        //               {

                        //                   Id = s.Id,
                        //                   Name = s.Name
                        //               };

                        //AllSubjects.DataSource = subjects.ToList();

                    }

                    else
                    {
                        MessageBox.Show("Such question has already been added!");
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

                    //var subjectsOfGroup = db.RSGs.Where(g => g.GroupId == id).FirstOrDefault();

                    var testQuestion = db.REQs.Where(t => t.ExamId == id).FirstOrDefault();
                    if (testQuestion != null)
                    {
                        //var subjectToDelete = AddedSubjects.CurrentRow.Cells["Id"].Value;
                        int questionToRemoveId = Convert.ToInt32(AddedQuestions.CurrentRow.Cells["Id"].Value);

                        //int subjectToDeleteId = Convert.ToInt32(db.RSGs.Where(s => s.GroupId == id).
                        //    Where(g => g.Subject.Name == subjectToDelete).Select(i=>i.Id));

                        var questionToRemove = db.REQs.Find(questionToRemoveId);

                        //MessageBox.Show(subjectToDelete.ToString());
                        db.REQs.Remove(questionToRemove);

                        db.SaveChanges();

                        var addedQuestions = from rq in db.REQs
                                             where rq.ExamId == id
                                             select new
                                             {
                                                 Id = rq.Id,
                                                 Text = rq.Question.Name,
                                                 Subject = rq.Question.Subject.Name
                                             };

                        AddedQuestions.DataSource = addedQuestions.ToList();

                        var exam = db.Exams.Find(id);
                        var questions = from q in db.Questions
                                        where q.SubjectId == exam.SubjectId
                                        select new
                                        {
                                            Id = q.Id,
                                            Text = q.Name,
                                            Subject = q.Subject.Name
                                        };

                        AllQuestions.DataSource = questions.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No questions for the exam left!");
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
