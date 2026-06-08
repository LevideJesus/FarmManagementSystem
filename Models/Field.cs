using System;


namespace FarmManagementSystem.Models
{
    internal class Field
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                _name = value;
            }
        }

        private int _sizeInAcres;

        public int SizeInAcres
        {
            get { return _sizeInAcres; }
            private set
            {
                if(value <= 0) { throw new ArgumentException(); }
                _sizeInAcres = value;
                
            }
        }


        public Field(string name, int sizeInAcres)
        {
            Name = name;
            SizeInAcres = sizeInAcres;
        }
    }
}
