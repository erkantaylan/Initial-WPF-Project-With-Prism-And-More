using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace WpfApp
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Shell shell = Container.Resolve<Shell>();
            Application.Current.MainWindow = shell;
            shell.Show();
        }
    }
}