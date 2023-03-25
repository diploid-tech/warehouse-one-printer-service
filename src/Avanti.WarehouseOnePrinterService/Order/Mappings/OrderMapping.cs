using AutoMapper;
using Avanti.WarehouseOnePrinterService.Order.Api;

namespace Avanti.WarehouseOnePrinterService.Order.Mappings;

public class OrderMapping : Profile
{
    public OrderMapping()
    {
        CreateMap<PrivateApiController.PostOrderRequest, PrinterActor.ExecuteJob>();
        CreateMap<PrivateApiController.PostOrderRequest.OrderLine, PrinterActor.ExecuteJob.OrderLine>();
    }
}
