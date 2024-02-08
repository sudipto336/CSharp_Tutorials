using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_VS_Non_Static
{
    internal class StaticNonStaticExample
    {
        int x = 10;
        static int y = 20;
        int z;

        static StaticNonStaticExample()
        {
            Console.WriteLine("Static constr is called");
        }

        public StaticNonStaticExample(int z)
        {
            Console.WriteLine("Non static constr is called");
            this.z = z;
        }

        public static void Add()
        {
            StaticNonStaticExample example = new StaticNonStaticExample(30);
            Console.WriteLine($"Sum: {example.x + y + example.z}");
            Console.WriteLine($"Sum: {example.x + StaticNonStaticExample.y + example.z}");
        }

        public void Multiply()
        {
            Console.WriteLine($"Multiplcation result: {this.x * y * z}");
            Console.WriteLine($"Multiplcation result: {x * StaticNonStaticExample.y * this.z}");
        }
    }
}
