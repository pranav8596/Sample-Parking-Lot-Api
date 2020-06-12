using BusinessLayer.interfaces;
using CommonLayer.services;
using RepositoryLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.services
{

    public class ParkingBL : IParkingBL
    {
       
        private IParkingRL sample;

        public ParkingBL(IParkingRL data)
        {
            this.sample = data;
        }

        public bool AddParking(AddParkingDetails parkingDetails)
        {
            return sample.AddParking(parkingDetails);
        }

        public bool DeleteParking(int ParkingID)
        {
            return sample.DeleteParking(ParkingID);
        }

        public bool UpdateParking(AddParkingDetails parkingDetails)
        {
            return sample.UpdateParking(parkingDetails);
        }
    }
}
