using CommonLayer.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.interfaces
{
    public interface IParkingBL
    {        
        bool AddParking(AddParkingDetails parkingDetails);

        bool DeleteParking(int ParkingID);

        bool UpdateParking(AddParkingDetails parkingDetails);

    }

}
