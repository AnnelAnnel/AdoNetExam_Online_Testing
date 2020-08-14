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
    public partial class CreateExamDialog : Form
    {
        public User teacher;

        public CreateExamDialog(User teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Short;
            //date.Value = new DateTime(2019, 10, 3);


        }

        private void CreateExams_Load(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var subjects = from s in db.Subjects
                               where s.TeacherId == teacher.Id
                               select new
                               {
                                   Id = s.Id,
                                   Name = s.Name,
                                   Teacher = s.User.FName + " " + s.User.LName
                               };

                SubjectsView.DataSource = subjects.ToList();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime examDate = dateTimePicker1.Value;
            //MessageBox.Show(examDate.ToShortDateString());
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AcademyEntities())
                {
                    if (ExamName.Text != "")
                    {
                        // int teacherId = Convert.ToInt32(TeachersView.CurrentRow.Cells["Id"].Value);
                        var nameTest = db.Exams.FirstOrDefault(l => l.Name == ExamName.Text);
                        if (nameTest == null)
                        {

                            var name = ExamName.Text;

                            DateTime eDate = dateTimePicker1.Value;

                            int subjectId = Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);


                            db.Exams.Add(new Exam { Name = name, Date = eDate, SubjectId = subjectId });
                            db.SaveChanges();
                            this.Owner.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("An exam with the same name already exists!");
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

        


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var subjects = from s in db.Subjects
                               where s.TeacherId == teacher.Id
                               select new
                               {
                                   Id = s.Id,
                                   Name = s.Name,
                                   Teacher = s.User.FName + " " + s.User.LName
                               };

                SubjectsView.DataSource = subjects.ToList();
            }
        }
    }
}
