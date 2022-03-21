using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CarA:Car //繼承
    {
        public override void OpenDoor()
        {
            Console.WriteLine("上開");
        }
    }
}
