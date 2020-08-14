using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Admin.CreateGroupsOption
{
    public partial class AddStudentsDialog : Form
    {
        public int id;
        public AddStudentsDialog(int id)
        {
            InitializeComponent();
            this.id=id;
            using(var db=new AcademyEntities())
            {
                var students = from u in db.Users
                               where u.RoleId == 3
                               where u.GroupId == null
                               select new
                               {

                                   Id = u.Id,
                                   FName = u.FName,
                                   LName = u.LName,
                                   Phone = u.Phone

                               };

                StudentsChoiceView.DataSource = students.ToList();

                var group = db.Groups.Find(id);

                GroupName.Text = group.Name;

                var addedStudents = from u in db.Users
                                    where u.RoleId == 3
                                    where u.GroupId == id
                                    select new
                                    {

                                        Id = u.Id,
                                        FName = u.FName,
                                        LName = u.LName,
                                        Phone = u.Phone

                                    };

                AddedStudents.DataSource = addedStudents.ToList();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateGroupDialog_Load(object sender, EventArgs e)
        {

        }

        private void StudentsChoiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
          
            using (var db = new AcademyEntities())
            {

                var freeStudents = db.Users.Where(d=>d.RoleId==3).Where(f => f.GroupId == null).FirstOrDefault();
                if (freeStudents!=null) {
                    int studentId = Convert.ToInt32(StudentsChoiceView.CurrentRow.Cells["Id"].Value);


                    var addedStudent = db.Users.Find(studentId);


                    addedStudent.GroupId = id;

                    db.SaveChanges();

                    var students = from u in db.Users
                                   where u.RoleId == 3
                                   where u.GroupId == null
                                   select new
                                   {

                                       Id = u.Id,
                                       FName = u.FName,
                                       LName = u.LName,
                                       Phone = u.Phone

                                   };



                    StudentsChoiceView.DataSource = students.ToList();



                    var addedStudents = from u in db.Users
                                        where u.RoleId == 3
                                        where u.GroupId == id
                                        select new
                                        {

                                            Id = u.Id,
                                            FName = u.FName,
                                            LName = u.LName,
                                            Phone = u.Phone

                                        };

                    AddedStudents.DataSource = addedStudents.ToList();
                }
                else
                {
                    MessageBox.Show("No free students!");
                }
            }
        }

        private void UdpateBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {
                var students = from u in db.Users
                               where u.RoleId == 3
                               where u.GroupId == null
                               select new
                               {

                                   Id = u.Id,
                                   FName = u.FName,
                                   LName = u.LName,
                                   Phone = u.Phone

                               };

                StudentsChoiceView.DataSource = students.ToList();

                var group = db.Groups.Find(id);

                GroupName.Text = group.Name;

                var addedStudents = from u in db.Users
                                    where u.RoleId == 3
                                    where u.GroupId == id
                                    select new
                                    {

                                        Id = u.Id,
                                        FName = u.FName,
                                        LName = u.LName,
                                        Phone = u.Phone

                                    };

                AddedStudents.DataSource = addedStudents.ToList();
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyEntities())
            {

                var studentsOfGroup = db.Users.Where(d => d.RoleId == 3).Where(f => f.GroupId == id).FirstOrDefault();
                if (studentsOfGroup != null)
                {
                    int studentId = Convert.ToInt32(AddedStudents.CurrentRow.Cells["Id"].Value);


                    var addedStudent = db.Users.Find(studentId);


                    addedStudent.GroupId = null;

                    db.SaveChanges();

                    var students = from u in db.Users
                                   where u.RoleId == 3
                                   where u.GroupId == null
                                   select new
                                   {

                                       Id = u.Id,
                                       FName = u.FName,
                                       LName = u.LName,
                                       Phone = u.Phone

                                   };



                    StudentsChoiceView.DataSource = students.ToList();



                    var addedStudents = from u in db.Users
                                        where u.RoleId == 3
                                        where u.GroupId == id
                                        select new
                                        {

                                            Id = u.Id,
                                            FName = u.FName,
                                            LName = u.LName,
                                            Phone = u.Phone

                                        };

                    AddedStudents.DataSource = addedStudents.ToList();
                }
                else
                {
                    MessageBox.Show("No students in the group!");
                }
            }
        }
    }
}
