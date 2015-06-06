using System;

namespace _01.Persons
{
    class Persons
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 18);
            Person gosho = new Person("Gosho", 21, "goshko@abv.bg");
            Person mariika = new Person("Mariika", 20, "mariika@gmail.com");

            Console.WriteLine(pesho);

            Console.WriteLine(gosho);
            Console.WriteLine(mariika);
        }
    }
}
