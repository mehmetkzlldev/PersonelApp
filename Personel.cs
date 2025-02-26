using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }

        private int yas;
        public int Yas 
        {
            get  
            {
                return yas;
            }
            set
            {
                
                if (value > 0)
                {
                    yas = value;
                }
            }
        }
    }
}