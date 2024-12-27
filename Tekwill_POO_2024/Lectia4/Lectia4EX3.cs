using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia4
{
    internal class Lectia4EX3
    {

        //Implementarea in Main a programului pentru Teste........
        //Mamifer mamifer = new Mamifer("Ornitorinc", "Maro");
        //Pasare pasare = new Pasare("Vrabie", "Intensiv");
        //Papagal papagal = new Papagal("Rally", "Vesnic", "Unidimensional");
        //Console.WriteLine("Mamifer Info");
        //mamifer.AfisareDetaliiExercitiulTrei();
        //Console.WriteLine("Pasarea Info");
        //pasare.AfisareDetaliiExercitiulTrei();
        //Console.WriteLine("Papagal Info");
        //papagal.AfisareDetaliiExercitiulTrei();

    }

    public class AnimalExercitulTrei 
    {

        public string nume { get; set; }

        public AnimalExercitulTrei(string Nume)
        {
            nume = Nume;
        }

        public virtual void AfisareDetaliiExercitiulTrei() 
        {
            Console.WriteLine($"Animal: {nume}");
        }



    }

    public class Mamifer : AnimalExercitulTrei
    {
        public string culoareBlana { get; set; }

        public Mamifer(string nume, string CuloareBlana) : base(nume)
        {
            culoareBlana = CuloareBlana;
            
        }
        public override void AfisareDetaliiExercitiulTrei()
        {
            base.AfisareDetaliiExercitiulTrei();
            Console.WriteLine($"Culoare Blana: {culoareBlana}");
        }





    }

    public class Pasare : AnimalExercitulTrei
    {
        public string tipZbor {  get; set; }

        public Pasare(string nume , string TipZbor) : base(nume)
        {
            tipZbor = TipZbor;
        }

        public override void AfisareDetaliiExercitiulTrei()
        {
            base.AfisareDetaliiExercitiulTrei();
            Console.WriteLine($"Tipul Zbor: {tipZbor}");
        }
        
    }

    public class Papagal : Pasare 
    {
       public string vocabular {  get; set; }

        public Papagal(string nume,string TipZbor,string Vocabular) : base (nume,TipZbor)
        {
            vocabular = Vocabular;
            
        }

        public override void AfisareDetaliiExercitiulTrei()
        {
            base.AfisareDetaliiExercitiulTrei();
            Console.WriteLine($"Vocabular: {vocabular}");
        }


    }

















}
