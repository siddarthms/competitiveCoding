using System;

namespace OOPDemo
{
    // 🔷 Abstraction + Encapsulation
    public abstract class Vehicle
    {
        private string _brand;

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Brand cannot be null or whitespace.");
                _brand = value;
            }
        }

        public Vehicle(string brand)
        {
            Brand = brand; // ✅ Validation triggered here
        }

        public abstract void Drive(); // Abstraction
    }

    // 🔷 Inheritance
    public class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }

        // 🔷 Polymorphism (overriding base method)
        public override void Drive()
        {
            Console.WriteLine($"{Brand} Car is driving smoothly!");
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string brand) : base(brand) { }

        public override void Drive()
        {
            Console.WriteLine($"{Brand} Bike is zooming fast!");
        }
    }

    // 🔧 Main class to run everything
    class Program
    {
        static void Mains(string[] args)
        {
            try
            {
                Vehicle car = new Car("Honda");
                Vehicle bike = new Bike("Yamaha");

                car.Drive();   // Output: Honda Car is driving smoothly!
                bike.Drive();  // Output: Yamaha Bike is zooming fast!

                // ❌ Try invalid brand
                Vehicle badVehicle = new Car("   "); // Will throw exception
                badVehicle.Drive(); // This won't run
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error: {ex.Message}");
            }
        }
    }
}
