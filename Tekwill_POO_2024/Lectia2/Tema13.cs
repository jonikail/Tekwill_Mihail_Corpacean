using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia2
{
    internal class Tema13
    {
        // EX1 MAIN
        //Angajat angajat1 = new Angajat("Mihail Cor",3000,"UTM");
        //Angajat angajat2 = new Angajat("Ion Pasari", 4500, "SCS");
        //Angajat angajat3 = new Angajat("Ghiorghe Topa", 8500, "USRS");
        //angajat1.AfisareDetalii();
        //Console.WriteLine("\n");
        //angajat2.AfisareDetalii();
        //Console.WriteLine("\n");
        //angajat3.AfisareDetalii();


        //EX2 MAIN


        //PersoanaBank persoana = new PersoanaBank("1234567890123", "Fizică");

        //PersoanaBank persoana1 = new PersoanaBank("0223232132","Juridic");


        //ContBancar cont = new ContBancar("RO123BANK0000000001", "MDL", persoana, "1234");

        //ContBancar cont1 = new ContBancar("R0321321312KS32123","EURO",persoana1 , "1212");

    }

    public class Angajat
    {

        public string nume;
        public int salariu;
        public string departament;



        public Angajat(string nume, int salariu, string departament)
        {
            this.nume = nume;
            this.salariu = salariu;
            this.departament = departament;
        }

        public void AfisareDetalii()
        {
            Console.WriteLine("Info Angajati");
            Console.WriteLine($"Nume: {nume}");
            Console.WriteLine($"Salariu: {salariu} Lei");
            Console.WriteLine($"Departament: {departament}");
        }
    }




    //Ex 2 cu banca


    public class PersoanaBank
    {
        public string Id { get; set; }
        public string TipPersoana { get; set; }

        public PersoanaBank(string id, string tipPersonaa)
        {

            Id = id;
            TipPersoana = tipPersonaa;



        }


    }
    public class ContBancar
    {
        public string numarCont { get; private set; }

        public string moneda { get; private set; }
        public DateTime dataCreare { get; private set; }
        public PersoanaBank proprietar { get; private set; }

        private string pin;

        private List<Tuple<string, decimal>> istoricTranzactii;

        public ContBancar(string NumarCont, string Moneda, PersoanaBank Proprietar, string Pin)
        {
            numarCont = NumarCont;
            moneda = Moneda;
            proprietar = Proprietar;
            pin = Pin;
            dataCreare = DateTime.Now;
            istoricTranzactii = new List<Tuple<string, decimal>>();

        }

        public decimal DeterminaSold()
        {
            decimal sold = 0;

            foreach (var tranzactie in istoricTranzactii)
            {

                sold += tranzactie.Item2;

            }
            return sold;

        }

        public void AlimentareCont(decimal suma)
        {
            if (suma <= 0)
            {
                Console.WriteLine("Suma pentru alimentare trebuie sa fie pozitiva.");
                return;
            }
            istoricTranzactii.Add(new Tuple<string, decimal>("Alimentare", suma));
            Console.WriteLine($"Contul a fost alimentat cu {suma} {moneda}.");

        }
        public bool ExtrageFond(decimal suma)
        {
            if (suma <= 0)
            {
                Console.WriteLine("Suma pentru extragere trebuie sa fie pozitiva.");
                return false;
            }

            if (DeterminaSold() >= suma)
            {
                istoricTranzactii.Add(new Tuple<string, decimal>("Extragere", -suma));
                Console.WriteLine($"Suma de {suma} {moneda} a fost extrasa din cont.");
                return true;
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente pentru extragere.");
                return false;
            }


        }
    }








}
