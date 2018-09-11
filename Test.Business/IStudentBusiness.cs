using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common.DTOs;

namespace Test.Business
{
    interface IStudentBusiness
    {
        string AddStudent(StudentDTO student);
        string Update(StudentDTO student);

        string DeleteStudent(string studentID);

        List<StudentDTO> GetAll();

    }
}
