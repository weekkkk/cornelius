namespace Cornelius.Authorization.Services.Exception;

public class EntityExistException:System.Exception
{
    public EntityExistException(string? message) : base(message)
    {
    }
}