using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext
    {
        public List<Flight> Flights { get; set; }
        public List<Airplane> Airplanes { get; set; }
        public List<AirplaneType> AirplaneTypes { get; set; }
        public List<Crew> Crews { get; set; }
        public List<Departure> Departures { get; set; }
        public List<Pilot> Pilots { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
        public List<Ticket> Tickets { get; set; }

        public DataContext()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            Ticket NewYorkTicket_1 = new Ticket { Id = 1, Price = 55.5, FlightNumber = 1 };
            Ticket NewYorkTicket_2 = new Ticket { Id = 2, Price = 17.3, FlightNumber = 2 };
            Ticket LondonTicket_1 = new Ticket { Id = 3, Price = 22.11, FlightNumber = 3 };
            Tickets = new List<Ticket>();
            Tickets.Add(NewYorkTicket_1);
            Tickets.Add(NewYorkTicket_2);
            Tickets.Add(LondonTicket_1);

            Stewardess Cortny = new Stewardess { Id = 1, Name = "Cortny", Surname = "Cox", DateOfBorn = new DateTime(1989, 1, 14) };
            Stewardess Liza = new Stewardess { Id = 2, Name = "Liza", Surname = "Cudrow", DateOfBorn = new DateTime(1985, 5, 16) };
            Stewardess Janifer = new Stewardess { Id = 3, Name = "Janifer", Surname = "Aniston", DateOfBorn = new DateTime(1987, 6, 26) };
            Stewardesses = new List<Stewardess>();
            Stewardesses.Add(Cortny);
            Stewardesses.Add(Liza);
            Stewardesses.Add(Janifer);

            Pilot Dawid = new Pilot { Id = 1, Name = "Dawid", Surname = "Shvimer", DateOfBorn = new DateTime(1979, 12, 22), Experience = 14 };
            Pilot Mat = new Pilot { Id = 2, Name = "Mat", Surname = "Blanck", DateOfBorn = new DateTime(1981, 3, 11), Experience = 8 };
            Pilot Ros = new Pilot { Id = 3, Name = "Ros", Surname = "Geler", DateOfBorn = new DateTime(1987, 5, 1), Experience = 5 };
            Pilots = new List<Pilot>();
            Pilots.Add(Dawid);
            Pilots.Add(Mat);
            Pilots.Add(Ros);

            AirplaneType easyPlane = new AirplaneType { Id = 1, Model = "T-134", Capacity = 85, CarryingCapacity = 47000 };
            AirplaneType midPlane = new AirplaneType { Id = 2, Model = "T-154", Capacity = 152, CarryingCapacity = 80000 };
            AirplaneType higPlane = new AirplaneType { Id = 3, Model = "T-204", Capacity = 214, CarryingCapacity = 107900 };
            AirplaneTypes = new List<AirplaneType>();
            AirplaneTypes.Add(easyPlane);
            AirplaneTypes.Add(midPlane);
            AirplaneTypes.Add(higPlane);

            Airplane Natali = new Airplane { Id = 1, Name = "Natali", ReleaseDate = new DateTime(1995, 4, 15), TimeSpan = 25, Type = easyPlane };
            Airplane Glory = new Airplane { Id = 2, Name = "Glory", ReleaseDate = new DateTime(1991, 1, 24), TimeSpan = 20, Type = midPlane };
            Airplane Fury = new Airplane { Id = 3, Name = "Fury", ReleaseDate = new DateTime(1995, 6, 11), TimeSpan = 15, Type = higPlane };
            Airplanes = new List<Airplane>();
            Airplanes.Add(Natali);
            Airplanes.Add(Glory);
            Airplanes.Add(Fury);

            Crew easyCrew = new Crew { Id = 1, Pilot = Dawid, Stewardesses = new List<Stewardess> { Cortny } };
            Crew midCrew = new Crew { Id = 2, Pilot = Mat, Stewardesses = new List<Stewardess> { Cortny, Liza } };
            Crew higCrew = new Crew { Id = 3, Pilot = Ros, Stewardesses = new List<Stewardess> { Cortny, Liza, Janifer } };
            Crews = new List<Crew>();
            Crews.Add(easyCrew);
            Crews.Add(midCrew);
            Crews.Add(higCrew);

            Departure departure1 = new Departure { Id = 1, FlightNumber = 1, Airplane = Natali, Crew = easyCrew, DepartureDate = new DateTime(2018, 9, 1) };
            Departure departure2 = new Departure { Id = 2, FlightNumber = 2, Airplane = Glory, Crew = midCrew, DepartureDate = new DateTime(2018, 11, 12) };
            Departure departure3 = new Departure { Id = 3, FlightNumber = 3, Airplane = Fury, Crew = higCrew, DepartureDate = new DateTime(2018, 10, 14) };
            Departures = new List<Departure>();
            Departures.Add(departure1);
            Departures.Add(departure2);
            Departures.Add(departure3);

            Flight toNewYork = new Flight
            {
                Id = 1,
                PointOfDeparture = "Lviv",
                TimeOfDeparture = new DateTime(2018, 9, 1, 11, 30, 0),
                Destination = "New York",
                ArrivalTime = new DateTime(2018, 9, 2, 10, 0, 0),
                Ticket = new List<Ticket> { NewYorkTicket_1, NewYorkTicket_2 }
            };

            Flight toLondon = new Flight
            {
                Id = 2,
                PointOfDeparture = "Kiev",
                TimeOfDeparture = new DateTime(2018, 11, 23, 9, 35, 0),
                Destination = "London",
                ArrivalTime = new DateTime(2018, 7, 20, 10, 0, 0),
                Ticket = new List<Ticket> { LondonTicket_1 }
            };
            Flights = new List<Flight>();
            Flights.Add(toNewYork);
            Flights.Add(toLondon);
        }



        public List<TEntity> Set<TEntity>()
        {
            if (Flights is List<TEntity>)
            {
                return Flights as List<TEntity>;
            }
            else if (Airplanes is List<TEntity>)
            {
                return Airplanes as List<TEntity>;
            }
            else if (AirplaneTypes is List<TEntity>)
            {
                return AirplaneTypes as List<TEntity>;
            }
            else if (Crews is List<TEntity>)
            {
                return Crews as List<TEntity>;
            }
            else if (Departures is List<TEntity>)
            {
                return Departures as List<TEntity>;
            }
            else if (Pilots is List<TEntity>)
            {
                return Pilots as List<TEntity>;
            }
            else if (Stewardesses is List<TEntity>)
            {
                return Stewardesses as List<TEntity>;
            }
            else if (Tickets is List<TEntity>)
            {
                return Tickets as List<TEntity>;
            }
            else
            {
                return null;
            }
        }
    }
}
