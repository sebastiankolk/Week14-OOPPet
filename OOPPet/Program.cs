using System;

namespace OOPPet
{
    class Program
    {
        class Pet
        {
            string name;
            double weight;
            int age;

            public Pet(string _name)
            {
                name = _name;
                weight = 0.3;
                age = 0;
                Console.WriteLine($"Congratulations! You've adopted {name}. ");
            }
            public double Weight
            {
                get { return weight; }
            }

            public void Info()
            {
                Console.WriteLine($"Name: {name}. ");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }
            public void Gain()
            {
                Console.WriteLine("'Scrunch, scrunch'");
                weight += 0.2;
            }
            public void Run()
            {
                Console.WriteLine("'*heavy breathing*'");
                weight -= 0.1;
            }
            public void GetOlder()
            {
                age++;
            }
        }
        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hammu");
            for (int i = 0; i < 10; i++)
            {
                myPet.Gain();
                Console.WriteLine($"Current weight:{myPet.Weight}");
                if(myPet.Weight >= 0.7)
                {
                    while(myPet.Weight > 0.7)
                    {
                        myPet.Run();
                        Console.WriteLine($"Weight after running: {myPet.Weight}");
                    }
                }
                myPet.GetOlder();
            }
            myPet.Info();
        }
    }
}
