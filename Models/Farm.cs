using System;
using System.Collections.Generic;

namespace FarmManagementSystem.Models
{
    internal class Farm
    {
        private List<Field> _fields = new List<Field>();

        public IReadOnlyList<Field> fields => _fields;

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
                if (string.IsNullOrWhiteSpace(field.Name))
                {
                    continue;
                }

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
      
            Console.WriteLine($"Total Acreage: {sumAcres}");
            return sumAcres;
        }

    }
}
