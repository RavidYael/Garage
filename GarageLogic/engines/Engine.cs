﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageLogic.Garage_Departments.EnergizingStation;

namespace GarageLogic
{
    internal abstract class Engine
    {
        protected float m_CurrentEnergyAmount;
        protected float m_MaxEnergyAmount;

        internal virtual void Energize(float i_EnergyAmount, eFuelType i_FuelType = default)
        {
            float newEnergyAmount = i_EnergyAmount + m_CurrentEnergyAmount;
            setEnergyAmount(newEnergyAmount);
        }

        private void setEnergyAmount(float i_EnergyAmount)
        {
            if (i_EnergyAmount > m_MaxEnergyAmount)
            {
                throw new ValueOutOfRangeException(0, m_MaxEnergyAmount, $"Energy amount out of range, maximum is: {m_MaxEnergyAmount}");
            }

            m_CurrentEnergyAmount = i_EnergyAmount;
        }

        internal float MaxEnergyAmount
        {
            get {return m_MaxEnergyAmount;}
            set {m_MaxEnergyAmount = value;}
        }

        internal abstract Dictionary<string, string> GetDetails();

        internal abstract List<string> GetParameters();

        public virtual void SetParameters(List<string> i_Parameters)
        {
            float energyAmount = float.Parse(Utils.PopFirstItemOfList(i_Parameters));
            setEnergyAmount(energyAmount);
        }
    }
}
