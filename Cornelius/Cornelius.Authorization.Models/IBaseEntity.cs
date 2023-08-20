namespace Cornelius.Authorization.Models;

public interface IBaseEntity
{
    Guid Id { get; set; }
    DateTime DateCreate { get; set; }
    DateTime DateChange { get; set; }
}