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
            Console.WriteLine("CC數：" + cc);
            Console.WriteLine("廠牌：" + brand);
        }
        public void ChangeColor(string color)
        {
            this.color = color;
            Console.WriteLine();
            Console.WriteLine("--------車色變更--------");
            Console.WriteLine("車色：" + color);
            Console.WriteLine("------------------------");
        }
        public virtual void OpenDoor()
        {
            Console.WriteLine("側開車門");
        }
    }
}
