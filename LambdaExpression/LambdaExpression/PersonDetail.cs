using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class PersonDetail
    {
        public List<Person> list = new List<Person>();
        //UC1 : create list
        public void CreateList()
        {
            list.Add(new Person("234567812", "Rohan", "105 Virar, Mumbai", 22));
            list.Add(new Person("987654321", "Tare", "111 Vasai, Mumbai", 14));
            list.Add(new Person("213498576", "Rahul", "215 Mumbai, Maharashtra", 52));
            list.Add(new Person("321456678", "Tony", "100 Main street, Newyork", 16));
            list.Add(new Person("219348576", "Steve", "133 Pune", 67));
            list.Add(new Person("200312453", "Kylie", "111 Beverely hiils, Califonia", 65));
            foreach (var person in list)
            {
                Console.WriteLine("SSN : " + person.SSN + " ; " + "Name : " + person.Name + " ; " + "Address :" + person.Address + " ; " + "Age : " + person.Age);
            }
        }
        //UC2 : Age less than 60
        public void AgeLessThan60()
        {
            try
            {
                foreach (Person person in list.FindAll(r => (r.Age <= 60)).Take(2).ToList())
                {
                    Console.WriteLine("Name : " + person.Name + "  " + "Age : " + person.Age);
                }
            }
            catch
            {
                throw new LambdaCustomException(LambdaCustomException.Exceptiontype.NO_SUCH_AGE, "No Person Having Age below 60");
            }
        }
    }
}
