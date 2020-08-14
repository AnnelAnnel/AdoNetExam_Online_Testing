using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Admin.CreateSubjesctsOption
{
    public partial class EditSubjectDialog : Form
    {
        public int id;
        public EditSubjectDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EditSubjectDialog_Load(object sender, EventArgs e)
        {
            using (AcademyEntities academyDb = new AcademyEntities())
            {
                
                var subject = academyDb.Subjects.Find(id);

                SNameTextBox.Text = subject.Name;

                var TNames = academyDb.Users.Where(u => u.RoleId == 2);

                foreach (var t in TNames)
                {

                    if (t.Id == subject.TeacherId)
                    {
                        TeachersBox.Items.Add(t.Id + ". " + t.FName + " " + t.LName + " - Current");
                    }
                    else
                    {
                        TeachersBox.Items.Add(t.Id + ". " + t.FName + " " + t.LName);
                    }
                }


            }
        }


        private void TeachersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = TeachersBox.SelectedItem.ToString();
            

        }

        private void Save_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (AcademyEntities academyDb = new AcademyEntities())
                {
                    var editedSubject = academyDb.Subjects.Find(id);

                    if (SNameTextBox.Text != "" && TeachersBox.Text!="")
                    {
                        

                        editedSubject.Name = SNameTextBox.Text;


                        string selectedState = TeachersBox.SelectedItem.ToString();
                        int end = selectedState.IndexOf('.');

                        var newTeacherId = selectedState.Substring(0, end);
                       

                        editedSubject.TeacherId = Convert.ToInt32(newTeacherId);                        

                        academyDb.SaveChanges();
                        this.Owner.Show();
                        this.Close();


                    }
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

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }
    }

}
