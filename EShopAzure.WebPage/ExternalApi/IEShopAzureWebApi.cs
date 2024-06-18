using EShopAzure.WebPage.ExternalApi.Models;
using Refit;

namespace EShopAzure.WebPage.ExternalApi;

internal interface IEShopAzureWebApi
{
    [Get("/weatherforecast")]
    Task<WeatherForecast[]> GetWeatherForecast();
}
