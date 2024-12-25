using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia3
{
    internal class Lectia3EX1
    {

        public void RunMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                string password = Helper.GenerareCodUnic("KPK");
                Console.WriteLine($"{i + 1} Your Password: {password}");
            }

        }





    }

    public static class Helper
    {
        private static Random random = new Random();

        public static string GenerareCodUnic(string prefix)
        {

            int randomNumber = random.Next(100, 10000);
            return $"{prefix}-{randomNumber}";
        }
    }











}
