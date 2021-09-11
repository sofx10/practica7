using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica090921
{
    class Student
    {
        public int idStudent { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }
        public string nacionalidad { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>
            {
            new Student {idStudent=1001, firstName="Brianna", lastName= "Castillo", age=19, nacionalidad = "Mexicana"},
            new Student {idStudent=1002, firstName="Melanie", lastName= "Ascencio", age=18, nacionalidad = "Colombiana"},
            new Student {idStudent=1003, firstName="Monica", lastName= "Hernandez", age=22, nacionalidad = "Dominicana"},
            new Student {idStudent=1004, firstName="Majorie", lastName= "Cortez", age=20, nacionalidad = "Hondureña"},
            new Student {idStudent=1005, firstName="Francisco", lastName= "Cruz", age=25, nacionalidad = "Salvadoreño"},
            };

            return Students;
        }

    }
}
    

