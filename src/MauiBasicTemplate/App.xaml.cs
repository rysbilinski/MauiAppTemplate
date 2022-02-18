#if ANDROID
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif


namespace MauiBasicTemplate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();

#if ANDROID
		Microsoft.Maui.Handlers.EntryHandler.EntryMapper.AppendToMapping("NoUnderline", (h, v) =>
		{
			h.NativeView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
		});
#endif
	}
}
