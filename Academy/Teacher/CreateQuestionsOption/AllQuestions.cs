using Academy.Teacher.CreateExamsOption;
using Academy.Teacher.CreateQuestionsOption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Teacher
{
    public partial class AllQuestions : Form
    {
        public User teacher;

        public AllQuestions(User teacher)
        {
            this.teacher = teacher;
            InitializeComponent();
        }

        private void AllQuestions_Load(object sender, EventArgs e)
        {
            using (var db=new AcademyEntities())
            {
                var questions = from qs in db.Questions
                                where qs.Subject.TeacherId == teacher.Id
                                select new
                                {
                                    Id=qs.Id,
                                    Text=qs.Name,
                                    Subject=qs.Subject.Name

                                };
                AllQuestionsView.DataSource = questions.ToList();
                
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateQuestion createquestion = new CreateQuestion(teacher);
            createquestion.Show();
            this.AddOwnedForm(createquestion);
        }

        private void EditQuestion_Click(object sender, EventArgs e)
        {

            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Questions.Any())
                {
                    this.Hide();

                    var id = Convert.ToInt32(AllQuestionsView.CurrentRow.Cells["Id"].Value);
                    
                    EditQuestion editQuestion = new EditQuestion(teacher, id);
                    editQuestion.Show();
                    this.AddOwnedForm(editQuestion);
                }

                else
                {
                    MessageBox.Show("No questions existed!");
                }
            }
           
        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    if (academyDb.Questions.Any())
                    {
                        
                         var id = Convert.ToInt32(AllQuestionsView.CurrentRow.Cells["Id"].Value);
                         var questionToDelete = academyDb.Questions.Find(id);
                 
                        
                            if (academyDb.Answers.Where(q => q.QuestionId == id).Any())
                            {
                                academyDb.Answers.RemoveRange(academyDb.Answers.Where(ans => ans.QuestionId == id));


                            }
                            if (academyDb.REQs.Where(q => q.QuestionId == id).Any())
                            {
                                academyDb.REQs.RemoveRange(academyDb.REQs.Where(ans => ans.QuestionId == id));

                            }

                        academyDb.Questions.Remove(questionToDelete);

                        academyDb.SaveChanges();
                        MessageBox.Show("Question " + questionToDelete.Id + " was deleted");



                    }
                    else
                    {
                        MessageBox.Show("No questions existed!");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddAnswers_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AcademyEntities())
                {
                    if (db.Questions.Any())
                    {
                        //this.Hide();
                        //var id = Convert.ToInt32(AllQuestionsView.CurrentRow.Cells["Id"].Value);


                        //AddAnswers addAnswers = new AddAnswers(id);
                        //addAnswers.Show();
                        //this.AddOwnedForm(addAnswers);
                        
                        var id = Convert.ToInt32(AllQuestionsView.CurrentRow.Cells["Id"].Value);
                        this.Hide();
                        AddAnswers addAnswers = new AddAnswers(id);
                        addAnswers.Show();
                        this.AddOwnedForm(addAnswers);

                        //if (!(db.Answers.Where(q => q.QuestionId == id).Where(c=>c.Correct==true).Any()))
                        //{
                        //    this.Hide();
                        //    AddAnswers addAnswers = new AddAnswers(id);
                        //    addAnswers.Show();
                        //    this.AddOwnedForm(addAnswers);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("This question already has answers and co!");
                        //}

                    }
                    else
                    {
                        MessageBox.Show("No questions existed!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var questions = from qs in db.Questions
                                where qs.Subject.TeacherId == teacher.Id
                                select new
                                {
                                    Id = qs.Id,
                                    Text = qs.Name,
                                    Subject = qs.Subject.Name

                                };
                AllQuestionsView.DataSource = questions.ToList();
            }
        }
    }
}
