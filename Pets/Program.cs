using System;

namespace Pets
{
    public class Pet
    {
        public string type,name,owner;
        public double weight;
        public Pet (string type1, string name1, string owner1, double weight1)
        {
            type = type1;
            name = name1;
            owner = owner1;
            weight = weight1;
        }
        public string getTag()
        {
            return ("if lose, call " + owner);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Simba", "Maria", 5.2);

            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(3));
        }
    }
}
