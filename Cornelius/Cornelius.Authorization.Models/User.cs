﻿namespace Cornelius.Authorization.Models;

public class User : BaseEntity
{
    public User(string login, string password, Role? role)
    {
        ArgumentNullException.ThrowIfNull(login);
        ArgumentNullException.ThrowIfNull(password);
        Login = login;
        Salt = BCrypt.Net.BCrypt.GenerateSalt();
        PasswordHash = BCrypt.Net.BCrypt.HashPassword((Salt + password));
        Role = role;
    }

    protected User()
    {
        
    }

    public string Login { get; set; }
    public string Salt { get; set; }
    public string PasswordHash { get; set; }
    public Role? Role { get; set; }
}