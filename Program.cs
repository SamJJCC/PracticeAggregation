using System.Security.Cryptography.X509Certificates;

namespace PracticeAggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            prog124.AddStudent("Ana", "Mendez", 100, 100);
            prog124.AddStudent("Sam", "Jimenez", 100, 100);
            prog124.AddStudent("Jay", "Uon", 100, 100);

            Console.WriteLine(prog124);

            foreach (Student student in SchoolProgram._classRoster)
            {
                Console.WriteLine(student);
            }
            
          




            
          
        }
       
    }
}
