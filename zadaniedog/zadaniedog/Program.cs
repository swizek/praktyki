using System;

namespace zadaniedog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public struct Dog
        {
            public string Name;
            public string Breed;
            public Dog(string name, string breed)
            {
                this.Name = name;
                this.Breed = breed;

            }
            public void Speak()
            {
                Console.WriteLine("Wabie się {0}. Moja rasa to {1}", Name, Breed);
            }
            public class Canine
            {
                public string Name;
                public string Breed;
                private int mealSize;

                public double MealSize { get; private set; }

                public Canine(string name, string breed)
                {
                    this.Name = name;
                    this.Breed = breed;
                }
                public void WalkDogOrCanine(object getsWalked)
                {
                    Dog sid = new Dog("Sid", "husky");
                    WalkDogOrCanine(sid);
                    Dog happy = (Dog)getsWalked;
                }
                public double FeedDog(Canine dogToFeed, Bowl dogBowl)
                {
                    double eaten = Eat(dogToFeed.MealSize, dogBowl);
                    return eaten + .05D;



                }
                public void Eat(double mealSize, Bowl dogBowl)
                {
                    dogBowl.Capacity -= mealSize;
                    CheckBowl(dogBowl.Capacity);
                }
            }
                public void CheckBowl(double capacity)
                {
                    if (capacity < 12.5D)
                { 
                        string message = "Moja miska jest prawie pusta!";
                        Console.WriteLine(message);

                    }
                }
            }
        }

    public class Bowl
    {
        public double Capacity { get; internal set; }
    }
}

