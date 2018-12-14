using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    class Apple : Product
    {
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {

        }

        public static Apple operator + (Apple ap1, Apple ap2)
        {
            int calories = (int)Math.Round((ap1.Calorie + ap2.Calorie) / 2.0, 0);
            int volume = ap1.Volume + ap2.Volume;
            return new Apple("Apple", calories, volume);
        }

        public static bool operator == (Apple ap1, Apple ap2)
        {
            return ap1.Calorie == ap2.Calorie && ap1.Volume == ap2.Volume;
        }

        public static bool operator != (Apple ap1, Apple ap2)
        {
            return ap1.Calorie != ap2.Calorie || ap1.Volume != ap2.Volume;
        }
    }
}
