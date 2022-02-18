using MauiBasicTemplate.Pages;

namespace MauiBasicTemplate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
	}
}