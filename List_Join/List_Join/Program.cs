using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Join
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  junção de chave simples
            //Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            //Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            //Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            //Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            //Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            //Pet barley = new Pet { Name = "Barley", Owner = terry };
            //Pet boots = new Pet { Name = "Boots", Owner = terry };
            //Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            //Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            //Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            //List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui };
            //List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            //var query = from person in people
            //            join pet in pets on person equals pet.Owner
            //            select new { OwnerName = person.FirstName, PetName = pet.Name };

            //foreach (var ownerAndPet in query)
            //{
            //    Console.WriteLine($"{ownerAndPet.PetName} is owned by {ownerAndPet.OwnerName}");
            //}
            #endregion
            #region junção de chave composta
            // Create a list of employees.
            //    List<Employee> employees = new List<Employee> {
            // new Employee { FirstName = "Terry", LastName = "Adams", EmployeeID = 522459 },
            // new Employee { FirstName = "Charlotte", LastName = "Weiss", EmployeeID = 204467 },
            // new Employee { FirstName = "Magnus", LastName = "Hedland", EmployeeID = 866200 },
            // new Employee { FirstName = "Vernette", LastName = "Price", EmployeeID = 437139 } };

            //    // Create a list of students.
            //    List<Student> students = new List<Student> {
            //new Student { FirstName = "Vernette", LastName = "Price", StudentID = 9562 },
            //new Student { FirstName = "Terry", LastName = "Earls", StudentID = 9870 },
            //new Student { FirstName = "Terry", LastName = "Adams", StudentID = 9913 } };

            //    // Join the two data sources based on a composite key consisting of first and last name,
            //    // to determine which employees are also students.
            //    IEnumerable<string> query = from employee in employees
            //                                join student in students
            //                                on new { employee.FirstName, employee.LastName }
            //                                equals new { student.FirstName, student.LastName }
            //                                select employee.FirstName + " " + employee.LastName;

            //    Console.WriteLine("The following people are both employees and students:");
            //    foreach (string name in query)
            //        Console.WriteLine(name);
            #endregion


            #region junção múltipla
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };
            Person phyllis = new Person { FirstName = "Phyllis", LastName = "Harris" };

            Cat barley = new Cat { Name = "Barley", Owner = terry };
            Cat boots = new Cat { Name = "Boots", Owner = terry };
            Cat whiskers = new Cat { Name = "Whiskers", Owner = charlotte };
            Cat bluemoon = new Cat { Name = "Blue Moon", Owner = rui };
            Cat daisy = new Cat { Name = "Daisy", Owner = magnus };

            Dog fourwheeldrive = new Dog { Name = "Four Wheel Drive", Owner = phyllis };
            Dog duke = new Dog { Name = "Duke", Owner = magnus };
            Dog denim = new Dog { Name = "Denim", Owner = terry };
            Dog wiley = new Dog { Name = "Wiley", Owner = charlotte };
            Dog snoopy = new Dog { Name = "Snoopy", Owner = rui };
            Dog snickers = new Dog { Name = "Snickers", Owner = arlene };

            List<Person> people =  
                new List<Person> { magnus, terry, charlotte, arlene, rui, phyllis };
            List<Cat> cats =
                new List<Cat> { barley, boots, whiskers, bluemoon, daisy };
            List<Dog> dogs =
                new List<Dog> { fourwheeldrive, duke, denim, wiley, snoopy, snickers };
         
            var query = from person in people
                        join cat in cats on person equals cat.Owner
                        join dog in dogs on
                        new { Owner = person, Letter = cat.Name.Substring(0, 1) }
                        equals new { dog.Owner, Letter = dog.Name.Substring(0, 1) }
                        select new { CatName = cat.Name, DogName = dog.Name };
            
            foreach (var obj in query)
            {
                Console.WriteLine(
                    $"The cat {obj.CatName} shares a house, and the first letter of their name, with {obj.DogName}.");
            }
            #endregion


            Console.ReadKey();
        }
    }
}
