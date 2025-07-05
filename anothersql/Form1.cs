using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anothersql
{
    public partial class Form1 : Form
    {
        StudentDBContext db = new StudentDBContext();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = fname.Text,
                LastName = lname.Text,
                Age = int.Parse(txtage.Text),
                StudentID = int.Parse(txtid.Text)

            };
            db.Students.Add(student);
            db.SaveChanges();
            LoadData();
            MessageBox.Show("Student added sucecessfully");
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            txtage.Text = "";
            txtid.Text = "";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                StudentID = int.Parse(txtid.Text),
                FirstName = fname.Text,
                LastName = lname.Text,
                Age = int.Parse(txtage.Text)
                
            };
            db.Students.AddOrUpdate(student);
            db.SaveChanges();
            LoadData();
            MessageBox.Show("Student Updated sucecessfully");
            
        
    }

        private void Delete_Click(object sender, EventArgs e)
        {
            int StudentID = int.Parse(txtid.Text);

            Student student = db.Students.FirstOrDefault(s => s.StudentID == StudentID);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Student Deleted sucecessfully");
                
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }
        }
}