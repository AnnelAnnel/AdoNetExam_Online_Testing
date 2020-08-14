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
    public partial class TakeExam : Form
    {

        private int examId;
        private int studentId;
        private int subjectId;
        private int counter = 1;
        private int questionCount;
        private int choice;
        private List<REQ> allQuestions;
        private List<Answer> allAnswers;
        private bool examStarted;
        private int qIndex;
        private int aIndex;
        private List<string> studentAnswers;
        private string answer;

        public TakeExam(int examId, int studentId)
        {
            InitializeComponent();
            this.examId = examId;
            this.studentId = studentId;

            choice = 0;
            allAnswers = new List<Answer>();
            allQuestions = new List<REQ>();
            studentAnswers = new List<string>();
     

        }

        private void TakeExam_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var exam = db.Exams.Find(examId);
                var student = db.Users.Find(studentId);
                subjectId = exam.SubjectId;
                              
            
                ExamInfo.Text = "Exam '" + exam.Name + "' on the subject '" + exam.Subject.Name + "'\nTeacher: "
                    + exam.Subject.User.FName + " " + exam.Subject.User.LName + "\nStudent: "
                    + student.FName + " " + student.LName + " " + student.Group.Name;

                QuestionsCount.Text = "Total questions: " + exam.REQs.Where(q => q.ExamId == examId).Count();

                questionCount = Convert.ToInt32(exam.REQs.Where(q => q.ExamId == examId).Count());

                var questionsOfExam = db.REQs.Where(r => r.ExamId == examId);

                examStarted = false;

                answer = "";

                foreach (var question in questionsOfExam)
                {
                    allAnswers.AddRange(question.Question.Answers);
                    allQuestions.Add(question);
                }                        
                
            }
            QuestionGroup.Visible = false;
            EndTest.Enabled = false;
            NextQuestion.Enabled = false;
        }


        private void StartExam_Click(object sender, EventArgs e)
        {
            if (examStarted==false)
            {
                using (var db = new AcademyEntities())
                {
                    QuestionGroup.Visible = true;
                    NextQuestion.Enabled = true;
                    qIndex = 0;
                    aIndex = 0;

                    if (questionCount > counter)
                    {

                        QuestionText.Text = "Вопрос № " + counter.ToString() + ": " + allQuestions[qIndex].Question.Name;

                        Answer1.Text = allAnswers[aIndex++].AnswerText;

                        Answer2.Text = allAnswers[aIndex++].AnswerText;

                        Answer3.Text = allAnswers[aIndex++].AnswerText;

                        Answer4.Text = allAnswers[aIndex++].AnswerText;                      

                        examStarted = true;

                    }
                    else
                    {
                        NextQuestion.Enabled = false;
                        
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("The exam has already started!");
            }
        }


        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void NextQuestion_Click_1(object sender, EventArgs e)
        {

            if (choice > 0)
            {
                StartExam.Enabled = false;
                using (var db = new AcademyEntities())
                {
                    //choice = 0;
                    counter++;
                    ++qIndex;
                    //studentAnswers.Add(answer);
                                
                  
                    if (questionCount >= counter)
                    {
                        studentAnswers.Add(answer);
                        QuestionText.Text = "Вопрос № " + counter.ToString() + ": " + allQuestions[qIndex].Question.Name;

                    Answer1.Text = allAnswers[aIndex++].AnswerText;
                       
                    Answer2.Text = allAnswers[aIndex++].AnswerText;


                    Answer3.Text = allAnswers[aIndex++].AnswerText;

                    Answer4.Text = allAnswers[aIndex++].AnswerText;
                        Answer1.Checked = false;
                        Answer2.Checked = false;

                        Answer3.Checked = false;
                        Answer4.Checked = false;

                        choice = 0;               

                   
                }
                    else
                    {
                        
                        NextQuestion.Enabled = false;
                        EndTest.Enabled = true;
                        
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("You should choose an answer");
            }
        }

        private void EndTest_Click_1(object sender, EventArgs e)
        {           
         
                studentAnswers.Add(answer);
               
            using (var db = new AcademyEntities())
            {
                try
                {

                    foreach (var answ in studentAnswers)
                    {
                        

                        var ans = db.Answers.Where(a => a.AnswerText == answ).FirstOrDefault();


                        db.Student_Answer.Add(new Student_Answer { UserId = studentId, ExamId = examId, AnswerId = ans.Id });
                        db.SaveChanges();
                    }


                    int correct = db.Student_Answer.Where(s => s.UserId == studentId)
                        .Where(q => q.Answer.Correct == true).Count();

                    double markTmp = Convert.ToDouble(correct) / Convert.ToDouble(questionCount) * 100;

                    int mark = Convert.ToInt32(markTmp);
                   

                    bool passed = false;

                    if (mark >= 50)
                    {
                        passed = true;
                        MessageBox.Show("You've scored "+correct.ToString()+"/"+questionCount.ToString()+
                            "\nYour mark is " + mark.ToString() + "\nYou passed. Nice job!");
                    }
                    else
                    {
                        MessageBox.Show("You've scored " + correct.ToString() + "/" + questionCount.ToString() +
                            "\nYour mark is " + mark.ToString() + "\nYou did not pass. Don't give up!");
                    }

                    db.Marks.Add(new Mark { StudentId = studentId, ExamId = examId, SubjectId = subjectId, Mark1 = mark,
                        Pass = passed ? "Passed" : "Failed"});

                    db.SaveChanges();




                    this.Owner.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                    this.Owner.Show();
                    this.Close();

                }
            }


        }

        private void Answer1_CheckedChanged(object sender, EventArgs e)
        {
            
            choice++;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //MessageBox.Show("Вы выбрали " + radioButton.Text);

                answer = radioButton.Text;
            }
        }

        private void Answer2_CheckedChanged(object sender, EventArgs e)
        {
            choice++;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //MessageBox.Show("Вы выбрали " + radioButton.Text);
                answer = radioButton.Text;
            }
        }

        private void Answer3_CheckedChanged(object sender, EventArgs e)
        {
            choice++;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //MessageBox.Show("Вы выбрали " + radioButton.Text);
                answer = radioButton.Text;
            }
        }

        private void Answer4_CheckedChanged(object sender, EventArgs e)
        {
            choice++;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //MessageBox.Show("Вы выбрали " + radioButton.Text);
                answer = radioButton.Text;
            }
        }

        private void PrevQuestion_Click(object sender, EventArgs e)
        {
            //--counter;
            //qIndex--;
          
            
            //if (choice > 0)
            //{
            //    using (var db = new AcademyEntities())
            //    {
            //        choice = 0;
            //        counter--;
            //        aIndex = aIndex - 8;
            //        //qIndex--;
            //        //studentAnswers.Add(answer);


            //        if (questionCount >= counter)
            //        {

            //            QuestionText.Text = "Вопрос № " + counter.ToString() + ": " + allQuestions[qIndex].Question.Name;

            //            Answer1.Text = allAnswers[aIndex++].AnswerText;

            //            Answer2.Text = allAnswers[aIndex++].AnswerText;

            //            Answer3.Text = allAnswers[aIndex++].AnswerText;

            //            Answer4.Text = allAnswers[aIndex++].AnswerText;

            //            MessageBox.Show(answer);


            //        }
            //        else
            //        {
            //            MessageBox.Show("No more questions");
            //        }

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("You should choose an answer");
            //}
        }
    }
}
