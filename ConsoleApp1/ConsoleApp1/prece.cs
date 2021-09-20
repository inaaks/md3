using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class prece
    {
        private string artikuls;
      
        public string ARTIKULS
        {
            get
            {
                Console.WriteLine("Prece:");
                artikuls = Console.ReadLine();
                return artikuls;
            }
        }
        private string _garums;
        private double garums;
        public double GARUMS
        {
            get
            {
                Console.WriteLine("Garums:");
                _garums = Console.ReadLine();
                garums = double.Parse(_garums);
                return garums;
            }
            }
        private string _platums;
        private double platums;

        public double PLATUMS
        {
            get
            {
                Console.WriteLine("Platums:");
                _platums = Console.ReadLine();
                platums = double.Parse(_platums);
                return platums;
            }
            
        }
        private string _svars;
        private double svars;

        public double SVARS
        {
            get
            {
                Console.WriteLine("Svars:");
                _svars = Console.ReadLine();
                svars = double.Parse(_svars);
                return platums;
            }

        }


        public void PRECES_DATI()
        {
            Console.WriteLine("Prece:" + ARTIKULS + ",Platums:" + PLATUMS + ",Garums" + GARUMS + ",Svars:" + SVARS);
        }
    }

}
