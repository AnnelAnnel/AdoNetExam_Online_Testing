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

namespace Academy.Teacher.CreateExamsOption
{
    public partial class AddAnswers : Form
    {
        public int id;
        public AddAnswers(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AddAnswers_Load(object sender, EventArgs e)
        {
            using (var db=new AcademyEntities()) {



                var question = db.Questions.Find(id);
                QuestionText.Text = question.Name;

                if (db.Answers.Where(q => q.QuestionId == id).Any())
                {
                    MessageBox.Show("There are already answers for this question," +
                        "which can be observed via 'Choose Correct Answer' option");
         
                                
                }

               
            }
      
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ChooseCorrect_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Answers.Any())
                {
                    this.Hide();

                    CorrectAnswerChoiceDialog correctChoice = new CorrectAnswerChoiceDialog(id);

                    correctChoice.Show();
                    this.AddOwnedForm(correctChoice);
                }

                else
                {
                    MessageBox.Show("No questions existed!");
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db=new AcademyEntities())
                {
                    if (Answer1.Text != "" && Answer2.Text != "" && Answer3.Text != "" && Answer4.Text != "")
                    {
                        var question = db.Questions.Find(id);
                        var answer1 = Answer1.Text;
                        var answer2 = Answer2.Text;
                        var answer3 = Answer3.Text;
                        var answer4 = Answer4.Text;

                        if (Answer1.Text != Answer2.Text && Answer1.Text != Answer3.Text
                            && Answer1.Text != Answer4.Text && Answer2.Text != Answer3.Text
                            && Answer2.Text != Answer4.Text && Answer3.Text != Answer4.Text)
                        {
                            var quantityCheck = Convert.ToInt32(db.Answers.Where(q => q.QuestionId == id).Count());
                              
                            if (quantityCheck<4) {
                                db.Answers.Add(new Answer { QuestionId = question.Id, AnswerText = answer1 });
                                db.Answers.Add(new Answer { QuestionId = question.Id, AnswerText = answer2 });
                                db.Answers.Add(new Answer { QuestionId = question.Id, AnswerText = answer3 });
                                db.Answers.Add(new Answer { QuestionId = question.Id, AnswerText = answer4 });
                                db.SaveChanges();
                                MessageBox.Show("The answers were successfully created!");
                                this.Hide();

                                CorrectAnswerChoiceDialog correctChoice = new CorrectAnswerChoiceDialog(id);

                                correctChoice.Show();
                                this.AddOwnedForm(correctChoice);

                            }
                            else
                            {
                                MessageBox.Show("The answers were already created! Proceed to 'Choose Correct Answer' or 'Back' options");
                            }
                        }
                            
                        
                        else
                        {
                            MessageBox.Show("Some answers have the same text!");
                        }


                    }
                    else
                    {
                        if (db.Answers.Where(q => q.QuestionId == id).Any())
                        {
                            MessageBox.Show("Proceed to 'Choose Correct Answer' or 'Back' options");
                        }
                        else {
                            MessageBox.Show("Fill in all the fields!");
                        }
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
