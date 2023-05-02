using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAggregation
{
    internal class SchoolProgram
    {

        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor;
        List<Student> _classRoster;


       public SchoolProgram(string className,string classNumber, string roomNumber,Instructor instuctor)
        {
            _classRoster = new List<Student>();
            _instructor = Instructor;
        }



        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Instructor Instructor { get => _instructor; set => _instructor = value; }
        internal List<Student> ClassRoster { get => _classRoster;}

        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName,int csiGrade,int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {

            return $"{ClassName}: {ClassNumber}: {RoomNumber}: {Instructor}:";
          
                


        }

            
            
           
        
    }
}
