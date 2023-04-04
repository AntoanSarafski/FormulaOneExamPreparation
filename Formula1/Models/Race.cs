using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace = false;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            RaceName = raceName;
            NumberOfLaps = numberOfLaps;
            Pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get { return raceName; }
            private set 
            { 
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidRaceName, value));
                }
                //Name must be unique!
                raceName = value; 
            }
        }


        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidLapNumbers, value));
                }
                numberOfLaps = value;
            }
        }


        public bool TookPlace
        {
            get { return tookPlace; }
            set { tookPlace = value; }
        }


        

        public ICollection<IPilot> Pilots
        {
            get { return pilots; }
            private set { pilots = value; }
        }


        public void AddPilot(IPilot pilot)
        {
            Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
        //    string tookedPlace;
        //    if (tookPlace = false)
        //    {
        //        tookedPlace = "No";
        //    }
        //    else
        //    {
        //        tookedPlace = "Yes";
        //    }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The {RaceName} race has:");
            sb.AppendLine($"Participants: {pilots.Count}");
            sb.AppendLine($"Number of laps: {NumberOfLaps}");
            sb.AppendLine($"Took place: {TookPlace}");

            return sb.ToString().Trim();
        }
    }
}
