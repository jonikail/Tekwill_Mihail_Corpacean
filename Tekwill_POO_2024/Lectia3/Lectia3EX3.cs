using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia3
{
    internal class Lectia3EX3
    {
        ////Emplementarea in Main
        //Student student = new Student("Ion Radu", 23, "FCIM-TI");
        //Student copie = new Student(student);

        //student.AfisareDetaliiStudent();
        //copie.AfisareDetaliiStudent();

    }

    public class Student 
    {

        public string Nume;
        public int Varsta;
        public string Specialitate;
        public Student(string nume , int varsta , string specialitate)
        {
            Nume = nume;
            Varsta = varsta;
            Specialitate = specialitate;
        }

        public Student(Student copie)
        {
            Nume =copie.Nume;
            Varsta = copie.Varsta;
            Specialitate = copie.Specialitate;
            
        }



        public void AfisareDetaliiStudent()
        {
            Console.WriteLine($"Info Student \n Nume Student: {Nume}\n Varsta Student: {Varsta} Ani \n Specialitate: {Specialitate}");
        }




    }

        
}
