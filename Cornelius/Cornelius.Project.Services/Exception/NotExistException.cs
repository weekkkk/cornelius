﻿namespace Cornelius.Project.Services.Exception;

public class NotExistException:System.Exception
{
    public NotExistException(string? message) : base(message)
    {
    }
}
