using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.services
{
    public class AddParkingDetails
    {
        public int ParkingID { get; set; }

        [Required(ErrorMessage = "Vehicle Slot number is a Required field.")]
        public int ParkingSlotNo { get; set; }

        [Required(ErrorMessage = "Vehicle number is a Required field.")]
        [RegularExpression(@"^[a-zA-Z]{2}[0-9]{2}[ ]{1}[a-zA-Z]{2}[ ]{1}[0-9]{4}$", ErrorMessage = "Enter Valid Vehicle Number")]
        public string VehicleNo { get; set; }

        [Required(ErrorMessage = "Vehicle brand is a Required field.")]
        public string VehicleBrand { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1,}$", ErrorMessage = "Enter Valid Vehicle Colour")]
        public string VehicleColour { get; set; }

        public string ParkingType { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1,}$", ErrorMessage = "Enter Valid Vehicle Type")]
        public string VehicleType { get; set; }

        public double ChargePerHour { get; set; }

        public DateTime EntryTime { get; set; } = DateTime.Now;

        public DateTime ExitTime { get; set; }
    }
}
