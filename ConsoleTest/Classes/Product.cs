using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Calorie { get; set; }
        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }

        protected Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }

            if (calorie <= 0)
            {
                throw new ArgumentException(nameof(calorie));
            }

            if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }

            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}\nCalorie: {Calorie}\nVolume: {Volume}\nEnergy: {Energy}";
        }
    }
}
