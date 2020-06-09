using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.interfaces;
using CommonLayer.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkingLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private ISampleBL sample;

        public SamplesController(ISampleBL data)
        {
            this.sample = data;
        }

        [Route("AddParking")]
        [HttpPost]
        public ActionResult AddParking(AddParkingDetails parkingDetails)
        {
            bool result = sample.AddParking(parkingDetails);
            return Ok(new { result });
        }
    }
}
