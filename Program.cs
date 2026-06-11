using FarmManagementSystem.Interfaces;
using FarmManagementSystem.Models;
using System;

namespace FarmManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm("Levi");
            Harvester harvester = new Harvester("X9 1100", 1000);
            Tractor tractor = new Tractor("John Deere 8R", 318);


            farm.AddMachine(harvester);
            farm.AddMachine(tractor);

            farm.ShowMachines();
        }
    }
}
