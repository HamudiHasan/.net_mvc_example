using LogicLayer.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace LogicLayer.DataLogic
{
    public class StudentDBAccess
    {
        public bool Insert(Student students)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", students.Id),
                new SqlParameter("@Name",students.Name),
                new SqlParameter("@StudentID", students.StudentID)
            };

            return SqlDBHelper.ExecuteNonQuery("insertStudent", CommandType.StoredProcedure, parameters);
        }

        public bool Update(Student students)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", students.Id),
                new SqlParameter("@Name", students.Name),
                 new SqlParameter("@StudentID", students.StudentID)
            };

            return SqlDBHelper.ExecuteNonQuery("updateStudent", CommandType.StoredProcedure, parameters);
        }

        public bool DeleteById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return SqlDBHelper.ExecuteNonQuery("deleteStudentById", CommandType.StoredProcedure, parameters);
        }

        public Student GetById(int id)
        {
            Student studentInfo   = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("getStudentById", CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    //Lets go ahead and create the list of employees
                    studentInfo = new Student();

                    //Now lets populate the employee details into the list of employees                                           
                    studentInfo.Id = Convert.ToInt32(row["Id"]);
                    studentInfo.Name = row["Name"].ToString();
                    studentInfo.StudentID = row["StudentID"].ToString();
                    
                }
            }

            return studentInfo;
        }
        public bool getBool(string str)
        {
            if (str.Equals("Yes"))
                return true;

            else if (str.Equals("NO"))
                return false;
            return false;
        }
        public List<Student> GetAll()
        {
            List<Student> studentList = null;

            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand("getStudents", CommandType.StoredProcedure))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of employees
                    studentList = new List<Student>();

                    //Now lets populate the employee details into the list of employees
                    foreach (DataRow row in table.Rows)
                    {
                        Student personalInfo = new Student();

                        personalInfo.Id = Convert.ToInt32(row["Id"]);
                        personalInfo.Name = row["Name"].ToString();
                        personalInfo.StudentID = row["StudentID"].ToString();
                        studentList.Add(personalInfo);
                    }
                }
            }

            return studentList;
        }        
    }
}
