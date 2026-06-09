using UnitTests.Mocks;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void test_get_all_users_not_null()
    {
        // Preparacion
        UserService userService = new UserService(new MockUserRepository());

        // Ejecucion
        var users = userService.GetAllUsers();

        // Verificacion
        Assert.NotNull(users);
    }

    [Fact]
    public void test_get_all_users_count()
    {
        // Preparacion
        UserService userService = new UserService(new MockUserRepository());

        // Ejecucion
        var users = userService.GetAllUsers();

        // Verificacion
        Assert.Equal(3, users.Count);
    }
}
