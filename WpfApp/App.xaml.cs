using System.Windows;

namespace WpfApp
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            new Bootstrapper().Run();
        }
    }
}