using System;
using Domain.Interfaces;

namespace Application.Services;

public class TheOneAPIService
{
    private readonly ITheOneAPIHandler _theOneAPIHandler;
    public TheOneAPIService(ITheOneAPIHandler theOneAPIHandler)
    {
        _theOneAPIHandler = theOneAPIHandler;
    }

    public async Task<string?> GetAllBooks()
    {
        return await _theOneAPIHandler.GetAllBooks();
    }
}
