using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EserciziConsole0805;

//Student + Array di interi che sono i marks
//printare la media dello studente inserito
//poi fallo con una lista di studenti
//creare scheda studente (tostring) e montare una scheda dello studente compresa la media e printare tutto
namespace EserciziConsole0805
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        private int _yob;
        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1920)
                {
                    _yob = 1920;
                }
                else
                {
                    _yob = value;
                }
            }
        }
        public int[] Marks { get; set; }

        public Student(string name, string surname, string gender, int yob, int[] marks)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
            Marks = marks;
        }

        public double CalculateMean()
        {
            int sum = 0;
            foreach (var mark in Marks)
            {
                sum += mark;
            }
            return (double)sum / Marks.Length;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            return currentYear - Yob;
        }
        public void AddMark(int mark)
        {
            List<int> marksList = Marks.ToList();
            marksList.Add(mark);
            Marks = marksList.ToArray();
        }
        public void SimpleWriteStudent()
        {
            Console.WriteLine($"La media dello studente {Name} {Surname} è {CalculateMean():F2}");
            Console.WriteLine("-------------------------");
        }
        public void WriteStudentForm()
        {
            string concatenatedMarks = string.Join("-", Marks);
            Console.WriteLine($"Nome: {Name}, Cognome: {Surname}, Genere: {Gender}, " +
                              $"Anno Di Nascita: {Yob}, Età: {CalculateAge()}, " +
                              $"Lista Voti: {concatenatedMarks}, Media Voti: {CalculateMean():F2}");
            Console.WriteLine("-------------------------");
        }
        public void AddStudentFromConsole()
        {
            Console.WriteLine("Inserisci il nome dello studente:");
            while (true)
            {
                Name = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    break;
                }
                Console.WriteLine("Nome non valido. Inserisci un nome non vuoto:");
            }
            Console.WriteLine("Inserisci il cognome dello studente:");
            while (true)
            {
                Surname = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(Surname))
                {
                    break;
                }
                Console.WriteLine("Cognome non valido. Inserisci un cognome non vuoto:");
            }
            Console.WriteLine("Inserisci il genere dello studente:");
            while (true)
            {
                Gender = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(Gender))
                {
                    break;
                }
                Console.WriteLine("Genere non valido. Inserisci un genere non vuoto:");
            }
            Console.WriteLine("Inserisci l'anno di nascita dello studente:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int yob))
                {
                    if (yob < 1920)
                    {
                        Console.WriteLine("Anno troppo vecchio! Inserisci un anno di nascita valido (>= 1920):");
                    }
                    else
                    {
                        Yob = yob;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Anno di nascita non valido. Inserisci un numero intero:");
                }
            }
            Console.WriteLine("Inserisci i voti dello studente (separati da uno spazio):");
            string[] marksInput = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
            Marks = new int[marksInput.Length];
            for (int i = 0; i < marksInput.Length; i++)
            {
                while (true)
                {
                    if (int.TryParse(marksInput[i], out int mark))
                    {
                        if (mark >= 1 && mark <= 100)
                        {
                            Marks[i] = mark;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Voto non valido: ({mark}). Inserisci un voto compreso tra 1 e 100:");
                            marksInput[i] = Console.ReadLine() ?? "0";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Voto non valido: non numerico. Inserisci un numero intero compreso tra 1 e 100:");
                        marksInput[i] = Console.ReadLine() ?? "0";
                    }
                }
            }
        }
    }
}
