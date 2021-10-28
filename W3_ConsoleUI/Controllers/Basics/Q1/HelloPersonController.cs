using ConsoleMVCPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_ConsoleUI.Controllers.Basics.Q1
{
    class HelloPersonController : IController
    {
        public IView View { get; set; }

        public void RequestView(IView view)
        {
            throw new NotImplementedException();
        }

        public IView ResponseView()
        {
            throw new NotImplementedException();
        }
    }
}
