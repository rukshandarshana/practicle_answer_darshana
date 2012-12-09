using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    
    
    public partial class Student_Details : Form
    {
        //To access the database class
        DBAccess dba = new DBAccess();

        public string name;
        public string id;
        public string DOB;
        public string GradPoint;
        public string active;


        public Student_Details()
        {
            InitializeComponent();
             
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Student_Registration stdReg = new Student_Registration(this);
            stdReg.Show();
            
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSucess = false;
            int noOfRows = Convert.ToInt32(dgvStudentDetails.Rows.Count);
                 
            //Get each Row values of the gridview and send to the DBAccess class
                foreach (DataGridViewRow dr in dgvStudentDetails.Rows)
                {
                    //Cheack weather rows are empty
                    if (noOfRows > 1)
                    {
                        int gid = Convert.ToInt32(dr.Cells["dgvid"].Value);
                        string gname = dr.Cells["dgvname"].Value.ToString();
                        string gDOB = dr.Cells["dgvdateOfBirth"].Value.ToString();
                        float ggradePoint = float.Parse(dr.Cells["dgvgradePoint"].Value.ToString());
                        string gactive = dr.Cells["dgvactive"].Value.ToString();

                        //Call the database access class with values
                        if (dba.regStudent(gid, gname, gDOB, ggradePoint, gactive))
                        {
                            
                            isSucess = true;
                        }
                        else
                        {
                           
                            isSucess = false;
                        }
                    }
                    else
                    {
                        break;
                    }

                    noOfRows--;

                }

                if (isSucess)
                {
                    MessageBox.Show("Student Added Successfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed, Try Again");
                }
                dgvStudentDetails.Rows.Clear();

                btnSave.Enabled = false;
        }

        //Fill values in to the dataGrid view
        internal void loadGrid()
        {
            dgvStudentDetails.Rows.Add(id,name,DOB,GradPoint,active);
            if (dgvStudentDetails.Rows.Count > 1)
            {
                btnSave.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
