using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestKolekcija
{
    internal class Program
    {
        public static List<RedovniStudent> redovniStudenti = new List<RedovniStudent>();
        public static List<IzvanredniStudent> izvanredniStudenti = new List<IzvanredniStudent> {
            new IzvanredniStudent{Id=11, Grade=2.6, Model="A", Name="Markic", YearOfStudy=1},
            new IzvanredniStudent{Id=12, Grade=4.6, Model="B", Name="Ivanoje", YearOfStudy=2},
            new IzvanredniStudent{Id=13, Grade=3.6, Model="B", Name="Husein", YearOfStudy=3},
        };

        public static List<Student> samoIzvanredniStudenti = new List<Student>();


        static void Main(string[] args)
        {

            var lista = GetStudentList();
            //PrintResults(lista);
            #region zad1
            //linija 11 je kreiranje liste
            RedovniStudent student = new RedovniStudent { Id = 11, Grade = 3.5, Model = "A", Name = "Milivoj", YearOfStudy = 4 };
            redovniStudenti.Add(student);
            IzvanredniStudent student2 = new IzvanredniStudent { Id = 12, Grade = 4.8, Model = "B", Name = "Markec", YearOfStudy = 5 };
            //redovniStudenti.Add(student2); nije moguce posto je genericka lista pa unutra ide samo jedan tip

            #endregion

            #region zad2


            /* lista.AddRange(izvanredniStudenti);

             */
            #endregion

            #region zad3
            IzvanredniStudent izvanredni = new IzvanredniStudent { Id = 14, Grade = 3.8, Model = "B", Name = "HuseinBeg", YearOfStudy = 3 };
            //lista.Insert(9, izvanredni);
            //PrintResults(lista);

            #endregion

            #region zad4

            /* lista.RemoveAt(3);



             var novaLista = lista.RemoveAll(x => x.YearOfStudy == 2);*/

            // PrintResults(lista);

            #endregion

            #region zad5
            /*RemoveLastThree(lista);
            PrintResults(lista);*/

            #endregion

            #region zad6

            var broj = lista.Count();
            // Console.WriteLine("Ima " + broj + " studenata u listi");

            var prosjekVeciIliJednakCetri = lista.Count(s => s.Grade >= 4);

            // Console.WriteLine("Ima " + prosjekVeciIliJednakCetri + " studenata u listi koji imaju prosjek >=4");

            #endregion

            #region zad7
            var postojiPero = lista.Exists(s => s.Name.StartsWith("Pero")); //valjda je dobro
                                                                            // Console.WriteLine(postojiPero);

            #endregion

            #region zad8

            //Console.WriteLine(lista.Count(s=>s.Grade>3.0));

            //Console.WriteLine(lista.All(s => s.Grade > 3.0));

            //Console.WriteLine(lista.All(s => s.Grade > 2.5));

            #endregion

            #region zad9

            //Console.WriteLine(lista.Exists(s => s.Id == 5));

            //var idJePet = lista.Find(s => s.Id == 5);
            //PrintResults(idJePet);

            // lista.Remove(lista.Find(s => s.Id == 5));//mora ovak zato jer remove ko parametar prima objekt a find isto vraca objekt

            //lista.RemoveAll(s => s.Id == 5); //more se postici i s ovim jer RemoveAll mice sve koji zadovoljavaju uvjet
            //a isto prima objekt ko parametar
            //PrintResults(lista);

            //lista.Remove(s => s.Id == 5);

            #endregion

            #region zad10

            //Console.WriteLine(lista.First(s => s.YearOfStudy == 4));

            //var prviFirst = lista.First(s => s.YearOfStudy == 4);

            //PrintResults(prviFirst); //dodan testni korisnik radi testa

            //var prvi=lista.Find(s => s.YearOfStudy == 4);
            //PrintResults(prvi);
            #endregion

            #region zad11


            //var sviPrvaGodinaIProsjek35 = lista.FindAll(s => (s.YearOfStudy == 1 || s.YearOfStudy == 3) && s.Grade < 3.5);
            //moraju iti zagrade inace ne dela dobro
            //PrintResults(sviPrvaGodinaIProsjek35);
            #endregion

            #region zad12
            //kreiranje je gore
            var samoIzvanredni = lista.OfType<IzvanredniStudent>();

            samoIzvanredniStudenti.AddRange(samoIzvanredni);

            samoIzvanredniStudenti.Reverse();
            //PrintResults(samoIzvanredniStudenti);
            #endregion

            #region zad13
            var sortiranoPremaGodina = lista.OrderBy(s => s.YearOfStudy);
            //PrintResults(sortiranoPremaGodina);

            var premaImenuSilazno = lista.OrderByDescending(s => s.Name);
            PrintResults(premaImenuSilazno);
            #endregion





            //UPUTE - Otkomentirati jedan po jedan poziv metode i pratiti rezultate.

            //Example_Add(); ovo mi je ziher jasno
            //Example_AddRange(); ovo mi je ziher jasno
            //Example_Insert(); ovo mi je ziher jasno
            //Example_InsertRange(); ovo mi je ziher jasno

            //Example_Remove();     ovo mi je ziher jasno
            //Example_RemoveAll();  //ovo mi je ziher jasno
            //Example_RemoveAt();   ovo mi je ziher jasno
            //Example_RemoveRange();
            //Example_Clear();

            //Example_Count();

            //Example_Exists();
            //Example_Contains();
            //Example_All();
            //Example_Any();

            //Example_Find();
            //Example_First();
            //Example_FindLast();
            //Example_Last();
            //Example_FindAll();
            //Example_Where();
            //Example_OfType();

            //Example_Reverse();
            //Example_OrderBy();
            //Example_OrderByDescending();



            Console.ReadLine();
        }

        public static List<Student> RemoveLastThree(List<Student> studenti)
        {
            studenti.RemoveRange(studenti.Count - 3, 3);

            return studenti;
        }

        private static List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>()
               {
                   new RedovniStudent { Id = 1, Name = "Pero Perić", YearOfStudy = 3, Model = "A", Grade = 3.2 },
                   new IzvanredniStudent { Id = 2, Name = "Ivan Lukić", YearOfStudy = 2, Model = "B", Grade = 3.0},
                   new IzvanredniStudent { Id = 3, Name = "Ana Horvat", YearOfStudy = 2, Model = "A", Grade = 2.8},
                   new IzvanredniStudent { Id = 4, Name = "Marko Lukić", YearOfStudy = 1, Model = "B", Grade = 3.9},
                   new RedovniStudent { Id = 5, Name = "Luka Ivanović", YearOfStudy = 2, Model = "A", Grade = 4.0},
                   new IzvanredniStudent { Id = 6, Name = "Marija Horvatić", YearOfStudy = 3, Model = "B", Grade = 4.5},
                   new RedovniStudent { Id = 7, Name = "Ivana Ivić", YearOfStudy = 1, Model = "A", Grade = 3.1},
                   new IzvanredniStudent { Id = 8, Name = "Ana Perić", YearOfStudy = 1, Model = "B", Grade = 3.4},
                   new RedovniStudent { Id = 9, Name = "Pero Anić", YearOfStudy = 1, Model = "A", Grade = 3.5},
                   new IzvanredniStudent { Id = 10, Name = "Matej Ivanović", YearOfStudy = 2, Model = "B", Grade = 4.8},
                   new IzvanredniStudent { Id = 18, Name = "Testni Korisnik", YearOfStudy = 4, Model = "B", Grade = 4.8},
               };

            return students;
        }





        private static void PrintResults(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                PrintResults(student);
            }
        }

        private static void PrintResults(Student student)
        {
            if (student != null)
            {
                Console.WriteLine(student.DisplayInfo());
            }
            else
            {
                Console.WriteLine("No such student!");
            }

        }

        #region Dodavanje elemenata u listu

        private static void Example_Add()
        {
            var students = GetStudentList();

            var novi = new RedovniStudent { Id = 11, Name = "Marko Perić", YearOfStudy = 3, Model = "A" };
            students.Add(novi);

            PrintResults(students);
        }

        private static void Example_AddRange()
        {
            var students = GetStudentList();

            Student[] array = new Student[3];
            array[0] = new RedovniStudent { Id = 12, Name = "Marko Horvat", YearOfStudy = 3, Model = "A" };
            array[1] = new IzvanredniStudent { Id = 13, Name = "Mirko Anić", YearOfStudy = 2, Model = "B" };
            array[2] = new RedovniStudent { Id = 14, Name = "Luka Ivić", YearOfStudy = 1, Model = "A" };

            students.AddRange(array);

            PrintResults(students);
        }

        private static void Example_Insert()
        {
            var students = GetStudentList();

            var s = new RedovniStudent { Id = 11, Name = "Marko Perić", YearOfStudy = 3, Model = "A" };
            students.Insert(3, s);

            PrintResults(students);
        }

        private static void Example_InsertRange()
        {
            var students = GetStudentList();

            Student[] array = new Student[3];
            array[0] = new RedovniStudent { Id = 12, Name = "Marko Horvat", YearOfStudy = 3, Model = "A" };
            array[1] = new IzvanredniStudent { Id = 13, Name = "Mirko Anić", YearOfStudy = 2, Model = "B" };
            array[2] = new RedovniStudent { Id = 14, Name = "Luka Ivić", YearOfStudy = 1, Model = "A" };

            students.InsertRange(3, array);

            PrintResults(students);
        }

        #endregion

        #region Brisanje elemenata iz liste

        private static void Example_Remove()
        {
            var students = GetStudentList();

            var pero = students[8];
            bool removalSuccesful = students.Remove(pero);

            PrintResults(students);
        }

        private static void Example_RemoveAll()
        {
            var students = GetStudentList();
            students.RemoveAll(s => s.Model == "B");

            PrintResults(students);
        }

        private static void Example_RemoveAt()
        {
            var students = GetStudentList();
            students.RemoveAt(8);

            PrintResults(students);
        }

        private static void Example_RemoveRange()
        {
            var students = GetStudentList();
            students.RemoveRange(5, 3);

            PrintResults(students);
        }

        private static void Example_Clear()
        {
            var students = GetStudentList();
            students.Clear();

            PrintResults(students);
        }

        #endregion

        #region Prebrojavanje elemenata

        private static void Example_Count()
        {
            var students = GetStudentList();

            int count = students.Count(s => s.YearOfStudy == 1 && s.Model == "A");

            Console.WriteLine($"There is total of {count} students.");
        }

        #endregion

        #region Provjera postojanja elemenata u listi i zadovoljavanja uvjeta

        private static void Example_Contains()
        {
            var students = GetStudentList();

            var pero = students[8];
            bool peroExists = students.Contains(pero);

            if (peroExists == true)
            {
                Console.WriteLine("The provided student is containted in the list!");
            }
            else
            {
                Console.WriteLine("The provided student is NOT containted in the list!");
            }
        }

        private static void Example_Exists()
        {
            var students = GetStudentList();

            bool exists = students.Exists(s => s.Name == "Pero Anić" && s.YearOfStudy == 2);

            if (exists == true)
            {
                Console.WriteLine("There IS a student in the list with specified characteristics!");
            }
            else
            {
                Console.WriteLine("There is NO student in the list with specified characteristics!");
            }
        }

        private static void Example_All()
        {
            var students = GetStudentList();
            bool isTrue = students.All(s => s.Model == "A" || s.Model == "B");

            if (isTrue)
            {
                Console.WriteLine("All students are either A or B model!");
            }
            else
            {
                Console.WriteLine("Not all students are either A or B model!");
            }
        }

        private static void Example_Any()
        {
            var students = GetStudentList();
            bool isTrue = students.Any(s => s.YearOfStudy == 3 && s.Grade > 4);

            if (isTrue)
            {
                Console.WriteLine("There is at least one student with specified characteristics!");
            }
            else
            {
                Console.WriteLine("There is no students with specified characteristics!");
            }
        }

        #endregion

        #region Dohvaćanje elementa/elemenata iz liste

        private static void Example_Find()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.Find(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);

            Student nonExistingStudent = students.Find(s => s.YearOfStudy == 5);
            PrintResults(nonExistingStudent);
        }

        private static void Example_First()
        {
            var students = GetStudentList();

            //Pronalazi prvog studenta u listi koji se nalazi na prvoj godini
            Student firstYearStudent = students.First(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);

            //S obzirom da u listi nemamo studenta na 5 godini, vratiti će defaultnu vrijednost (null)
            Student nonExistingStudent = students.FirstOrDefault(s => s.YearOfStudy == 5);
            PrintResults(nonExistingStudent);
        }

        private static void Example_FindLast()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.FindLast(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);
        }

        private static void Example_Last()
        {
            var students = GetStudentList();

            Student firstYearStudent = students.Last(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent);
            Student firstYearStudent1 = students.LastOrDefault(s => s.YearOfStudy == 1);
            PrintResults(firstYearStudent1);
        }

        private static void Example_FindAll()
        {
            var students = GetStudentList();

            //Pronalazi sve studente druge godine koji su po A modelu
            List<Student> secondYearStudents = students.FindAll(s => s.YearOfStudy == 2 && s.Model == "A");
            PrintResults(secondYearStudents);
        }

        private static void Example_Where()
        {
            var students = GetStudentList();

            IEnumerable<Student> secondYearStudents = students.Where(s => s.YearOfStudy == 2 && s.Model == "A");
            PrintResults(secondYearStudents);
        }

        private static void Example_OfType()
        {
            var students = GetStudentList();
            IEnumerable<RedovniStudent> regularStudents = students.OfType<RedovniStudent>();
            PrintResults(regularStudents);
        }

        #endregion

        #region Promjena redoslijeda elemenata u listi

        private static void Example_Reverse()
        {
            var students = GetStudentList();
            students.Reverse();

            PrintResults(students);
        }

        private static void Example_OrderBy()
        {
            var students = GetStudentList();
            IEnumerable<Student> sortedByGrades = students.OrderBy(s => s.Grade).ToList();

            PrintResults(sortedByGrades);
        }

        private static void Example_OrderByDescending()
        {
            var students = GetStudentList();
            IEnumerable<Student> sortedByGrades = students.OrderByDescending(s => s.Grade);

            PrintResults(sortedByGrades);
        }

        #endregion
    }
}
