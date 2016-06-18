using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCard
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerShell ps = PowerShell.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            ps.Runspace = runspace;
            ps.AddCommand("Invoke-Expression");
          
            //ps.AddArgument("netsh interface set interface \"Local Area Connection\" admin=enable");
            //ps.AddArgument("set address name= \"Local Area Connection\" source=static addr=192.168.19.235 mask=255.255.240.0 gateway=192.168.19.238");

            ps.AddArgument("netsh interface ipv4 show interfaces");

            // if you need the result save it in a psobject
            Collection<PSObject> result = ps.Invoke();
            runspace.Close();
        }
    }
}
