namespace POO_Project_Manager.Models;

public record Comment(Guid AuthorId, string Content, DateTime Timestamp);
