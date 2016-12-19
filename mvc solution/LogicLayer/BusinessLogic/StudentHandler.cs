using LogicLayer.BusinessObjects;
using LogicLayer.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.BusinessLogic
{
    public class StudentHandler
    {
        // Handle to the Employee DBAccess class
        StudentDBAccess  studentInfoDb = null;

        public StudentHandler()
        {
            studentInfoDb = new StudentDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool Insert(Student  studentInfo)
        {
            return studentInfoDb.Insert(studentInfo);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool Update(Student studentInfo)
        {
            return studentInfoDb.Update(studentInfo);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteById(int id)
        {
            return studentInfoDb.DeleteById(id);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Student GetById(int id)
        {
            return studentInfoDb.GetById(id);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Student> GetAll()
        {
            return studentInfoDb.GetAll();
        }
    }
}
