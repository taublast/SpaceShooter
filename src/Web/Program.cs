using DrawnUi.Draw;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpaceShooter;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var assetBaseUri = new Uri(builder.HostEnvironment.BaseAddress);

DrawnExtensions.RegisterFont("FontGame", BuildAssetUrl(assetBaseUri, "fonts/Orbitron-Regular.ttf"));
DrawnExtensions.RegisterFont("FontGameMedium", BuildAssetUrl(assetBaseUri, "fonts/Orbitron-Medium.ttf"));
DrawnExtensions.RegisterFont("FontGameSemiBold", BuildAssetUrl(assetBaseUri, "fonts/Orbitron-SemiBold.ttf"));
DrawnExtensions.RegisterFont("FontGameBold", BuildAssetUrl(assetBaseUri, "fonts/Orbitron-Bold.ttf"));
DrawnExtensions.RegisterFont("FontGameExtraBold", BuildAssetUrl(assetBaseUri, "fonts/Orbitron-ExtraBold.ttf"));

var host = await builder.UseDrawnUiAsync(new DrawnUiStartupSettings
{
    UseDesktopKeyboard = true
});

await host.RunAsync();

static string BuildAssetUrl(Uri baseUri, string relativePath)
{
    return new Uri(baseUri, relativePath).ToString();
}
