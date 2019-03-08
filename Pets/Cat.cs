using System;
namespace Pets
{
    public class Cat:Pet
    {
        public Cat(string name2, string owner2,double weight2):base("Cat",name2,owner2,weight2)
        {
            name = name2;
            owner = owner2;
            weight = weight2;
        }
        public string meow(int count)
        {
            string meow = "";
            for(int x = 0; x < count; x++)
            {
                meow = meow + "meow.";
            }
            return meow;
        }
    }
}
