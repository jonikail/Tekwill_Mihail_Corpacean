using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia3
{
    public class Lectia3EX2
    {
        //Apelarea in Main
        //Carte carte = new Carte("Harap Alb", "Ghiorghe Topa", 2013, 345);
        //Carte carte1 = new Carte("Cei Trei Purcelusi", "Mike Tayson", 2000, 543);
        //carte.AfisareDetalii();
        //carte1.AfisareDetalii();



    }

    public class Carte
    {
        public string Titlu;
        public string Autor;
        public int AnPublicare;
        public int NumarPagini;

        public Carte(string titlu, string autor, int anPublicare, int numarPagini)
        {
            Titlu = titlu;
            Autor = autor;
            AnPublicare = anPublicare;
            NumarPagini = numarPagini;

        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Info Carte \n Titlul Carti:{Titlu}\n Autorul Cartii: {Autor} \n Anul Publicarii: {AnPublicare} \n Numarul de Pagin: {NumarPagini}  ");

        }

    }










}
