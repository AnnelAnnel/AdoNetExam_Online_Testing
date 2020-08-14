using Academy.Teacher;
using Academy.Teacher.CreateExamsOption;
using Academy.Teacher.SeeExamsMarksOption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class Teachermenu : Form
    {
       
        public User user;
        public Teachermenu(User user)
        {
            InitializeComponent();            
            this.user = user;
            Greeting.Text = "Welcome, " + user.FName + " " + user.LName + "!";

        }

        private void Teachermenu_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();

        }

      

        private void SeeExams_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllExams allExams = new AllExams(user);
            allExams.Show();           
            this.AddOwnedForm(allExams);
        }

        private void CreateQuestions_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllQuestions allQuestions = new AllQuestions(user);
            allQuestions.Show();
            this.AddOwnedForm(allQuestions);

            
   
            //CreateQuestion createquestion = new CreateQuestion(user);
           // createquestion.Show();
            //this.AddOwnedForm(createquestion);
        }

        private void ExamMarks_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                if (db.Marks.Where(m => m.Subject.TeacherId == user.Id).Any())
                {
                    this.Hide();
                    ExamMarks examMarks = new ExamMarks(user);
                    examMarks.Show();
                    this.AddOwnedForm(examMarks);
                }
                else
                {
                    MessageBox.Show("No marks yet to show");
                    
                }
            }
        }
    }
}
