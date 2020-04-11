using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arif", 21);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 45, "190345", "Informatika");
            teacher.GetNameAndAge();

            Student student = new Student("Arif H", 20, "19.11.2617", "arif.hidayatullah@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}