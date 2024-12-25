using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia4
{
    internal class Lectia4EX1
    {
    }

    public abstract class Animal 
    {

        protected Animal()
        {
            
        }
        //public abstract void MakeSound() 
        // {

        // }

        public virtual void Eat() 
     {

      Console.WriteLine("Animal is Eating....");
        
     }
    
     public interface IRunneble
     {
            void Run();
     }
       
    
    }

    public class Caine : Animal
    {
        
    }
    public class Pisica : Animal 
    {
    
    }


}
