
namespace Cornelius.Product.Models;

public abstract class BaseEntity: IBaseEntity
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdate { get; set; }
}