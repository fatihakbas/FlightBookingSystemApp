using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace FlightBookingSystemUI
{
    class Program
    {
        static void Main(string[] args)
        {
            


            SqlCrud sql = new SqlCrud(GetConnectionString());
            //CreateNewAirport(sql); // It worked
            //CreateNewAirports(sql, GetTestAirportData()); // it worked
            //CreateNewAirline(sql);
            //CreateNewAirlines(sql, GetAirlineData()); // it worked


            Console.WriteLine("Completed..");

            Console.ReadKey();
        }

        private static void CreateNewAirlines(SqlCrud sql, List<AirlineModel> airlines)
        {
            foreach (var airline in airlines)
            {
                sql.CreateAirline(airline);
            }
        }

        private static void CreateNewAirline(SqlCrud sql)
        {
            // Test Data
            var airline = new AirlineModel
            {
                Name = "Turkish Airlines"
            };
            sql.CreateAirline(airline);
        }

        private static void CreateNewAirports(SqlCrud sql, List<AirportModel> airports)
        {
            foreach (var airport in airports)
            {
                sql.CreateAirport(airport);
            }
        }

        private static void CreateNewAirport(SqlCrud sql)
        {
            // Test Data
            var airport = new AirportModel
            {
                IATACode = "ORD",
                Name = "O'Hare International Airport",
                City = "Chicago",
                State = "IL"
            };

            sql.CreateAirport(airport);
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }

        private static List<AirportModel> GetAirportData()
        {
            List<AirportModel> airports = new List<AirportModel>();

            airports.Add(new AirportModel { IATACode = "DFW", Name = "Dallas/Fort Worth International Airport", City = "Dallas", State = "TX" });
            airports.Add(new AirportModel { IATACode = "DEN", Name = "Denver International Airport", City = "Denver", State = "CO" });
            airports.Add(new AirportModel { IATACode = "JFK", Name = "John F. Kennedy International Airport", City = "New York City", State = "NY" });
            airports.Add(new AirportModel { IATACode = "SFO", Name = "San Francisco International Airport", City = "San Francisco", State = "CA" });
            airports.Add(new AirportModel { IATACode = "SEA", Name = "Seattle–Tacoma International Airport", City = "Seattle", State = "WA" });
            airports.Add(new AirportModel { IATACode = "LAS", Name = "McCarran International Airport", City = "Las Vegas", State = "NV" });
            airports.Add(new AirportModel { IATACode = "MCO", Name = "Orlando International Airport", City = "Orlando", State = "FL" });

            return airports;
        }

        private static List<AirlineModel> GetAirlineData()
        {
            List<AirlineModel> airlines = new List<AirlineModel>();

            airlines.Add(new AirlineModel { Name = "Qatar Airways" });
            airlines.Add(new AirlineModel { Name = "Delta Airlines" });
            airlines.Add(new AirlineModel { Name = "ANA" });
            airlines.Add(new AirlineModel { Name = "KLM" });
            airlines.Add(new AirlineModel { Name = "British Airways" });
            airlines.Add(new AirlineModel { Name = "Etihad Airways" });
            airlines.Add(new AirlineModel { Name = "Singapore Airlines" });
            airlines.Add(new AirlineModel { Name = "Lufthansa" });
            airlines.Add(new AirlineModel { Name = "United Airlines" });

            return airlines;

        }
    }
}
