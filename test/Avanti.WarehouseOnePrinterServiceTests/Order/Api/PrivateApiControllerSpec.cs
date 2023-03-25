using AutoMapper;
using Avanti.Core.Microservice.Actors;
using Avanti.Core.Unittests;
using Avanti.WarehouseOnePrinterService.Order;
using Avanti.WarehouseOnePrinterService.Order.Api;
using Avanti.WarehouseOnePrinterService.Order.Mappings;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Avanti.WarehouseOnePrinterServiceTests.Order.Api;

public partial class PrivateApiControllerSpec : WithSubject<PrivateApiController>
{
    private readonly ProgrammableActor<PrinterActor> progPrinterActor;

    private PrivateApiControllerSpec()
    {
        progPrinterActor = Kit.CreateProgrammableActor<PrinterActor>("order-actor");
        IActorProvider<PrinterActor> printerActorProvider = An<IActorProvider<PrinterActor>>();
        printerActorProvider.Get().Returns(progPrinterActor.TestProbe);

        var config = new MapperConfiguration(cfg => cfg.AddProfile(new OrderMapping()));
        config.AssertConfigurationIsValid();

        Subject = new PrivateApiController(
            printerActorProvider,
            An<ILogger<PrivateApiController>>(),
            config.CreateMapper());
    }
}
