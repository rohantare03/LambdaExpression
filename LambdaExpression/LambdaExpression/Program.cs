namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1 : Creating a list
            PersonDetail personDetails = new PersonDetail();
            personDetails.CreateList();

            //UC2
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Retrieving 2 records for age less than 60");
            personDetails.AgeLessThan60();

            //UC3
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Checking whether any person is teenager or not.....");
            personDetails.AgeBetween();

            //UC4
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Getting Average of all the person's age....");
            personDetails.AverageAge();

            //UC5
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Checking whether a person having name 'Rohan' exists or not...");
            personDetails.SpecificName();
        }
    }
}
