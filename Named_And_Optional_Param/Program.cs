namespace Named_And_Optional_Param
{
    internal class Program
    {
        //Required params
        static int Add (int x, int y)
        {
            return x + y;
        }

        //Required and optional params
        static int Add(int x, int y, int z, int w = 1)
        {
            return x + y + z + w;
        }

        static void Main(string[] args)
        {
            //int result1 = Add(5);//throws compile time error as need to pass arg for all required param
            int resultWithoutNamedAndWithRequiredParam = Add (5, 6);
            int resultWithNamedAndWithRequiredParam = Add(y: 5, x: 6);
            int resultWithoutNamedAndWithOptionalParam = Add (5, 6, 7);
            int resultWithNamedAndWithOptionalParam = Add (y: 5, x: 6, z: 7);
            Console.WriteLine($"Result without named and with required param: {resultWithoutNamedAndWithRequiredParam}");
            Console.WriteLine($"Result with named and with required param: {resultWithNamedAndWithRequiredParam}");
            Console.WriteLine($"Result without named and with optional param: {resultWithoutNamedAndWithOptionalParam}");
            Console.WriteLine($"Result with named and with optional param: {resultWithNamedAndWithOptionalParam}");
        }
    }
}
