using CommonLayer.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.interfaces
{
    public interface ISampleBL
    {
        bool AddParking(AddParkingDetails parkingDetails);

        bool DeleteParking(AddParkingDetails parkingDetails);



    }

}
