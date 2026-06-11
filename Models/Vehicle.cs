using FarmManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementSystem.Models
{
    internal class Vehicle 
    {

        private string _model;

        public string Model
        {
            get { return _model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be empty", nameof(value));
                }
                _model = value;
            }
        }

        public Vehicle (string model)
        {
            Model = model;
        }

        public void ShowVehicleInfo()
        {
            Console.WriteLine($"Model: {Model}");
        }

        
    }
}
