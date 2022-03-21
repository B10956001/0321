using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        string color = "red";
        int cc = 1500;
        string brand = "bmw";

        public void Star()
        {
            Console.WriteLine("引擎發動");
        }
        public void ShowInfo()
        {
            Console.WriteLine("車色：" + color);
        }
    }
}
