using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Common.DTOs
{
    public class StudentDTO
    {
        public string StudentId { get; set; }
        public string Studentname { get; set; }

        public Nullable<int> IsDelete { get; set; }
    }
}
