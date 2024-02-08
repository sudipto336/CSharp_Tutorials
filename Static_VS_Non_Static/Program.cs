namespace Static_VS_Non_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaticNonStaticExample.Add();
            StaticNonStaticExample example = new StaticNonStaticExample(40);    
            example.Multiply();

            Console.WriteLine("***********************************************");

            Console.WriteLine("Please select temperature conversion direction: ");
            Console.WriteLine("1. From Celsius to Fahrenheit");
            Console.WriteLine("2. From Fahrenheit to Celsius");
            Console.Write(": ");

            string selection = Console.ReadLine();

            double F, C = 0;
            
            switch (selection) {
                case "1":
                    Console.WriteLine("Please enter temperature in Celsius: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break; 
                case "2":
                    Console.WriteLine("Please enter temperature in CFahrenheitelsius: ");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", C);
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
    }
}
