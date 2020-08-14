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
    public partial class EditQuestion : Form
    {
        public int id;
        public User teacher;
        public EditQuestion(User teacher, int id)
        {
            this.teacher = teacher;
            this.id = id;
            InitializeComponent();
        }

        private void EditQuestion_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var question = db.Questions.Find(id);

                var subjects = from s in db.Subjects
                               where s.TeacherId == teacher.Id

                               select new
                               {
                                   Id = s.Id,
                                   Name = s.Name,
                                   Teacher = s.User.FName + " " + s.User.LName

                               };

                SubjectsView.DataSource = subjects.ToList();


                QuestionText.Text = question.Name;



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
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    var editedQuestion = academyDb.Questions.Find(id);

                    if (QuestionText.Text != "")
                    {


                        editedQuestion.Name = QuestionText.Text;

                        editedQuestion.SubjectId= Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);
                        academyDb.SaveChanges();
                        this.Owner.Show();
                        this.Close();


                    }
                    //else if ()
                    //{
                    //    MessageBox.Show("Do not leave any field empty!");
                    //}
                    else
                    {
                        MessageBox.Show("Do not leave any field empty!");
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

        private void QuestionText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
