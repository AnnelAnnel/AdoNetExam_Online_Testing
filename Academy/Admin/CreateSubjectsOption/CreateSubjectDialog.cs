using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Admin
{
    public partial class CreateSubjectDialog : Form
    {
        public CreateSubjectDialog()
        {
            InitializeComponent();
        }

        private void CreateSubject_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                var teachers = from t in academyDb.Users
                               where t.RoleId == 2
                               select new
                               {
                                   Id = t.Id,
                                   FName = t.FName,
                                   LName = t.LName

                               };


                TeachersView.DataSource = teachers.ToList();


            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }



        private void CreateSubj_Click(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                try
                {

                    if (SubjName.Text != "")
                    {
                       // int teacherId = Convert.ToInt32(TeachersView.CurrentRow.Cells["Id"].Value);
                        var nameTest = academyDb.Subjects.FirstOrDefault(l => l.Name == SubjName.Text);
                        if (nameTest == null)
                        {

                            var name = SubjName.Text;


                            int teacherId = Convert.ToInt32(TeachersView.CurrentRow.Cells["Id"].Value);

                            academyDb.Subjects.Add(new Subject { Name = name, TeacherId = teacherId });
                            academyDb.SaveChanges();
                            this.Owner.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A subject with the same name already exists!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill in all fields!");
                    }

                }
                catch (Exception ex)
                {
                    this.Owner.Show();
                    this.Close();
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
