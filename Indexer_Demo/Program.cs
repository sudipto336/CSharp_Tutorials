namespace Indexer_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringDataSource stringDataSource = new StringDataSource();
            stringDataSource[0] = "1";
            Console.WriteLine(stringDataSource[0]);

            DataSource<string> names = new DataSource<string>(10);
            names[0] = "Sam";
            Console.WriteLine(names[0]);

            DataSource<int> grades = new DataSource<int>(10);
            grades[0] = 9;
            Console.WriteLine(grades[0]);
        }
    }
}
