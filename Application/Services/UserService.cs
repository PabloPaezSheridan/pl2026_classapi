using System;
using Domain.Entities;

namespace Application.Services;

public class UserService
{
    public List<User> GetAllUsers()
    {
        // This is just a placeholder. In a real application, you would retrieve users from a database.
        return new List<User>
        {
            new User { Id = Guid.NewGuid(), Name = "Alice", Email = "alice@gmail.com" },
            new User { Id = Guid.NewGuid(), Name = "Bob", Email = "bob"}
        };
    }

}
