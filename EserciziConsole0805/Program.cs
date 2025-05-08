namespace EserciziConsole0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1: Studente singolo");
            Student[] students = new Student[3];
            students[0] = new Student("Mario", "Rossi", "Maschio", 2000, new int[] { 80, 90, 85 });
            students[0].SimpleWriteStudent();
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Esercizio 2: Array di studenti");
            students[1] = new Student("Luigi", "Verdi", "Maschio", 1998, new int[] { 75, 80, 70 });
            students[2] = new Student("Anna", "Bianchi", "Femmina", 2001, new int[] { 95, 100, 90 });
            foreach (var student in students)
            {
                student.SimpleWriteStudent();
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Esercizio 3: Lista di studenti schedati");
            foreach (var student in students)
            {
                student.WriteStudentForm();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 4: Lista di insegnanti");
            Teacher[] teachers = new Teacher[2];
            teachers[0] = new Teacher("Giovanni", "Neri", "Matematica", new Student[] { students[0], students[1] });
            teachers[1] = new Teacher("Maria", "Gialli", "Italiano", new Student[] {  });
            foreach (var teacher in teachers)
            {
                teacher.SimpleWriteTeacher();
                teacher.WriteTeacherForm();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 5: Assegnazione di uno studente a un insegnante");
            teachers[1].AssignStudent(students[2]);
            Console.WriteLine($"Studente {students[2].Name} {students[2].Surname} assegnato all'insegnante {teachers[1].Name} {teachers[1].Surname}");
            foreach (var teacher in teachers)
            {
                teacher.WriteTeacherForm();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 6: Disassegnazione di uno studente da un insegnante");
            teachers[1].UnassignStudent(students[2]);
            Console.WriteLine($"Studente {students[2].Name} {students[2].Surname} disassegnato dall'insegnante {teachers[1].Name} {teachers[1].Surname}");
            foreach (var teacher in teachers)
            {
                teacher.WriteTeacherForm();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 7: Aggiunta di un voto a uno studente");
            int newMark = 88;
            students[0].AddMark(newMark);
            Console.WriteLine($"Voto {newMark} aggiunto allo studente {students[0].Name} {students[0].Surname}.");
            students[0].WriteStudentForm();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 8: Calcolo della media dei voti degli studenti di un insegnante");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Media complessiva degli studenti dell'insegnante {teacher.Name} {teacher.Surname}: {teacher.CalculateOverallMean():F2}");
                Console.WriteLine("-------------------------");

            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 9: Aggiunta di uno studente da console");
            Student newStudent = new Student("", "", "", 0, new int[] { });
            newStudent.AddStudentFromConsole();
            Console.WriteLine($"Studente {newStudent.Name} {newStudent.Surname} aggiunto.");
            newStudent.WriteStudentForm();
        }
    }
}
