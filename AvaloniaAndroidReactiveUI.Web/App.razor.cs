using Avalonia.Web.Blazor;

namespace AvaloniaAndroidReactiveUI.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaAndroidReactiveUI.App>()
            .SetupWithSingleViewLifetime();
    }
}