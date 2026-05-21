using DrawnUi.Draw;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpaceShooter;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

DrawnExtensions.RegisterFont("FontGame", "/fonts/Orbitron-Regular.ttf");
DrawnExtensions.RegisterFont("FontGameMedium", "/fonts/Orbitron-Medium.ttf");
DrawnExtensions.RegisterFont("FontGameSemiBold", "/fonts/Orbitron-SemiBold.ttf");
DrawnExtensions.RegisterFont("FontGameBold", "/fonts/Orbitron-Bold.ttf");
DrawnExtensions.RegisterFont("FontGameExtraBold", "/fonts/Orbitron-ExtraBold.ttf");

var host = await builder.UseDrawnUiAsync(new DrawnUiStartupSettings
{
    UseDesktopKeyboard = true
});

await host.RunAsync();
