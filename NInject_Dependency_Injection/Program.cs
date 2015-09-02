using Ninject;
using NInject_Dependency_Injection.Infrastructure.Classes;
using NInject_Dependency_Injection.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInject_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninject.IKernel kernal = new StandardKernel();
            //kernal.Bind<IConsoleText>().To<TestConsoleText>();
            kernal.Bind<IConsoleText>().To<ConsoleText>();
            var instance = kernal.Get<Caller>();
            instance.Write();
            Console.Read();
        }
    }
}
