using System;
using FarmManagementSystem.Interfaces;

namespace FarmManagementSystem.Models
{
    internal class Tractor : Vehicle, IWorkable
    {


        private int _horsePower;

        public int HorsePower
        {
            get { return _horsePower; }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                         nameof(value),
                         "HorsePower must be greater than 0.");
                }
                _horsePower = value;
            }
        }

 
        public Tractor(string model,int horsePower) 
            :base(model)
        {
            HorsePower = horsePower;
        }

        public void Work()
        {
            Console.WriteLine($"{Model} is plowing the field.");
        }

        public override void ShowVehicleInfo()
        {
            base.ShowVehicleInfo();
            Console.WriteLine($"HorsePower: {HorsePower}");
        }

        public override void StartWork()
        {
            Console.WriteLine($"{Model} starts plowing.");
        }

    }


}
