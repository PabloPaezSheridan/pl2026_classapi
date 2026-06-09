using Domain.Entities;
using Domain.Interfaces;

namespace UnitTests.Mocks;

public class MockUserRepository : IUserRepository
{
    private readonly List<User> _users = new()
    {
        new User { Email = "test1@example.com", Name = "Test User 1" },
        new User { Email = "test2@example.com", Name = "Test User 2" }
    };

    public List<User> GetAll() => _users;

    public void Remove(string email)
    {
        _users.RemoveAll(u => u.Email == email);
    }
}
