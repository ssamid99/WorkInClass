using System;

namespace INTHERANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Aqil";
            student.SurName = "Abbasov";
            

            Doctor doctor = new Doctor();
            doctor.Name = "Aqil";
            doctor.SurName = "dasddsa";
            doctor.Salary = 444;

            student.Talk();
            doctor.Talk();

        }
    }
}
