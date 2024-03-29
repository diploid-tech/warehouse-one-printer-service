using Akka.Event;

namespace Avanti.WarehouseOnePrinterService.Order;

public partial class PrinterActor : ReceiveActor
{
    private readonly ILoggingAdapter log = Logging.GetLogger(Context);

    public PrinterActor()
    {
        Receive<ExecuteJob>(m => this.Sender.Tell(Handle(m)));
    }

    private IResponse Handle(ExecuteJob m)
    {
        this.log.Info($"TODO: Should create print job for warehouse order {m.Id} with {m.Lines.Count()} lines...");
        return new JobCompleted();
    }
}
