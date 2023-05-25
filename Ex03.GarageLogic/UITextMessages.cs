﻿using System;
namespace Ex03.ConsoleUI
{
    public class UITextMessages
    {
        public const string k_CarTypeMessage = @" 
Please choose which vehicle you wish to insert the garage:
1.Car
2.Motorcycle
3.Truck";
        public const string k_carFuelCurrAmount = "Please insert amount of fuel in the car.";
        public const string k_carElectricityCurrAmount = "Please insert how many hours left in the battery.";
        public const string k_vehicleColor = "Please insert vehicle color";
        public const string k_numOfVehicleDoors = "Please insert amount of doors in Vehicle";
        public const string k_wheelsMaxAirPressure = "Please insert max air pressure in wheel";
        public const string k_wheelsCurrAirPressure = "Please insert current air pressure in wheel";
        public const string k_wheelManufacturerName = "Please insert wheel manufacturer name";
        public const string k_wheelNumberInVehicle = "Please insert number of wheels in the vehicle";
        public const string k_getLicenseNumber = "Please insert license number";
        public const string k_motorcycleLicenseType = @"
Please insert motorcycle license type:
1.A1
2.A2
3.AA
4.B1";

        public const string k_isRefrigeratorTruck = @"
The truck is refrigerator truck? please choose 1 or 2
1.Yes
2.No";

        public const string k_isElectricVehicle = @"
please choose 1 or 2
1.Electric vehicle
2.Regular vehicle";

        public const string k_vehicleModelName = "Please insert vehicle model name";
        public const string k_motorcycleEngineVolume = "Please insert engine volume";
        public const string k_truckCargoVolume = "Please insert cargo volume";
        public const string k_energyType = @"
Please insert energy type:
1.Soler
2.Octan95
3.Octan96
4.Octan98
5.Electricity";
        public const string k_invalidMenuItem = "Invalid menu option";

        public const string k_welcomeMenu = @"
hello to the Garage, please select an option:
1.Insert a new vehicle
2.see the license number of cars in the Garage, with/without status filter
3.Change Vehicle status in the Garage
4.Airpump the wheels to the maximum PSI
5.Fuel a fuel Based car
6.Charge an electric car
7.look at all the data of a specific car
";
        public const string k_withOrWithoutStatusFilter = @"
Do you want to filter the cars by status?
1.No
2.Yes, filter by in repair
3.Yes,filter by repaired
4.Yes,filter by paid
";
        public const string k_fuelTheVehicleLicenseNumber = "Please insert license number";
        public const string k_fuelTheVehicleFuelType = "Please insert fuel type";
        public const string k_fuelTheVehicleAmount = "Please insert amount to fuel in liters";
        public const string k_chargeTheVehicleLicenseNumber = "Please insert license number";
        public const string k_chargeTheVehicleMInutesToAdd = "Please insert how many minuts to add";
        public const string k_getVehicleNewStatusInGarage =@"
Please enter integer repressenting new status of vehicle:
(1. In-Repair, 2. Repaird, 3.Paid)";
        public const string k_getBatteryTimeToAddMInutes = "Please select the battery time to add in minutes";
    
    }
}
