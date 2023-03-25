using Avanti.Core.Microservice.Actors;
using Avanti.Core.Microservice.Extensions;

namespace Avanti.WarehouseOnePrinterService.Order;

public class PrinterActorProvider : BaseActorProvider<PrinterActor>
{
    public PrinterActorProvider(ActorSystem actorSystem)
    {
        this.ActorRef = actorSystem.ActorOfWithDI<PrinterActor>("printer-actor");
    }
}
