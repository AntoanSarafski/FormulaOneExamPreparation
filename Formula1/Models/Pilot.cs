﻿using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private bool canRace = false;
        private IFormulaOneCar car;
        private int numberOfWins;


        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPilot, value));
                }
                // The name must be unique.
                fullName = value;
            }
        }

        public bool CanRace
        {
            get { return canRace; }
            private set { canRace = value; }
        }


        public IFormulaOneCar Car
        {
            get { return car; }
            private set 
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.InvalidCarForPilot);
                }
                car = value; 
            }
        }



        public int NumberOfWins
        {
            get { return numberOfWins; }
            private set { numberOfWins = value; }
        }



        public void AddCar(IFormulaOneCar car)
        {
            throw new NotImplementedException();
        }

        public void WinRace()
        {
            throw new NotImplementedException();
        }
    }
}