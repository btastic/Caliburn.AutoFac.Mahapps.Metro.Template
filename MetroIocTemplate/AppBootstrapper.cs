using System.Windows;
using Autofac;
using Caliburn.Micro.Autofac;
using MetroIocTemplate.ViewModels;

namespace MetroIocTemplate
{
    public class AppBootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            // Register IoC here
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}