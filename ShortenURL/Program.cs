using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base62
{
    class Program
    {
        static void Main(string[] args)
        {
            //All possible base characters
            const string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Base62 ASCII
            const int count = 62;
            //Get input from user
            long input = long.Parse((Console.ReadLine()));
            //Create place to store output
            StringBuilder output = new StringBuilder("");

            do
            {
                output.Insert(0, characters[(int)(input % count)]);
                input = input / count;
            }
            while (input > 0);

            Console.WriteLine(output.ToString());
            Console.ReadLine();
        }
    }
}
