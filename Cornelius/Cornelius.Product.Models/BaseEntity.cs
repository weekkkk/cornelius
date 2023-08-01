
namespace Cornelius.Product.Models;

public abstract class BaseEntity: IBaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        DateCreated = DateTime.Now;
        DateUpdate = DateTime.Now;
    }

    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdate { get; set; }
}