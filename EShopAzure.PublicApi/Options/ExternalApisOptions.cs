using EShopAzure.PublicApi.ExternalApi;

namespace EShopAzure.PublicApi.Options;

public class ExternalApisOptions
{
    public const string Position = "ExternalApis";
    public ExternalApiConnection EShopAzureWebApi { get; set; }

    public class ExternalApiConnection
    {
        public string BaseAddress { get; set; }
    }
}


