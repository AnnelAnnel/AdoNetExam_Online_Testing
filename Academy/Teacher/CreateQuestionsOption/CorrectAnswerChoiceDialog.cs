using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Teacher.CreateQuestionsOption
{
    public partial class CorrectAnswerChoiceDialog : Form
    {
        public int id;

        public CorrectAnswerChoiceDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void CorrectAnswerChoiceDialog_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                var answers = from a in academyDb.Answers
                              where a.QuestionId == id
                              select new
                              {
                                  Id = a.Id,
                                  Answer = a.AnswerText,
                                  Correct = a.Correct
                              };

                AnswersView.DataSource = answers.ToList();

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db=new AcademyEntities())
                {
                    var answerId = Convert.ToInt32(AnswersView.CurrentRow.Cells["Id"].Value);
                    var correctAnswer=db.Answers.Find(answerId);
                    if (!(db.Answers.Where(a => a.QuestionId == id).Where(c => c.Correct == true).Any()))
                    {
                        correctAnswer.Correct = true;
                        db.SaveChanges();

                        var answers = from a in db.Answers
                                      where a.QuestionId == id
                                      select new
                                      {
                                          Id = a.Id,
                                          Answer = a.AnswerText,
                                          Correct = a.Correct
                                      };

                        AnswersView.DataSource = answers.ToList();

                    }
                    else
                    {
                        var previousCorrect = db.Answers.Where(a => a.QuestionId == id).Where(c => c.Correct == true).Single();
                        previousCorrect.Correct = false;
                        correctAnswer.Correct = true;
                        db.SaveChanges();

                        var answers = from a in db.Answers
                                      where a.QuestionId == id
                                      select new
                                      {
                                          Id = a.Id,
                                          Answer = a.AnswerText,
                                          Correct = a.Correct
                                      };

                        AnswersView.DataSource = answers.ToList();
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
