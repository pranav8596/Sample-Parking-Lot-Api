using CommonLayer.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.interfaces
{
    public interface ISampleRL
    {
        bool AddParking(AddParkingDetails parkingDetails);

        bool DeleteParking(AddParkingDetails parkingDetails);


    }
}
