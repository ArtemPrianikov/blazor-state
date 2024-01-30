namespace Junk.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.SessionStorage;
using Blazored.LocalStorage;
using BlazorState.Features.Persistence.Abstractions;
using TimeWarpState.Middleware.PersistentState;
using BlazorState;

public class Program
{
  private static async Task Main(string[] args)
  {
	var builder = WebAssemblyHostBuilder.CreateDefault(args);
    ConfigureServices(builder.Services);

	await builder.Build().RunAsync();
  }
  public static void ConfigureServices(IServiceCollection serviceCollection)
  {
    serviceCollection.AddBlazoredSessionStorage();
    serviceCollection.AddBlazoredLocalStorage();
    serviceCollection.AddBlazorState
    (
      options =>
      {
        options.UseReduxDevTools();
        options.Assemblies =
        new[]
        {
          typeof(Program).GetTypeInfo().Assembly,
          typeof(StateInitializedNotificationHandler).GetTypeInfo().Assembly
        };
      }
    );

    serviceCollection.AddScoped<IPersistenceService, PersistenceService>();
    serviceCollection.AddTransient(typeof(IRequestPostProcessor<,>), typeof(PersistentStatePostProcessor<,>));
  }
}
