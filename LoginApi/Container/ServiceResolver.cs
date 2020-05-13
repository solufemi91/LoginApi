using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using LoginApi.Repository;
using LoginApi.Wrapper;

namespace LoginApi.Container
{
    public class ServiceResolver
    {
        private static WindsorContainer container;
        private static IServiceProvider serviceProvider;

        public ServiceResolver(IServiceCollection services)
        {
            container = new WindsorContainer();

            container.Register(Component.For<ILoginRepository>().ImplementedBy<LoginRepository>());
            container.Register(Component.For<ILoginWrapper>().ImplementedBy<LoginWrapper>());

            serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(container, services);
        }

        public IServiceProvider GetServiceProvider()
        {
            return serviceProvider;
        }
    }
}
