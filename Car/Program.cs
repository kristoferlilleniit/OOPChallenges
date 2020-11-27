using System;

namespace Car
{
    class Program
    {

        class Car
        {
            string name;
            string model;
            string registration;
            string color;
            int odoMeter;
            int fuelTank;

            public Car(string _name, string _model, string _registration, string _color, int _odoMeter, int _fuelTank)
            {
                name = _name;
                model = _model;
                color = _color;

                if(registration.Length != 6)
                {
                    registration = "undefined";
                }
                else
                {
                    registration = _registration;
                }


                odoMeter = 0;
                fuelTank = 60;
            }

            public string Registration
            {
                get { return registration; }
            }

            public string Name
            {
                get { return name; }
            }

            public string Model
            {
                get { return model; }
            }

            public string Color
            {
                get { return color; }
            }

            public int FuelTank
            {
                get { return fuelTank; }
            }

            public int OdoMeter
            {
                get { return odoMeter; }
            }

            public void DoALap()
            {
                Console.WriteLine("The car drives a lap.");
                odoMeter += 100;
                fuelTank -= 5;
                Console.WriteLine($"Odometer: {odoMeter}; Fuel Tank: {fuelTank}");
            }

            public void CarStats()
            {
                Console.WriteLine($"Name: {name}\n Model: {model}\n Registration: {registration}\n Color: {color}\n Odometer: {odoMeter}\n Fuel Tank: {fuelTank}");
            }
            
        }


        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota", "Supra", "123ABC", "Blue", 0, 60);

            while(newCar.FuelTank != 0)
            {
                newCar.DoALap();
            }

            newCar.CarStats();
            Console.WriteLine("The ride is over.");
        }
    }
}
