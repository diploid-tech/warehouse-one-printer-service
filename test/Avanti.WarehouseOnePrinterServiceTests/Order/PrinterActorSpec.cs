using Akka.Actor;
using Avanti.Core.Unittests;
using Avanti.WarehouseOnePrinterService.Order;

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
