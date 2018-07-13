using DAL;
using DAL.Models;
using Shared.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Shared.Mapping
{
    public class FlightMapp
    {
        public static Flight Mapp(FlightDTO entity, IUnitOfWork data)
        {
            var tickets = data.Set<Ticket>().Get();

            return new Flight
            {
                Id = entity.Id,
                ArrivalTime = entity.ArrivalTime,
                Destination = entity.Destination,
                PointOfDeparture = entity.PointOfDeparture,
                TimeOfDeparture = entity.TimeOfDeparture,
                Ticket = GetTickets(entity.TicketId, tickets)
            };
        }

        static List<Ticket> GetTickets(int[] ids, IEnumerable<Ticket> allTickets)
        {
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < ids.Length; i++)
            {
                tickets.Add(allTickets.FirstOrDefault(s => s.Id == ids[i]));
            }

            return tickets;
        }
    }
}
