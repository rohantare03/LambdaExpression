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
        }
    }
}
