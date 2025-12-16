using System.Collections.Immutable;
using POO_Project_Manager.Enums;

namespace POO_Project_Manager.Models;

public record Task(
    Guid Id,
    string Title,
    Enums.TaskStatus Status,
    Guid? AssigneeId,
    ImmutableList<Comment> Comments)
{
    public Task WithStatusUpdated(Enums.TaskStatus newStatus)
    {
        return this with { Status = newStatus };
    }
}
