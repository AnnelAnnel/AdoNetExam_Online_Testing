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
    public partial class SeeMarks : Form
    {
        public User student;
        public SeeMarks(User student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void SeeMarksOption_Load(object sender, EventArgs e)
        {
           

            using(var db=new AcademyEntities())
            {
                var st = db.Users.Find(student.Id);
               label1.Text = "Student: " + st.FName + " " + st.LName + "\nGroup: " + st.Group.Name;
                var marks = from m in db.Marks
                            where m.StudentId == student.Id
                            select new
                            {
                                Id = m.Id,
                                Exam=m.Exam.Name,
                                Subject=m.Subject.Name,
                                Date=m.Exam.Date,
                                Mark=m.Mark1,
                                Pass=m.Pass

                            };

                MarksView.DataSource = marks.ToList();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
