using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.interfaces;
using CommonLayer.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ParkingLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private IParkingBL sample;

        public ParkingController(IParkingBL data)
        {
            this.sample = data;
        }

        [Route("AddParking")]
        [HttpPost]
        public ActionResult AddParking(AddParkingDetails parkingDetails)
        {
            try
            {
                bool result = sample.AddParking(parkingDetails);
                if (result == true)
                {
                    string message = "Parking Details Entered Succesfully";
                    return Ok(new { result, message });
                }
                else
                {
                    string message = "Parking Details Failed to be Entered ";
                    return BadRequest(new { result, message });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }           
        }

        [Route("{ParkingID}")]
        [HttpDelete]
        public IActionResult DeleteParking(int ParkingID)
        {
            try
            {
                bool result = sample.DeleteParking(ParkingID);
                if (result == true)
                {
                    string message = "Parking Details Deleted Succesfully";
                    return Ok(new { result, message });
                }
                else
                {
                    string message = "Parking Details Failed to be Deleted ";
                    return BadRequest(new { result, message });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }           
        }

        [Route("UpdateParking")]
        [HttpPatch]
        public ActionResult UpdateParking(AddParkingDetails parkingDetails)
        {
            try
            {
                bool result = sample.UpdateParking(parkingDetails);
                if (result == true)
                {
                    string message = "Parking Details Updated Succesfully";
                    // return Ok(new { result, message });
                    return Ok(new { result, message });
                }
                else
                {
                    string message = "Parking Details Failed to be Updated ";
                    return BadRequest(new { result, message });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }            
        }
    }
}
