using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    public class Cow : Animal
    {
        public Cow()
        {
            Name = "Elsie";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says Moo!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} snores!");
        }
    }
}
