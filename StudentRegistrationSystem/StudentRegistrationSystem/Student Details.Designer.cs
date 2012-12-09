namespace StudentRegistrationSystem
{
    partial class Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudentDetails = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgradePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentDetails
            // 
            this.dgvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvname,
            this.dgvdateOfBirth,
            this.dgvgradePoint,
            this.dgvactive});
            this.dgvStudentDetails.Enabled = false;
            this.dgvStudentDetails.Location = new System.Drawing.Point(12, 22);
            this.dgvStudentDetails.Name = "dgvStudentDetails";
            this.dgvStudentDetails.Size = new System.Drawing.Size(545, 261);
            this.dgvStudentDetails.TabIndex = 0;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "Student ID";
            this.dgvid.Name = "dgvid";
            // 
            // dgvname
            // 
            this.dgvname.HeaderText = "Name";
            this.dgvname.Name = "dgvname";
            // 
            // dgvdateOfBirth
            // 
            this.dgvdateOfBirth.HeaderText = "Date Of Birth";
            this.dgvdateOfBirth.Name = "dgvdateOfBirth";
            // 
            // dgvgradePoint
            // 
            this.dgvgradePoint.HeaderText = "Grade Point Avg";
            this.dgvgradePoint.Name = "dgvgradePoint";
            // 
            // dgvactive
            // 
            this.dgvactive.HeaderText = "Active";
            this.dgvactive.Name = "dgvactive";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(81, 318);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvStudentDetails);
            this.Name = "Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Details";
            this.Load += new System.EventHandler(this.Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentDetails;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgradePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvactive;
        private System.Windows.Forms.Button button1;
    }
}