using Microsoft.Extensions.Logging;

namespace VictorKrogh.Services;

public class ServiceBase<TService>(ILogger<TService> logger)
    where TService : class, IService
{
    protected ILogger<TService> Logger { get; } = logger;
}
