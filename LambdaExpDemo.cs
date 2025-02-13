using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class LambdaExpDemo
    {

        public void FindEvenUsingLambdaExp()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);

            List<int> evenList = ints.FindAll(x => x % 2== 0);
            foreach (int i in evenList)
            {
                Console.WriteLine(i);
            }
        }

        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }

        public void GetName()
        {
            List<Dog> list = new List<Dog>() { 
                new Dog{ Name = "Rex", Age = 4},
                new Dog{ Name = "Rox", Age = 2},
                new Dog{ Name = "Maxy", Age = 8},
                new Dog{ Name = "Tanny", Age = 5},

            };

            var nameOfDog = list.Select(x => x.Name);

            foreach (var dName in nameOfDog) { 
                Console.WriteLine(dName);
            }

            var  newDogList = list.Select( x => new {Age = x.Age , FirstLetter = x.Name[0] });

            foreach (var dAge in newDogList)
            {
                Console.WriteLine(dAge);
            }

            var OrderDogName = list.OrderByDescending(x => x.Age);

            Console.WriteLine("Descending order by age");
            foreach (var dog in OrderDogName) { 
                Console.WriteLine(string.Format("Dog {0} is {1} year old.", dog.Name, dog.Age)); 
            }

        }
    }
}
