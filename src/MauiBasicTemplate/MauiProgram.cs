using MauiBasicTemplate.Services;
using MauiBasicTemplate.ViewModels;

namespace MauiBasicTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("MaterialIconsRegular.ttf", "Material");
			});

		builder.ConfigureServices();
		builder.ConfigureViewModels();

		return builder.Build();
	}

	public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
    {
		builder.Services.AddSingleton<IDataService, DataService>();

		return builder;
    }

	public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<FetchDataViewModel>();

		return builder;
	}
}
