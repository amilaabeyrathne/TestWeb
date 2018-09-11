using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common.DTOs;
using Test.Data;
using Test.Data.UnitOfWorks;

namespace Test.Business
{
    public class StudentBusiness : IStudentBusiness
    {
        private UnitOfWorks unitofworks = new UnitOfWorks();
        string message = "s";
        public string AddStudent(StudentDTO studentDto)
        {
            Student student = new Student();
            student.StudentId = studentDto.StudentId;
            student.Studentname = studentDto.Studentname;

            try
            {
                unitofworks.StudentRopository.Insert(student);
                unitofworks.Save();
                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteStudent(string studentId)
        {
            try
            {
                unitofworks.StudentRopository.Delete(studentId);
                unitofworks.Save();
                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<StudentDTO> GetAll()
        {
            List<StudentDTO> lists = new List<StudentDTO>();

            try
            {
                var list = unitofworks.StudentRopository.GetAll();
                foreach (var item in list)
                {
                    StudentDTO dTO = new StudentDTO();
                    dTO.StudentId = item.StudentId;
                    dTO.Studentname = item.Studentname;

                    lists.Add(dTO);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return lists; 
        }

        public string Update(StudentDTO student)
        {
            try
            {
                var studentToUpdate = unitofworks.StudentRopository.GetById(student.StudentId);
                studentToUpdate.Studentname = student.Studentname;

                unitofworks.StudentRopository.Update(studentToUpdate);
                unitofworks.Save();
                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
