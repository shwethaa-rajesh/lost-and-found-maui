using Microsoft.Extensions.Logging;

namespace LostAndFound;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
    //    Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (h, v) => {
			
			 //h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf( Android.Graphics.Color.Transparent); });
            var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

