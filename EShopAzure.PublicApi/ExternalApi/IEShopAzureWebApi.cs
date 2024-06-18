using EShopAzure.PublicApi.ExternalApi.Models;
using Refit;

namespace EShopAzure.PublicApi.ExternalApi;

internal interface IEShopAzureWebApi
{
    [Get("/weatherforecast")]
    Task<WeatherForecast[]> GetWeatherForecast();
}
