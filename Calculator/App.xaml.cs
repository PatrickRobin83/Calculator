using System.Windows;
using Calculator.Core.Calculations;
using Calculator.Core.Helpers;
using Prism.Ioc;
using Prism.Unity;
using Calculator.Views;
using Unity.Lifetime;

namespace Calculator
{
    /// <summary>
    ///Interaktionslogik für "App.xaml"
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
            containerRegistry.RegisterSingleton<ContainerHelper>();
        }


        protected override void InitializeShell(Window shell)
        {
            Application.Current.MainWindow?.Show();
        }
    }
}
