using FarmManagementSystem.Interfaces;
using FarmManagementSystem.Models;
using System;

namespace FarmManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Harvester harvester = new Harvester("X9 1100", 1000);
            Tractor tractor = new Tractor("John Deere 8R", 318);

            tractor.ShowVehicleInfo();
            harvester.ShowVehicleInfo();


        }
    }
}
