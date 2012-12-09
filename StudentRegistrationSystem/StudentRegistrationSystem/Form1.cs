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
    public partial class Form1 : Form
    {
        DBAccess dba = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }



        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details stdDetail= new Student_Details();
            //stdDetail.MdiParent = this;
            stdDetail.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
