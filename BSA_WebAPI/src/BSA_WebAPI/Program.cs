using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using SimpleInjector;
using DAL;

namespace BSA_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //    var container = new Container();
        //    container.Register<IUnitOfWork, UnitOfWork>();

        //    container.Register<ITicketService, TicketService>();
        //    container.Register<IAirplaneService, AirplaneService>();
        //    container.Register<IAirplaneTypeService, AirplaneTypeService>();
        //    container.Register<ICrewService, CrewService>();
        //    container.Register<IDepartureService, DepartureService>();
        //    container.Register<IFlightService, FlightService>();
        //    container.Register<IPilotService, PilotService>();
        //    container.Register<IStewardessService, StewardessService>();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
