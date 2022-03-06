using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.STUDENT_SYSTEM
{
    class Student
    {
        static int counter = 0;
        public Student()
        {
            this.Id = ++counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public int GroupId { get; set; }
        public override string ToString()
        {
            return $"({Id}. {Name}. {Birthdate:mm.dd.yyyy}";

        }

    }
}
