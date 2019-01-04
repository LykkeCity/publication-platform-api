using System;
using Common;
using Microsoft.Extensions.DependencyInjection;

namespace PublicationPlatform.api
{
    public class DependencyResolver : IDependencyResolver, IDependencyRegistrator
    {
        private readonly IServiceCollection _serviceCollection;


        public DependencyResolver(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public T GetService<T>()
        {
            var sp = _serviceCollection.BuildServiceProvider();

            var srv = sp.GetService<T>();

            if (srv == null)
                throw new Exception("Service " + typeof(T) + " is not registered to Service collection");

            return srv;

        }

        public void AddSingleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            _serviceCollection.AddSingleton<TService, TImplementation>();
        }

        public void AddSingleton<TService, TImplementation>(TImplementation instance) where TService : class where TImplementation : class, TService
        {
            _serviceCollection.AddSingleton<TService>(instance);
        }

    }
}