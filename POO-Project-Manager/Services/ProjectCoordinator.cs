using Microsoft.Extensions.Logging;
using POO_Project_Manager.Models;
using POO_Project_Manager.Enums;
using Task = POO_Project_Manager.Models.Task;
using TaskStatus = POO_Project_Manager.Enums.TaskStatus;

namespace POO_Project_Manager.Services;

public class ProjectCoordinator
{
    private List<Project> _projects = new();
    private List<User> _users = new();
    private readonly ILogger<ProjectCoordinator> _logger;

    public ProjectCoordinator(ILogger<ProjectCoordinator> logger)
    {
        _logger = logger;
    }

    public void RegisterUser(string username, UserRole role)
    {
        // Implementation
    }

    public void CreateProject(Guid managerId, string details)
    {
        // Implementation
    }

    public void AssignTask(Guid projectId, Guid taskId, Guid userId)
    {
        // Implementation
    }

    public void UpdateTaskStatus(Guid userId, Guid taskId, TaskStatus status)
    {
        // Implementation
    }

    public void GetProjectReport()
    {
        // Implementation
    }

    private void ValidationLogic()
    {
        // Implementation
    }
}
