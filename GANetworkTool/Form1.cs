using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GANetworkTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowNICS_Click(object sender, EventArgs e)
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

            foreach(PSObject obj in result)
            {
                
                lstSystemMessage.Items.Add(obj.BaseObject);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = "192.168.19.235";
            txtSubnet.Text = "255.255.240.0";
            txtGateway.Text = "192.168.19.238";

        }

        private void btnSetAdapter_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            ps.Runspace = runspace;
            ps.AddCommand("Invoke-Expression");

            //ps.AddArgument("netsh interface set interface \"Local Area Connection\" admin=enable");
            ps.AddArgument("netsh interface ipv4 set address \"Ethernet\" static 192.168.19.234 255.255.240.0 192.168.19.238 1");

          //  ps.AddArgument("netsh interface ipv4 show interfaces");

            // if you need the result save it in a psobject
            Collection<PSObject> result = ps.Invoke();
            runspace.Close();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            ps.Runspace = runspace;
            ps.AddCommand("Invoke-Expression");

            //ps.AddArgument("netsh interface set interface \"Local Area Connection\" admin=enable");
            ps.AddArgument("netsh interface set interface \"Ethernet\" admin=enable");

            //  ps.AddArgument("netsh interface ipv4 show interfaces");

            // if you need the result save it in a psobject
            Collection<PSObject> result = ps.Invoke();
            runspace.Close();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            ps.Runspace = runspace;
            ps.AddCommand("Invoke-Expression");

            //ps.AddArgument("netsh interface set interface \"Local Area Connection\" admin=enable");
            ps.AddArgument("netsh interface set interface \"Ethernet\" admin=disable");

            //  ps.AddArgument("netsh interface ipv4 show interfaces");

            // if you need the result save it in a psobject
            Collection<PSObject> result = ps.Invoke();
            runspace.Close();
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
           
                 PowerShell ps = PowerShell.Create();
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            ps.Runspace = runspace;
            ps.AddCommand("Invoke-Expression");

            //ps.AddArgument("netsh interface set interface \"Local Area Connection\" admin=enable");
            ps.AddArgument("netsh interface ip set address \"Ethernet\" dhcp");

            //  ps.AddArgument("netsh interface ipv4 show interfaces");

            // if you need the result save it in a psobject
            Collection<PSObject> result = ps.Invoke();
            runspace.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Debug.WriteLine(adapter.Description);
                Debug.WriteLine("  DNS suffix .............................. : {0}",
                    properties.DnsSuffix);
                Debug.WriteLine("  DNS enabled ............................. : {0}",
                    properties.IsDnsEnabled);
                Debug.WriteLine("  Dynamically configured DNS .............. : {0}",
                    properties.IsDynamicDnsEnabled);

                lstSystemMessage.Items.Add(adapter.Name + " " + adapter.GetPhysicalAddress().ToString());
            }
            Console.WriteLine();
        }

  
    }
}
