﻿using Ex03.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Program
    {
        public static void Main()
        {
            GarageUI ui = new GarageUI();

            while (true)
            {
                ui.menu();
            }
            Console.ReadLine();
        }
    }
}
