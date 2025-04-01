using System.Windows;
using VBDebuggerMarshalling;

namespace Rrs.VB6DebuggerMarshalling.App;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        var factory = new DotNetObjectFactory();
        var vbStartup = new VBStartup();
        vbStartup.Startup(factory);
        Shutdown();
    }
}

