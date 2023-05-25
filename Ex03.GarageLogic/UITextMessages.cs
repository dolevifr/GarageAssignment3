using System;
namespace Ex03.ConsoleUI
{
    public class UITextMessages
    {
        public const string k_CarTypeMessage = @" 
Please choose which vehicle you wish to insert the garage:
1.Car
2.Motorcycle
3.Truck";
        public const string k_carFuelCurrAmount = "Please insert amount of maximum fuel capacity of vehicle in liters.";
        public const string k_carElectricityCurrAmount = "Please insert maximum battery capacity in hours.";
        public const string k_vehicleOwnerName = "Please insert the vehicle owner name";
        public const string k_vehicleOwnerPhoneNumber = "Please insert vehicle owner phone number";
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
The truck is refrigerator truck please choose 1 or 2
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
        public const string k_fuelToAddAmount = "Please insert fuel amount to add";
        public const string k_fuelTheVehicleAmount = "Please insert intial amount of fuel";
        public const string k_chargeTheVehicleLicenseNumber = "Please insert license number";
        public const string k_chargeTheVehicleMInutesToAdd = "Please insert how many minuts to add to battery";
        public const string k_getVehicleNewStatusInGarage = @"
Please enter integer repressenting new status of vehicle:
(1. In-Repair, 2. Repaird, 3.Paid)";
        public const string k_statusToFilterBy = @"
1. In-Repair
2. Repaired
3. Paid
4. All Vehicles";
        public const string k_getBatteryTimeToAddMInutes = "Please select the battery time to add in minutes";
        public const string k_insertCurrentHoursOfElectricity = "Please enter hours of Battrey left";
        public const string k_insertCurrentFuelLiters = "Please enter amount of fuel in the vehicle";
        public const string k_isVehicleExistsInTheGarage = "The vehicle already exists in system";
        public const string k_vehicleNotInGarage = "Vehicle does not exist in garage";
        public const string k_initialMinutesAmountInBattery = "Please insert intial amount of minutes in battery";

    }
}
