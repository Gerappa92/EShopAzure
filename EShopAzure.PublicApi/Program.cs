using EShopAzure.PublicApi.Components;
using EShopAzure.PublicApi.ExternalApi;
using EShopAzure.PublicApi.Options;
using Microsoft.Extensions.Options;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<ExternalApisOptions>(
    builder.Configuration.GetSection(ExternalApisOptions.Position));

builder.Services
    .AddRefitClient<IEShopAzureWebApi>()
    .ConfigureHttpClient((sp, c) => {
        var api = sp.GetService<IOptions<ExternalApisOptions>>();
        if(api == null)
        {
            throw new ArgumentNullException(nameof(api));
        }
        c.BaseAddress = new Uri(api.Value.EShopAzureWebApi.BaseAddress);
        }
    );

builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
