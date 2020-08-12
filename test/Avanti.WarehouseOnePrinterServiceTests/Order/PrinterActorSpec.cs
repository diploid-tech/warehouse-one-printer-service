using System;
using System.Globalization;
using Akka.Actor;
using AutoMapper;
using Avanti.Core.EventStream;
using Avanti.Core.Microservice;
using Avanti.Core.Microservice.Middleware;
using Avanti.Core.RelationalData;
using Avanti.Core.Unittests;
using Avanti.WarehouseOnePrinterService.Order;
using Avanti.WarehouseOnePrinterService.Order.Mappings;
using NSubstitute;

namespace Avanti.WarehouseOnePrinterServiceTests.Order
{
    public partial class PrinterActorSpec : WithSubject<IActorRef>
    {
        private PrinterActorSpec()
        {
            Subject = Sys.ActorOf(Props.Create<PrinterActor>());
        }
    }
}
