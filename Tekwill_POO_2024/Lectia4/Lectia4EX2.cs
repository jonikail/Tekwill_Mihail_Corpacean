using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia4
{
    internal class Lectia4EX2
    {
        //Implementarea in Main...

        //Manager manager = new Manager("Ion Stati", "HR");

        //manager.AfisareDetalii();


    }

    public class Angajat
    {
        
        public string nume { get; private set; }

        
        public Angajat(string Nume)
        {
            nume = Nume;
        }

       
        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Nume angajat: {nume}");
        }
    }

    public class Manager : Angajat
    {
        
        public string Departament { get; private set; }

       
        public Manager(string Nume, string departament) : base(Nume)
        {
            Departament = departament;
        }

    
        public override void AfisareDetalii()
        {
            base.AfisareDetalii(); 
            Console.WriteLine($"Departament: {Departament}");
        }
    }









}
