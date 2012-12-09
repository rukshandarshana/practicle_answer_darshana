using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentRegistrationSystem
{
    public partial class Student_Registration : Form
    {

        Random random;
        public int id;
        public string name;
        public string DOB;
        public string GradPoint;
        public string active;

        Student_Details originalForm;

        public Student_Registration(Student_Details incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }



        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbActive.Checked)
            {
                active = "true";
            }
            else
            {
                active = "false";
            }

            //Check text fields validations
            if (name == null || GradPoint == null)
            {
                MessageBox.Show("Please Correct the errors");
            }

            //Assign values to the Data Gridview
            else
            {
                originalForm.id = txtid.Text;
                originalForm.name = txtname.Text;
                originalForm.DOB = dtpDOB.Value.Date.ToString("yyyy-MM-dd");
                originalForm.GradPoint = txtGPoint.Text;
                originalForm.active = active;

                originalForm.loadGrid();

                this.Close();
            }
        }


        private void Student_Registration_Load(object sender, EventArgs e)
        {
            random = new Random();
            id = random.Next(100000);
            txtid.Text = id.ToString();
            
        }

        //Validation of Name field, Empty or Not
        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
                errorProvi.SetError(txtname, "Please enter the student name.");
            else
            {
                name = txtname.Text;
                errorProvi.Clear();
            }   
        }

        private void txtGPoint_MouseLeave(object sender, EventArgs e)
        {
           
        }

        //Validation of Grade Point AVG
        private void txtGPoint_Leave(object sender, EventArgs e)
        {
            bool isMatch = Regex.IsMatch(txtGPoint.Text.ToString(), @"^[0-4]{1}([\.\,][0-9]{2}?)$");

            if (txtGPoint.Text.Trim().Length == 0)
            {
                errorProvi.SetError(txtGPoint, "Please enter the Average Grade Point");
            }

            else if (!isMatch || float.Parse(txtGPoint.Text) > 4 || float.Parse(txtGPoint.Text) < 0)
            {
                
                errorProvi.SetError(txtGPoint, "Please enter the Correct Format Average Grade Point");
            }
            else
            {

                GradPoint = txtGPoint.Text;
                errorProvi.Clear();

            }
        }

        
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtGPoint.Text = "";
            cbActive.Checked = false;
            
        }
    }
}
