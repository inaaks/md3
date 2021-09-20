using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class cars
    {
        public string MARKA { get; set; }
        public string NUMURZIME { get; set; }
        public double ATRUMS { get; set; }
        private double atrums;
       public static double SAKAM_BRAUKT(double atrums)
        {
            atrums = 10;
           Console.WriteLine("Sakam braukšanu");
           return atrums;
        }


        public static double PAATRINAJUMS(double atrums)
        {
            atrums = atrums + 10;
            Console.WriteLine("Ātrums - " + atrums);
            return atrums;
        }
        public void BEEP()
        {
            Console.WriteLine("BEEP");
        }
        public static double BREMZESANA(double atrums)
        {
            atrums = atrums - 10;
            Console.WriteLine("Ātrums - " + atrums);
            return atrums;
        }
        public static double APSTASANAS(double atrums)
        {
            atrums = 0;
            Console.WriteLine("Apstāšanās");
            return atrums;
        }

    }

}
