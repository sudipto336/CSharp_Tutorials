namespace Record_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonClass person1 = new PersonClass()
            {
                FirstName = "Sam",
                LastName = "Altman",
                Age = 23
            };

            //creating new class instance from existing instance by changing value of some props
            PersonClass person2 = new PersonClass()
            {
                FirstName = person1.FirstName,
                LastName = person1.LastName,
                Age = 25
            };

            PersonRecordWithoutConstructor person3 = new PersonRecordWithoutConstructor()
            {
                FirstName = "Sam",
                LastName = "Altman",
                Age = 23
            };

            //creating new record instance from existing instance by changing value of some props
            PersonRecordWithoutConstructor person4 = person3 with { Age = 25 };

            PersonRecordWithConstructor person5 = new PersonRecordWithConstructor("Sam", "Altman", 23);

            PersonRecordWithConstructor person6 = person5 with { Age = 25 };



            PersonClass person7 = new PersonClass()
            {
                FirstName = "Sam",
                LastName = "Altman",
                Age = 23
            };

            PersonRecordWithoutConstructor person8 = new PersonRecordWithoutConstructor()
            {
                FirstName = "Sam",
                LastName = "Altman",
                Age = 23
            };

            Console.WriteLine($"Are 2 class instances equal?: {person1.Equals(person7)}");
            Console.WriteLine($"Are 2 record instances equal?: {person3.Equals(person8)}");
        }
    }
}
