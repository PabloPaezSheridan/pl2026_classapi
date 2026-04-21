using System;

namespace Domain.Interfaces;

public interface ITheOneAPIHandler
{
    Task<string?> GetAllBooks();

}
