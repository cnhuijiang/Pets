using System;
namespace Pets
{
    public class Dog:Pet
    {
        public Dog(string name2, string owner2, double weight2) :base("dog",name2, owner2, weight2)
        {
            name = name2;
            owner = owner2;
            weight = weight2;
        }
        public string bark(int count)
        {
            string bark = "";
            for(int i = 0; i < count; i ++)
            {
                bark= bark+"bark!";
            }
            return bark;
            // put code to generate string here
        }
    }
}
