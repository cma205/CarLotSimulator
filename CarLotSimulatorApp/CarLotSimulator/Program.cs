using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate Carlot at the beginning of the program
            //and as you create a car add the car to the list.
            var lot = new CarLot();
            
            //Instantiation 1 (Dot Notation)

            var dansCar = new Car();
            dansCar.Make = "Ford";
            dansCar.Model = "Explorer";
            dansCar.Year = 2017;
            dansCar.EngineNoise = "vroom";
            dansCar.HonkNoise = "beep";
            dansCar.IsDriveable = true;

            //Add Dan's car to Carlot
            lot.Cars.Add(dansCar);

            //Instantiation 2 (object intializer syntax)

            var jeffsCar = new Car()
            {
                Year = 2017,
                Make = "Chevrolet",
                Model = "Silverado",
                EngineNoise = "LOUD AND PROUD",
                HonkNoise = "Train Horn/Totally obnoxious",
                IsDriveable = true

            };

            //Add Jeff's car to Carlot
            lot.Cars.Add(jeffsCar);

            //Using the constructor to allow parameter values to be placed inside properties.

            var sarahsCar = new Car(2013, "Volkswagon", "Beetle", "high-pitched whistle", "beep beep", true);

            //Add Sarah's car to Carlot
            lot.Cars.Add(sarahsCar);

            //Call Methods

            dansCar.MakeEngineNoise(dansCar.EngineNoise);
            jeffsCar.MakeEngineNoise(jeffsCar.EngineNoise);
            sarahsCar.MakeEngineNoise(sarahsCar.EngineNoise);

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: { car.Year} Make: {car.Make} Model: {car.Model}");
            }


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}




