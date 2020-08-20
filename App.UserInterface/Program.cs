using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var userNamse = System.Security.Principal.WindowsIdentity.GetCurrent().Owner;
        }
    }
}
