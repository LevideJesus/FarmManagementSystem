using System;


namespace FarmManagementSystem.Models
{
    internal class Tractor
    {
        private string _model;


        private int _horsePower;

        public int HorsePower
        {
            get { return _horsePower; }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The HorsePower must be greater than 0.");
                }
                _horsePower = value;
            }
        }

        public string Model
        {
            get { return _model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be empty.");

                }
                _model = value;
            }
        }
        public Tractor(string model, int horsePower)
        {
            Model = model;
            HorsePower = horsePower;
        }
    }
}
