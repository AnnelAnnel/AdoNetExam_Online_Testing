using Academy.Student;
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
    public partial class StudentMenu : Form
    {
        public User user;
      
        public StudentMenu(User user)
        {
            InitializeComponent();            
            this.user = user;
            if (user.GroupId != null)
            {
                Greeting.Text = "Welcome, " + user.FName + " " + user.LName+ " from "+user.Group.Name + "!";
            }
            else                
            {
                Greeting.Text = "Welcome, " + user.FName + " " + user.LName+ "!";
            }

        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();

        }

        private void PassExams_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {

                if (user.GroupId!=null)
                {
                    if (db.Exams.Any() && db.RSGs.Where(rs => rs.GroupId == user.GroupId).Any())
                    {
                        this.Hide();
                        PassExams passExams = new PassExams(user);
                        passExams.Show();
                        this.AddOwnedForm(passExams);
                    }
                    else
                    {
                        MessageBox.Show("No exams, groups or subjects exist");

                    }
                }
                else
                {
                    MessageBox.Show("You were not added to any group!");

                }
            }
        }

        private void SeeMarks_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                if (user.GroupId != null)
                {
                    if (db.Marks.Where(m => m.StudentId == user.Id).Any())
                    {
                        this.Hide();
                        SeeMarks seeMarks = new SeeMarks(user);
                        seeMarks.Show();
                        this.AddOwnedForm(seeMarks);
                    }
                    else
                    {
                        MessageBox.Show("No marks yet to show");

                    }
                }
                else
                {
                    MessageBox.Show("You were not added to any group!");

                }
               
            }
        }
    }
}
