using Ex03.ConsoleUI;
using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Program
    {
        public static void Main()
        {
            GarageUI ui = new GarageUI();

            while (true)
            {
                try 
                { 
                    ui.menu();
                }
                catch (KeyNotFoundException exception)
                {
                    Console.WriteLine(UITextMessages.k_vehicleNotInGarage);
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
