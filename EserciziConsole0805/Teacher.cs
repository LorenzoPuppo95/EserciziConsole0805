using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziConsole0805
{
    internal class Teacher
    {
        public string Name { get; set; } = string.Empty;    
        public string Surname { get; set; } = string.Empty;    
        public string Subject { get; set; } = string.Empty;   

        public Student[] Students { get; set; } = Array.Empty<Student>();

        public Teacher(string name, string surname, string subject, Student[] students)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            Students = students;
        }
        
        public void AssignStudent(Student student)
        {
            List<Student> studentList = Students.ToList();
            studentList.Add(student);
            Students = studentList.ToArray();
        }
        public void UnassignStudent(Student student)
        {
            List<Student> studentList = Students.ToList();
            studentList.Remove(student);
            Students = studentList.ToArray();
        }
        public void WriteTeacherForm()
        {
            Console.WriteLine($"Nome: {Name}, Cognome: {Surname}, Materia: {Subject}");
            if (Students.Length == 0)
            {
                Console.WriteLine("Nessuno studente assegnato.");
            }
            else
            {
                Console.WriteLine("Lista studenti:");
                foreach (var student in Students)
                {
                    Console.WriteLine($"- {student.Name} {student.Surname}");
                }
            }
            Console.WriteLine("-------------------------");
        }
        public void SimpleWriteTeacher()
        {
            Console.WriteLine($"Insegnante {Name} {Surname} di {Subject}");
            Console.WriteLine("-------------------------");
        }
        public double CalculateOverallMean()
        {
            if (Students.Length == 0)
            {
                Console.WriteLine("Nessuno studente assegnato.");
                return 0;
            }
            double totalMean = 0;
            foreach (var student in Students)
            {
                totalMean += student.CalculateMean();
            }
            return totalMean / Students.Length;
        }
    }
}
