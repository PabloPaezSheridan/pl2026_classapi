using System;
using Domain.Interfaces;

namespace Infrastructure.ExternalServices;

public class TheOneAPIHandler : ITheOneAPIHandler
{
    private string AuthenticationToken { get; set; } = "lpEM4pSxoSZIfSabJxju";
    private HttpClient theOneApiClient;
    public TheOneAPIHandler()
    {
        theOneApiClient = new()
        {
            BaseAddress = new Uri("https://the-one-api.dev/v2/")
        };
        theOneApiClient.DefaultRequestHeaders.Add("Authorization", "Bearer lpEM4pSxoSZIfSabJxju");
    }

    public async Task<string?> GetAllBooks()
    {

        HttpResponseMessage httpResponseMessage = await theOneApiClient.GetAsync("book");
        return httpResponseMessage.Content.ToString();
    }

}
