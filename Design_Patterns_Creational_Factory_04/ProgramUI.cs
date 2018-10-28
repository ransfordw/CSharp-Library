using System;

namespace Design_Patterns_Creational_Factory_04
{
    internal class ProgramUI
    {
        VehicleFactory _factory = new ConcreteVehicleFactory();
        IVehicle _vehicle;
        DoorNumber _doorNumber;


        internal void Run()
        {
            Console.WriteLine("What type of vehicle do you need?\n\n" +
                "1. Car\n" +
                "2. Boat\n" +
                "3. Truck");
            var userInput = Console.ReadLine();

            _vehicle = _factory.GetVehicle(userInput, GetName(), GetColor(), GetNumberOfDoors(), GetFuelStatus());

            _vehicle.Start();
            _vehicle.Move();
            _vehicle.Brake();

            PrintVehicle();

            Console.ReadLine();
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"Vehicle Name: {_vehicle.Name}\n" +
                $"Vehicle Color:  {_vehicle.Color}\n" +
                $"Number of Doors:  {_vehicle.DoorNumber}\n" +
                $"Does it have fuel?  {_vehicle.HasGas}\n");
        }

        private bool GetFuelStatus()
        {
            bool hasGas;
            Console.WriteLine("Is there fuel in the tank? y/n");
            var fuelResponse = Console.ReadLine();
            if (fuelResponse == "y" || fuelResponse == "Y")
                hasGas = true;
            else
                hasGas = false;
            return hasGas;
        }

        private DoorNumber GetNumberOfDoors()
        {
            Console.WriteLine($"How many doors does the vehicle have?\n\t" +
                $"1. One\n\t" +
                $"2. Two\n\t" +
                $"3. Four\n\t" +
                $"4. Other\n\t");
            var doorResponse = int.Parse(Console.ReadLine());
            switch (doorResponse)
            {
                case 1:
                    return _doorNumber = DoorNumber.One;
                case 2:
                    return _doorNumber = DoorNumber.Two;
                case 3:
                    return _doorNumber = DoorNumber.Four;
                default:
                    return _doorNumber = DoorNumber.Other;
            }
        }

        public string GetName()
        {
            Console.Write("Enter the name of the vehicle:   ");
            var name = Console.ReadLine();
            return name;
        }

        public string GetColor()
        {
            Console.Write("Enter the color of the vehicle:   ");
            var color = Console.ReadLine();
            return color;
        }
    }
}