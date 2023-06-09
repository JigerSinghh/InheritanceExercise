using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {






            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.WingColor = "Blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;


            var myReptile = new Reptile()
            {
                IsColdBlooded = true,
                isScaly = true,
                Habitat = "swamp",
                CanGrowTail = true,



            };
            var myAnimals = new Animal[] { myBird, myReptile };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive {animal.IsAlive}");
                Console.WriteLine($"Age {animal.Age}");
                Console.WriteLine($"It has {animal.LegCount}");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");

            }

            


             
            


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
