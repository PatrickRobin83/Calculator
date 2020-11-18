using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Calculator.Views;
namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void InitializeShell(Window shell)
        {
            Application.Current.MainWindow?.Show();
        }
    }
}
