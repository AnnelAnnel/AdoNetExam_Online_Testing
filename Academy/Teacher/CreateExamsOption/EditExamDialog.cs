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
    public partial class EditExamDialog : Form
    {
        public int id;
        public EditExamDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EditExamDialog_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var examToEdit = academyDb.Exams.Find(id);

                ExamName.Text = examToEdit.Name;

                ExamDate.Value = examToEdit.Date;

                var subjects = from s in academyDb.Subjects
                               where s.Id == examToEdit.SubjectId
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    var editedExam = academyDb.Exams.Find(id);

                    if (ExamName.Text != "")
                    {


                        editedExam.Name = ExamName.Text;
                        editedExam.Date = ExamDate.Value;
                        int subjId= Convert.ToInt32(SubjectsView.CurrentRow.Cells["Id"].Value);
                        editedExam.SubjectId = subjId;
                        academyDb.SaveChanges();
                        MessageBox.Show("Exam information has been successfully changed");
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
    }
}
