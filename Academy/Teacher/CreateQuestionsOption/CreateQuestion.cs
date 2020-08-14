using Academy.Teacher.CreateExamsOption;
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
    public partial class CreateQuestion : Form
    {
        public User teacher;

        public CreateQuestion(User teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {

            using (var db = new AcademyEntities())
            {

                var subjects = from s in db.Subjects
                            where s.TeacherId == teacher.Id

                            select new
                            {
                                Id = s.Id,
                                Name=s.Name,
                                Teacher=s.User.FName+" "+s.User.LName                                

                            };

                SubjectsView.DataSource = subjects.ToList();

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AcademyEntities())
                {
                    if (QuestionText.Text != "")
                    {
                        // int teacherId = Convert.ToInt32(TeachersView.CurrentRow.Cells["Id"].Value);
                        var nameTest = db.Questions.FirstOrDefault(l => l.Name.Contains(QuestionText.Text));
                        if (nameTest == null)
                        {

                            var name = QuestionText.Text;                      

                            int subjectId = Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);

                            db.Questions.Add(new Question { Name = name, SubjectId = subjectId });

                                                      
                            db.SaveChanges();

                            

                           // var questionId = from q in db.Questions
                           //                  where q.Name == name
                           //                  select q;


                           //var qId=Convert.ToInt32(questionId.Select(i => i.Id));
                           // MessageBox.Show(qId.ToString());

                           // //db.REQs.Add(new REQ { QuestionId = qId, ExamId = examId });

                            this.Owner.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A question with the same text already exists!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill in all fields!");
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

        private void AddAnswers_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    using (var db = new AcademyEntities())
            //    {
            //        if (db.Questions.Any())
            //        {


            //            var question = db.Questions.Find();


            //            this.Hide();
            //            AddAnswers addAnswers = new AddAnswers((Question)question);
            //            this.AddOwnedForm(addAnswers);

            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
                
            //}
        }
    }
}
