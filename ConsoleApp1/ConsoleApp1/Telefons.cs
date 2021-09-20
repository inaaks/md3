using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Telefons
    {
        public Telefons (string _model)
        { Model = _model; }
        public string Model { get; set; }
        public string Marka  { get; set; }
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = Math.Abs(value);
            }
        }
        private double _width;
        public double Width 
        {
            get
            {
                return _width;
            }

            set
            {
                _width = Math.Abs(value);
            }
        }

        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = Math.Abs(value);
            }
        }

        public string Telefona_dati()
        {
            string _telefona_dati =  "Model " + Model + " Marka " + Marka +  " Izmēri " + Length + "x" + Width + "x" + Height;
                return _telefona_dati;
        }
        public void sms()
        {
            Console.WriteLine (" Sūtu SMS");
        }
        public void zvans()
        {
            Console.WriteLine("Telefona numurs");
            string _telefona_numurs = Console.ReadLine();
            Console.WriteLine("Zvans uz telefonu" + _telefona_numurs);
           
         }
    }
}
