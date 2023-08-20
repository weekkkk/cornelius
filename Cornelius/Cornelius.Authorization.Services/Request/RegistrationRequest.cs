namespace Cornelius.Authorization.Services.Request;

public class RegistrationRequest
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}