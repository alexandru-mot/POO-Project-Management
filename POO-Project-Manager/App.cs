using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using POO_Project_Manager.Services;
using POO_Project_Manager.UI;

namespace POO_Project_Manager;

public class App : IHostedService
{
    private readonly ILogger<App> _logger;
    private readonly ProjectCoordinator _coordinator;
    private readonly UserInterface _ui;

    public App(ILogger<App> logger, ProjectCoordinator coordinator, UserInterface ui)
    {
        _logger = logger;
        _coordinator = coordinator;
        _ui = ui;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Run();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public void Run()
    {
        // Application logic
        _logger.LogInformation("App running...");
    }
}
