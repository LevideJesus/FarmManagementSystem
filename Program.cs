using FarmManagementSystem.Models;
using System;

namespace FarmManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Farm farm = new Farm("Green Valley");

            farm.AddTractor(
                new Tractor("John Deere 8R", 0));

           

            farm.ShowTractors();
            farm.GetTotalAcreage();
        }
    }
}
