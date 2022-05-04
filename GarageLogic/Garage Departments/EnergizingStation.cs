﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic.Garage_Departments
{
    class EnergizingStation
    {
        public enum eFuelType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }

        public void EnergizeVehicle(VehicleInGarage i_VehicleToEnergize, eFuelType i_FuelType, float i_EnergyAmount)
        // 5+6
        {
            i_VehicleToEnergize.Vehicle.Engine.Energize(i_EnergyAmount, i_FuelType);
        }
    }
}