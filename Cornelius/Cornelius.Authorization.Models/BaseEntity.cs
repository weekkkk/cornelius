namespace Cornelius.Authorization.Models;

public abstract class BaseEntity: IBaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        DateCreate = DateTime.Now;
        DateChange = DateTime.Now;
    }

    public Guid Id { get; set; }
    public DateTime DateCreate { get; set; }
    public DateTime DateChange { get; set; }
}