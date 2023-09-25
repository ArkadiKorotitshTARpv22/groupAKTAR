using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace groupAKTAR
{

    public class Info

    {

        public string _nimi;
        public int _age;
        public string _race;
        public Info(string nimi, int age, string status)
        {
            this._nimi = nimi;
            this._age = age;
            this._race = status;
        }
        public Info() { }

        public string Nimi
        {
            get => _nimi;
            set => _nimi = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Race
        {
            get => _race;
            set => _race = value;
        }


        public void readinfo()
        {
            Console.WriteLine();
            Console.WriteLine("Nimi = " + Nimi);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("Race = " + Race);
        }



    }
}
