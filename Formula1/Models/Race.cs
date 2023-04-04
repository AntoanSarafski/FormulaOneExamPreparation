using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;


        public string RaceName
        {
            get { return raceName; }
            private set { raceName = value; }
        }


        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set { numberOfLaps = value; }
        }


        public bool TookPlace
        {
            get { return tookPlace; }
            set { tookPlace = value; }
        }


        private ICollection<IPilot> pilots;

        public ICollection<IPilot> Pilots
        {
            get { return pilots; }
            private set { pilots = value; }
        }


        public void AddPilot(IPilot pilot)
        {
            throw new NotImplementedException();
        }

        public string RaceInfo()
        {
            throw new NotImplementedException();
        }
    }
}
