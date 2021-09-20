using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class person

    {
        private string name;
        public string NAME
        {
            get
            {
                Console.WriteLine(" Labdien, Jūsu vārds ir");
                name = Console.ReadLine();
                return name;
            }
        }
        private string surname;
        public string SURNAME
        {
            get
            {
                Console.WriteLine("Jūsu uzvārds ir");
                surname = Console.ReadLine();
                return surname;

            }
        }


        private string hobbi;
        public string HOBBI
        {
            get
            {
                Console.WriteLine(" Jūsu hobijs ir");
                hobbi = Console.ReadLine();
                return hobbi;
            }
        }
        private int dz_gads;
        private string _dz_gads;
        public int DZ_GADS
        {
            get
            {
                Console.WriteLine("Jūsu dzimšanas gads ir");
                _dz_gads = Console.ReadLine();
                dz_gads = int.Parse(_dz_gads);
                return dz_gads;
            }



        }

        private int dz_men;
        private string _dz_men;
        public int DZ_MEN
        {
            get
            {
                Console.WriteLine("Jūsu dzimšanas mēnesis ir");
                _dz_men = Console.ReadLine();
                dz_men = int.Parse(_dz_men);
                return dz_men;
            }
        }
        private int dz_datums;
        private string _dz_datums;

        public int DZ_DATUMS
        {
            get
            {
                Console.WriteLine("Jūsu dzimšanas datums ir");
                _dz_datums = Console.ReadLine();
                dz_datums = int.Parse(_dz_datums);
                return dz_datums;
            }
        }


        public void PERSONAS_DATI(int dz_gads1, int dz_men, int dz_datums)
        {

            DateTime dat1 = new DateTime(dz_gads, dz_men, dz_datums);
            DateTime dat2 = DateTime.Now;
            TimeSpan interval = dat2 - dat1;
            int days = interval.Days;
            Console.WriteLine(days);
            int age = days / 365;

            Console.WriteLine("Labdien," + NAME + SURNAME + "Jums ir " + age + " gadi. Jūsu hobbijs " + HOBBI);
        }
    }
}
