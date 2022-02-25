using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_deneme2.Models
{
    public class Repository
    {
        private static List<Student> students = new List<Student>();
        public static List<Student> Students
        {
            get
            {
                return students;
            }
        }
        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
