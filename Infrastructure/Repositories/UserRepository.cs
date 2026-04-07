using System.Security.Cryptography.X509Certificates;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure.Repositories;
public class UserRepository: IUserRepository
{
    public List<User> GetAll()
    {
        return DummyUserList.Users;
    }

    public void Remove(string email)
    {
        User? userToRemove = DummyUserList.Users.FirstOrDefault(u => u.Email == email);
        if (userToRemove != null)
        {
            DummyUserList.Users.Remove(userToRemove);
        }
    }
}