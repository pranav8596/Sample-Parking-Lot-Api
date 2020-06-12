using CommonLayer.services;
using RepositoryLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.services
{
    public class SampleRL : IParkingRL
    {
        string connectionString = "Data Source=AVID-LAPTOP\\SQLEXPRESS;Initial Catalog=ParkingLot;Integrated Security=True";

        /// <summary>
        /// To add the parking details of the vehicle
        /// </summary>
        /// <param name="parkingDetails"></param>
        /// <returns></returns>
        public bool AddParking(AddParkingDetails parkingDetails)
        {
            try
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
                sqlCommand.Parameters.AddWithValue("EntryTime", parkingDetails.EntryTime);
                sqlCommand.Parameters.AddWithValue("ExitTime", parkingDetails.ExitTime = parkingDetails.EntryTime);
                double time = parkingDetails.EntryTime.Subtract(parkingDetails.ExitTime).TotalHours;
               // parkingDetails.ChargePerHour;
                sqlCommand.Parameters.AddWithValue("@ChargePerHour", parkingDetails.ChargePerHour = time * 8);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }          
        }

        /// <summary>
        /// To delete the parking details of the vehicle
        /// </summary>
        /// <param name="parkingDetails"></param>
        /// <returns></returns>
        public bool DeleteParking(int ParkingID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand("spDeleteParkingRecord", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ParkingID", ParkingID);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }           
        }

        /// <summary>
        /// To update the parking details of the vehicle
        /// </summary>
        /// <param name="parkingDetails"></param>
        /// <returns></returns>
        public bool UpdateParking(AddParkingDetails parkingDetails)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand("spUpdateParkingRecord", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ParkingID", parkingDetails.ParkingID);
                sqlCommand.Parameters.AddWithValue("@ParkingSlotNo", parkingDetails.ParkingSlotNo);
                sqlCommand.Parameters.AddWithValue("@VehicleNo", parkingDetails.VehicleNo);
                sqlCommand.Parameters.AddWithValue("@VehicleBrand", parkingDetails.VehicleBrand);
                sqlCommand.Parameters.AddWithValue("@VehicleColour", parkingDetails.VehicleColour);
                sqlCommand.Parameters.AddWithValue("@ParkingType", parkingDetails.ParkingType);
                sqlCommand.Parameters.AddWithValue("@VehicleType", parkingDetails.VehicleType);
                sqlCommand.Parameters.AddWithValue("EntryTime", parkingDetails.EntryTime);
                sqlCommand.Parameters.AddWithValue("ExitTime", parkingDetails.ExitTime);
                sqlCommand.Parameters.AddWithValue("@ChargePerHour", parkingDetails.ChargePerHour = 0);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }         
        }
    }
}
