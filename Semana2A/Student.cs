using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2A
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int IdStudent, string FirstName, string LastName) 
        {
            this.IdStudent = IdStudent;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
