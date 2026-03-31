using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure.Repositories;
public class UserRepository: IUserRepository
{
    public List<User> GetAll()
    {
        return new List<User>()
        {
            new() { 
                    Id = new Guid("a3c9e2b1-4f2e-4b6a-9c2a-1b2c3d4e5f6a"),
                    Name = "Pablo",
                    Email = "pablo@email.com"
                }
        };
    }
}