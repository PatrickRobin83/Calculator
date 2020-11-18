using System.Windows;
using System.Xaml;
using Calculator.Core.Calculations;
using Prism.Ioc;
using Prism.Unity;
using Calculator.Views;
using Unity;

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
            containerRegistry.Register<ICalculator, ExpressionCalculator>();
        }

        protected override void InitializeShell(Window shell)
        {
            Application.Current.MainWindow?.Show();
        }

    }
}
