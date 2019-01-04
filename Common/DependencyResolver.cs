using System;

namespace Common
{
    public interface IDependencyResolver
    {
        T GetService<T>();
    }


    public interface IDependencyRegistrator
    {
        void AddSingleton<TService, TImplementation>() where TService : class where TImplementation : class, TService;

        void AddSingleton<TService, TImplementation>(TImplementation instance)
            where TService : class where TImplementation : class, TService;
        
        //  void AddSingleton<TImplementation>()  where TImplementation : class;        
    }
}