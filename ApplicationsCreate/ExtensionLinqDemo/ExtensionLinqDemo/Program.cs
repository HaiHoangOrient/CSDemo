using static ExtensionLinqDemo.Program;

namespace ExtensionLinqDemo
{
    internal class Program
    {
        public abstract class Animal
        { /*...*/
            internal static void Add(Cat cat)
            {
                throw new NotImplementedException();
            }
        }
        public interface IMove<T>
        {
            void Move();
        }
        public class Cat : Animal, IMove<Cat>
        { /*...*/
            public Cat(string v)
            {
            }

            public void Move()
            {
                throw new NotImplementedException();
            }
        }
        public class Dog : Animal, IMove<Dog>
        { /*...*/
            public Dog(string v)
            {
            }

            public void Move()
            {
                throw new NotImplementedException();
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public string[] Hobbies { get; set; }
        }

        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 8 };

            var colors = new[] { "yellow", "green", "red", "teal", "blue", "orange", "violet" };

            var animals = new List<Animal>
            {
                new Cat("Garfield"),
                new Cat("Mr. Fluffy"),
                new Dog("Spike"),
                new Dog("Bingo")
            };

            var ofTypeList = animals.OfType<IMove<object>>().ToList();

            var skipList = ints.TakeWhile(i => i > 3).ToList();

            var skip3List = ints.Skip(3).ToList();

            var take3List = ints.Take(3).ToList();

            var take3LastList = ints.TakeLast(3).ToList();

            var orderByListAsc = ints.OrderByDescending(i => i).ToList();

            var orderByColors = colors.OrderBy(i => i.Length).ToList();

            var thenByColors = colors.OrderBy(i => i.Length).ThenByDescending(i => i).ToList();

            //foreach (var i in thenByColors)
            //{
            //    Console.WriteLine(i);
            //}

            var groupedColors = colors.GroupBy(i => i.Length).ToList();

            //foreach(var i in groupedColors)
            //{
            //    Console.Write($"key : {i.Key} - value:");
            //    foreach (var i2 in i)
            //    {
            //        Console.Write($" {i2} ");
            //    }
            //    Console.WriteLine();
            //}

            var lookupedColors = colors.ToLookup(i => i.Length).ToList();

            //foreach (var item in lookupedColors)
            //{
            //    Console.Write($"key : {item.Key} - value:");
            //    foreach (var i2 in item)
            //    {
            //        Console.Write($" {i2} ");
            //    }
            //    Console.WriteLine();
            //}

            var persons = new[] {
                new Person {
                    Name = "George",
                    Hobbies = new[] { "reading", "gaming" }
                },
                new Person {
                    Name = "John",
                    Hobbies = new[] { "reading", "hiking", "scuba diving" }
                },
                new Person {
                    Name = "John",
                    Hobbies = new[] { "gaming", "cooking", "playing guitar" }
                }
            };

            var hobbies = persons.SelectMany(p => p.Hobbies).Distinct().ToArray();

            //foreach (var hobby in hobbies)
            //{
            //    Console.WriteLine(hobby);
            //}

            double avg = ints.Average();

            Console.WriteLine(avg);
        }
    }
}
