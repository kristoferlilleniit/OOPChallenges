using System;

namespace OOPChallenges
{
    class Program
    {

        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof");
                happiness += 0.2;
            }

            public void Wiggle()
            {
                Console.WriteLine("Wiggle-wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}; Spots: {spots}; Happiness: {happiness};");
            }
        }


        static void Main(string[] args)
        {
            Dog newDog = new Dog("Koer", 10);

            Console.WriteLine($"The level of happiness: {newDog.Happiness}");

            while (newDog.Happiness != 1)
            {
                newDog.Barks();
            }

            newDog.Wiggle();

            Console.WriteLine("Name the dog: ");
            string newDogName = Console.ReadLine();
            newDog.Rename(newDogName);
            newDog.ShowDogData();
        }
    }
}
