using FarmManagementSystem.Models;
using System;

namespace FarmManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Farm farm = new Farm("Green Valley");

            Field field1 = new Field("North Field", 100);
            Field field2 = new Field("South Field", 50);


            farm.AddField(field1);
            farm.AddField(field2);


            farm.ShowFields();
            Console.WriteLine($"Total Acreage: {farm.GetTotalAcreage()}");
        }
    }
}
