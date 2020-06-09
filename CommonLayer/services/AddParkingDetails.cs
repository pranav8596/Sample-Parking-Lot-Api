using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.services
{
    public class AddParkingDetails
    {
        public int ParkingID { get; set; }

        public int ParkingSlotNo { get; set; }

        public string VehicleNo { get; set; }

        public string VehicleBrand { get; set; }

        public string VehicleColour { get; set; }

        public string ParkingType { get; set; }

        public string VehicleType { get; set; }
    }
}
