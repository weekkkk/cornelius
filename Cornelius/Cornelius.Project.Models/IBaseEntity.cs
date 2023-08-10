namespace Cornelius.Project.Models;

public interface IBaseEntity
{
    Guid Id { get; set; }
    DateTime DateCreated { get; set; }
    DateTime DateUpdate { get; set; }
}