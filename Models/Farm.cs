using System;
using System.Collections.Generic;

namespace FarmManagementSystem.Models
{
    internal class Farm
    {
        private readonly List<Field> _fields = new List<Field>();

        private readonly List<Tractor> _tractors = new List<Tractor>();

        public IReadOnlyList<Tractor> Tractors => _tractors;
        public IReadOnlyList<Field> Fields => _fields;

        private string _name;

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must not be empty");
                }

                _name = value;
            }
        }

        public Farm (string name)
        {
            Name = name;
           
        }

        public void AddTractor(Tractor tractor)
        {
            if(tractor == null)
            {
                throw new ArgumentNullException(nameof(tractor), "Tractor cannot be null");
            }
            _tractors.Add(tractor);
        }

        public void ShowTractors()
        {
            foreach (Tractor tractor in _tractors)
            {
                Console.WriteLine($"{tractor.Model} - {tractor.HorsePower} HP");
            }
        }

        public int GetTotalHorsePower()
        {
            int totalHorsePower = 0;

            foreach(Tractor tractor in _tractors)
            {
                totalHorsePower += tractor.HorsePower;
            }
            
            return totalHorsePower;
        }

        public void AddField(Field field)
        {
            if(field == null)
            {
                return;
            }

            _fields.Add(field);
        }

        public void ShowFields()
        {
            
            foreach(Field field in _fields)
            {

                Console.WriteLine($"{field.Name} - {field.SizeInAcres} acres");
            }
        }

        public int GetTotalAcreage()
        {
            int sumAcres = 0;
            foreach(Field field in _fields)
            {
               
                sumAcres += field.SizeInAcres;
            }
            
            return sumAcres;
        }

    }
}
