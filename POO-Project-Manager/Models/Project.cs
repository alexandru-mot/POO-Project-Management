using System.Collections.Immutable;

namespace POO_Project_Manager.Models;

public record Project(
    Guid Id,
    string Name,
    DateTime Deadline,
    ImmutableList<Guid> MemberIds,
    ImmutableList<Task> Tasks)
{
    public Project WithTaskAdded(Task task)
    {
        return this with { Tasks = Tasks.Add(task) };
    }

    public Project WithMemberAdded(Guid memberId)
    {
        return this with { MemberIds = MemberIds.Add(memberId) };
    }
}
