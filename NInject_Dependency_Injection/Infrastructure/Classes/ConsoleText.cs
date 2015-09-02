using NInject_Dependency_Injection.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInject_Dependency_Injection.Infrastructure.Classes
{
    public class ConsoleText : IConsoleText
    {
        public void GetConsoleText()
        {
            Console.WriteLine("This is not a Test!");
        }
    }
}
