using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // uzdevums Nr.1__________________________________________________
            Console.WriteLine(" Telefona_ modelis:");
            string ModelA = Console.ReadLine();

            Telefons tel_liet_1 = new Telefons(ModelA);
            Console.WriteLine("Telefona marka:");
            tel_liet_1.Marka = Console.ReadLine();
            Console.WriteLine(" Augstums,cm: ");
            string _height_text = Console.ReadLine();
            tel_liet_1.Height = double.Parse(_height_text);
            Console.WriteLine(" Platums,cm: ");
            string _width_text = Console.ReadLine();
            tel_liet_1.Width = double.Parse(_width_text);
            Console.WriteLine(" Garums,cm: ");
            string _length_text = Console.ReadLine();
            tel_liet_1.Length = double.Parse(_length_text);

            Console.WriteLine(" Telefona_ modelis:");
            string ModelB = Console.ReadLine();

            Telefons tel_liet_2 = new Telefons(ModelB);
            Console.WriteLine("Telefona marka:");
            tel_liet_2.Marka = Console.ReadLine();
            Console.WriteLine(" Augstums,cm: ");
            _height_text = Console.ReadLine();
            tel_liet_2.Height = double.Parse(_height_text);
            Console.WriteLine(" Platums,cm: ");
            _width_text = Console.ReadLine();
            tel_liet_2.Width = double.Parse(_width_text);
            Console.WriteLine(" Garums,cm: ");
            _length_text = Console.ReadLine();
            tel_liet_2.Length = double.Parse(_length_text);

            string telefona_dati1 = tel_liet_1.Telefona_dati();
            Console.WriteLine(telefona_dati1);
            string telefona_dati2 = tel_liet_2.Telefona_dati();
            Console.WriteLine(telefona_dati2);

            tel_liet_1.zvans();
            tel_liet_1.sms();
            //uzdevums Nr.2____________________________________________________

            cars car1 = new cars();
             car1.MARKA = "BMW";
            car1.NUMURZIME = "AA0055";
            car1.ATRUMS = 0;
            double atrums = car1.ATRUMS;
            car1.ATRUMS = cars.SAKAM_BRAUKT(atrums);
            atrums = car1.ATRUMS;
            car1.ATRUMS = cars.PAATRINAJUMS(atrums);
            atrums = car1.ATRUMS;
            car1.ATRUMS = cars.PAATRINAJUMS(atrums);
            atrums = car1.ATRUMS;
            car1.ATRUMS = cars.PAATRINAJUMS(atrums);
            car1.BEEP();
            atrums = car1.ATRUMS;
            car1.ATRUMS = cars.BREMZESANA(atrums);
            car1.ATRUMS = cars.APSTASANAS(atrums);

            // Uzdevums Nr.3 ___________________________________________________

            prece prece1 = new prece();
            prece1.PRECES_DATI();

            // uzdevums Nr. 4

                person persona1 = new person();
                int dz_gads = persona1.DZ_GADS;
                int dz_men = persona1.DZ_MEN;
                int dz_datums = persona1.DZ_DATUMS;
                persona1.PERSONAS_DATI(dz_gads, dz_men, dz_datums);
            
        }
    }
}