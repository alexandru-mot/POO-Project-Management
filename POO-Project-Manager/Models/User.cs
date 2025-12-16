using POO_Project_Manager.Enums;

namespace POO_Project_Manager.Models;

public record User(Guid Id, string Username, UserRole Role);
