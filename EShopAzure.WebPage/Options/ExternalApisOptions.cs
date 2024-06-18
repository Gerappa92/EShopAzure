namespace EShopAzure.WebPage.Options;

public class ExternalApisOptions
{
    public const string Position = "ExternalApis";
    public ExternalApiConnection EShopAzureWebApi { get; set; }

    public class ExternalApiConnection
    {
        public string BaseAddress { get; set; }
    }
}


