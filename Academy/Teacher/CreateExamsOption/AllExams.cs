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
    public partial class AllExams : Form
    {
        public User teacher;

        public AllExams(User teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void AllExams_Load(object sender, EventArgs e)
        {
            TeacherName.Text = "All exams of " + teacher.FName + " " + teacher.LName + ":";
            using (var db = new AcademyEntities())
            {

                            var exams = from ex in db.Exams
                            where ex.Subject.TeacherId==teacher.Id

                            select new
                            {
                                Id = ex.Id,
                                ExamName = ex.Name,
                                ExamDate = ex.Date,
                                Subject = ex.Subject.Name

                            };

                ExamsView.DataSource = exams.ToList();

            }
        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CreateExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateExamDialog createExams = new CreateExamDialog(teacher);
            createExams.Show();
            this.AddOwnedForm(createExams);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {

                    if (academyDb.Exams.Any())
                    {
                        var id = Convert.ToInt32(ExamsView.CurrentRow.Cells["Id"].Value);
                        var exam = academyDb.Exams.Find(id);
                        if (!(academyDb.Marks.Where(exm => exm.ExamId == id).Any()))
                        {
                            if (academyDb.REQs.Where(exm => exm.ExamId == id).Any())
                            {                               
                                academyDb.REQs.RemoveRange(academyDb.REQs.Where(exm => exm.ExamId == id));    

                            }

                            academyDb.Exams.Remove(exam);
                            academyDb.SaveChanges();
                            MessageBox.Show("Exam " + exam.Name + " was deleted");

                        }

                        else
                        {

                            MessageBox.Show("Exam " + exam.Name + " cannot be deleted as it was passed by some of the students");
                        }
                    }

                    else
                    {
                        MessageBox.Show("No exams existed!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EcitExam_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Exams.Any())
                {
                    this.Hide();

                    var id = Convert.ToInt32(ExamsView.CurrentRow.Cells["Id"].Value);

                    EditExamDialog editExamDialog = new EditExamDialog(id);
                    editExamDialog.Show();

                    this.AddOwnedForm(editExamDialog);
                }

                else
                {
                    MessageBox.Show("No exams existed!");
                }
            }
        }

        private void AddQuestions_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {

                if (academyDb.Exams.Any())
                {
                    this.Hide();

                    var id = Convert.ToInt32(ExamsView.CurrentRow.Cells["Id"].Value);

                    AddQuestions addQuestions = new AddQuestions(id);

                    addQuestions.Show();
                    this.AddOwnedForm(addQuestions);
                }

                else
                {
                    MessageBox.Show("No exams existed!");
                }
            }
        }
    }
}
