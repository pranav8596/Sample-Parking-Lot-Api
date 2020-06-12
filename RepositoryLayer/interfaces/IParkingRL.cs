using CommonLayer.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.interfaces
{
    public interface IParkingRL
    {
        bool AddParking(AddParkingDetails parkingDetails);

        bool DeleteParking(int ParkingID);

        bool UpdateParking(AddParkingDetails parkingDetails);
    }
}
