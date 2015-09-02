using NInject_Dependency_Injection.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInject_Dependency_Injection
{
    class Caller
    {
        private IConsoleText consoleText;
        public Caller(IConsoleText consoleText)
        {
            this.consoleText = consoleText;
        }


        public void Write()
        {
            this.consoleText.GetConsoleText();
        }
    }
}
