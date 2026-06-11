using System;
using FarmManagementSystem.Interfaces;


namespace FarmManagementSystem.Models
{
    internal class Harvester : IWorkable
    {
        private string _model;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity cannot be less than 0");
                }

                _capacity = value;
            }
        }
        public string Model
        {
            get { return _model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be empty"); 
                }
                _model = value;
            }
        }

        public Harvester(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }

        public void Work()
        {
            Console.WriteLine($"{Model} is harvesting crops.");
        }
    }
}
