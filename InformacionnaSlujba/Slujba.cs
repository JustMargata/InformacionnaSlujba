using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionnaSlujba
{
    internal class Slujba
    {
        private string city;
        private string name;
        private int age;
        private string gender;
        private string adress;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Godinite trqbva da sa mejdu 18 i 60");
                }
                age = value;
            }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Slujba(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Slujba(string city, string name, int age, string gender, string adress)
        {
            this.City = city;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Adress = adress;
        }
        public void Print()
        {
            Console.WriteLine($"Grad: {this.City} Ime: {this.Name} Godini: {this.Age} Pol: {this.Gender} Adres: {this.Adress}");
        }

        internal void PrintNameAndAge()
        {
            Console.WriteLine($"Ime: {this.Name} Godini: {this.Age}");
        }
    }
}
