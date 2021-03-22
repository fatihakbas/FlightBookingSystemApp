using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class SqlCrud
    {


        private readonly string _connectionString;
        private SqlDataAccess _db = new SqlDataAccess();

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateAirport(AirportModel airport)
        {
            var sql = "USE FlightBookingSystemDB " +
                "insert into dbo.Airports (IATACode, Name, City, State) values (@IATACode, @Name, @City, @State);";

            _db.SaveData(sql, new
            {
                airport.IATACode,
                airport.Name,
                airport.City,
                airport.State
            }, _connectionString);
        }

        public void CreateAirline(AirlineModel airline)
        {
            var sql = "USE FlightBookingSystemDB " +
                "insert into dbo.Airlines (Name) values (@Name);";

            _db.SaveData(sql, new
            {
                airline.Name
            }, _connectionString); ;
        }
    }
}
