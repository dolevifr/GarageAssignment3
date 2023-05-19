using System;
namespace Ex03.ConsoleUI
{
    public class UITextMessages
    {
        public void CarTypeMessage()
        {
            Console.WriteLine(@"
Please choose which vehicle you wish to insert the garage:
1.Fuel based car
2.Electric car
3.Fuel based motorcycle
4. electric motorcycle
5.Truck");
        }

        public void CarFuelCurrAmount()
        {
            Console.WriteLine(@"Please insert amount of fuel in the car.");
        }

        public void CarElectricityCurrAmount()
        {
            Console.WriteLine(@"Please insert how many hours left in the battery.");

        }
    }
}
