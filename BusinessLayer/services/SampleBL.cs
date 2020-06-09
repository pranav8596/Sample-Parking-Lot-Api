using BusinessLayer.interfaces;
using CommonLayer.services;
using RepositoryLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.services
{

    public class SampleBL : ISampleBL
    {
       
        private ISampleRL sample;

        public SampleBL(ISampleRL data)
        {
            this.sample = data;
        }

        public bool AddParking(AddParkingDetails parkingDetails)
        {
            return sample.AddParking(parkingDetails);
        }

        public bool DeleteParking(AddParkingDetails parkingDetails)
        {
            return sample.DeleteParking(parkingDetails);
        }
    }
}
