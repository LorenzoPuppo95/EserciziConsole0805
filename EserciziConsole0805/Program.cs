namespace EserciziConsole0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1: Studente singolo");

            Student[] students = new Student[3];
            students[0] = new Student("Mario", "Rossi", "Maschio", 2000, new int[] { 80, 90, 85 });
            double mean = students[0].CalculateMean();
            Console.WriteLine($"La media dello studente {students[0].Name} {students[0].Surname} è {mean}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 2: Array di studenti");

            students[1] = new Student("Luigi", "Verdi", "Maschio", 1998, new int[] { 75, 80, 70 });
            students[2] = new Student("Anna", "Bianchi", "Femmina", 2001, new int[] { 95, 100, 90 });

            for (int i = 0; i < students.Length; i++)
            {
                double studentMean = students[i].CalculateMean();
                Console.WriteLine($"La media dello studente {students[i].Name} {students[i].Surname} è {studentMean}");
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Esercizio 3: Lista di studenti schedati");
            for (int i = 0; i < students.Length; i++)
            {
                double studentMean = students[i].CalculateMean();
                int studentAge = students[i].CalculateAge();
                int[] values = students[i].Marks;
                string concatenatedMarks = string.Join("-", values);
                Console.WriteLine($"Nome: {students[i].Name}, Cognome: {students[i].Surname}, Genere: {students[i].Gender}, " +
                    $"Anno Di Nascita: {students[i].Yob}, Età: {studentAge}, Lista Voti: {concatenatedMarks}, Media Voti: {studentMean}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
