using CommonLayer.services;
using RepositoryLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.services
{
    public class SampleRL : ISampleRL
    {
        string connectionString = "Data Source=AVID-LAPTOP\\SQLEXPRESS;Initial Catalog=ParkingLot;Integrated Security=True";
        public bool AddParking(AddParkingDetails parkingDetails)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("spAddParkingDetails", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ParkingSlotNo", parkingDetails.ParkingSlotNo);
            sqlCommand.Parameters.AddWithValue("@VehicleNo", parkingDetails.VehicleNo);
            sqlCommand.Parameters.AddWithValue("@VehicleBrand", parkingDetails.VehicleBrand);
            sqlCommand.Parameters.AddWithValue("@VehicleColour", parkingDetails.VehicleColour);
            sqlCommand.Parameters.AddWithValue("@ParkingType", parkingDetails.ParkingType);
            sqlCommand.Parameters.AddWithValue("@VehicleType", parkingDetails.VehicleType);
            sqlConnection.Open();
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
