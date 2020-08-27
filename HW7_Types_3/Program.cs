using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Types_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();

            state2.country = new Country();
            state2.country.x = 5;
            state1 = state2;
            state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                                  // указывают на один объект в хипе
            Console.WriteLine(state1.country.x); // 8
            Console.WriteLine(state2.country.x); // 8

            Console.Read();
        }
    }
    struct State
    {
        public int x;
        public int y;
        public Country country;
    }
    class Country
    {
        public int x;
        public int y;
    }
}