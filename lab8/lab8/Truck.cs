using System;
using System.Collections.Generic;

namespace lab8
{
    class Truck : Vehicle
    { 
        private uint _liftingCapacity;
        private string _trailer;
        
        public uint LiftingCapacity
        {
            get
            {
                return _liftingCapacity;
            }

            set
            {
                _liftingCapacity = value;
            }
        }
        
        public string Trailer
        {
            get
            {
                return _trailer;
            }

            set
            {
                _trailer = value;
            }
        }
        public Truck()
        {
            LiftingCapacity = 0;
            Trailer = "";
        }
        
        public Truck(string brand, string model, double engineVolume,
            uint yearOfIssue, uint mileage, uint topSpeed, uint price, string type,
            uint liftingCapacity, string trailer) : base(brand, model, engineVolume,
            yearOfIssue, mileage,
            topSpeed, price, type)
        {
            LiftingCapacity = liftingCapacity;
            Trailer = trailer;
        }

        public override void Information()
        {
            Console.WriteLine("Truck.");
            base.Information();
            Console.WriteLine($"Lifting capacity: {LiftingCapacity}\nTrailer: {Trailer}\n");
        }

        public void Information(List<Vehicle> truck)
        {
            Console.WriteLine("Trucks:");
            if (truck.Count > 0)
            {
                for (int i = 0; i < truck.Count; i++) //вывод марки и модели введенных автомобилей
                {
                    if(truck[i].Type == "Truck") truck[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No trucks entered.");
            }
        }
    }
}