using System.IO;
using Tekwill_OOP_2024.Lectia3;
using Tekwill_OOP_2024.Lectia4;
namespace Tekwill_OOP_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mamifer mamifer = new Mamifer("Ornitorinc", "Maro");
            Pasare pasare = new Pasare("Vrabie","Intensiv");
            Papagal papagal = new Papagal("Rally","Vesnic","Unidimensional");
            Console.WriteLine("Mamifer Info");
            mamifer.AfisareDetaliiExercitiulTrei();
            Console.WriteLine("Pasarea Info");
            pasare.AfisareDetaliiExercitiulTrei();
            Console.WriteLine("Papagal Info");
            papagal.AfisareDetaliiExercitiulTrei();





            Console.ReadKey();
        }

    }
}
