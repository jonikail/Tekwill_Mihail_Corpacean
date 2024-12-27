using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia4
{
    internal class Lectia4EX1
    {
        //Implementarea in Main
        //Animal caine = new Caine();
        //Animal pisica = new Pisica();

        //Console.WriteLine("Polimorfism:");
        //caine.MakeSound();
        //caine.Eat();

        //pisica.MakeSound();
        //pisica.Eat();


        //IRunnable runnableCaine = new Caine();
        //IRunnable runnablePisica = new Pisica();

        //Console.WriteLine("\nInterfata Runnable:");
        //runnableCaine.Run();
        //runnablePisica.Run();




    }

    public abstract class Animal 
    {


        public abstract void MakeSound();
        
        public virtual void Eat() 
     {

      Console.WriteLine("Animal is Eating....");
        
     }
    
    
       
    
    }
    public interface IRunnable
    {
        void Run();
    }

    public class Caine : Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cainele Latra");
        }

        public override void Eat()
        {
            Console.WriteLine("Cainele Mananca Oase");
        }

        public void Run()
        {
            Console.WriteLine("Cainele Alearga");
        }
    }

    public class Pisica : Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Pisica Miau");
        }

        public override void Eat()
        {
            Console.WriteLine("Pisica Mananca Peste");
        }

        public void Run()
        {
            Console.WriteLine("Pisica Alearga");
        }
    }


}
