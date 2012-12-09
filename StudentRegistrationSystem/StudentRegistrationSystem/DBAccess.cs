using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentRegistrationSystem
{
    public class DBAccess
    {
        SqlConnection conn;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }

        //Addition of the Student details in to the database
        public bool regStudent(int gid, string gname, string gDOB, double ggradePoint, string gactive)
        {
            bool status = false;
            SqlParameter par = null;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.StoredProcedure;
                newCmd.CommandText = "AddStudent";

                //Assign values to storeprocedure parameters
                par = newCmd.Parameters.Add("@studentID", SqlDbType.Int);
                par.Value = gid;
                par = newCmd.Parameters.Add("@name", SqlDbType.VarChar, 150);
                par.Value = gname;
                par = newCmd.Parameters.Add("@dob", SqlDbType.DateTime);
                par.Value = gDOB;
                par = newCmd.Parameters.Add("@gradepoint", SqlDbType.Float);
                par.Value = ggradePoint;
                par = newCmd.Parameters.Add("@active", SqlDbType.VarChar, 10);
                par.Value = gactive;

                newCmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Primary Key Duplicated");
            }
            status = true;
            return status;
        }
    }
}
