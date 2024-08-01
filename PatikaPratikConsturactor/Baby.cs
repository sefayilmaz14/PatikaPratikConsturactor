using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaPratikConsturactor
{
    public class Baby
    {
        //Field tanımlamaları
        private string _name;
        private string _surname;
        private DateTime _birthDate;
        //Propetry tanımlamaları
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        //Default Constructor tanımlaması
        public Baby()
        {
            Console.WriteLine("INGAAAAAAAAAAAA");
            DateTime birthDate = DateTime.Now;// Ekrana ınga yazı geldikten sonra programın çalıştığı zamanı alan değişken
            Console.WriteLine($"Doğum zamanı:{birthDate}");

        }
        //Parametre alan Constructor tanımlaması
        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("INGAAAAAAAAAAAAAA");
            DateTime birthDate = DateTime.Now;// Ekrana ınga yazı geldikten sonra programın çalıştığı zamanı alan değişken
            Console.WriteLine($"Doğum zamanı: {birthDate}");

        }
        //Bilgileri konsola yazdıran method
        public void Display()
        {
            Console.WriteLine($"Bebeğin İsmi:{Name} Soyismi:{Surname}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
