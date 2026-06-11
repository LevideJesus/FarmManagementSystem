using FarmManagementSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace FarmManagementSystem.Models
{
    internal class Farm
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();
        public IReadOnlyList<Vehicle> Vehicles => _vehicles;

        private readonly List<Field> _fields = new List<Field>();
        public IReadOnlyList<Field> Fields => _fields;

        private readonly List<IWorkable> _machines = new List<IWorkable>();
        public IReadOnlyList<IWorkable> Machines => _machines;
        

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
                throw new ArgumentNullException(nameof(field), "Field cannot be null");
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


        public void AddMachine(IWorkable machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException(nameof(machine), "Machine cannot be null");

            }
            _machines.Add(machine);

        }

        public void ShowMachines()
        {
            
            foreach(IWorkable machine in _machines)
            {

                machine.Work();
            }
        }

        public void AddVehicles(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null");
            }

            _vehicles.Add(vehicle);
        }


        public void ShowVehicles()
        {
            foreach(Vehicle vehicle in _vehicles)
            {
                vehicle.ShowVehicleInfo();
            }
        }
      
    }
}
