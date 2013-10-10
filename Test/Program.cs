using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace LVMCH.Test {
    class Program {
        static void Main(string[] args) {

            test();

            Console.ReadLine();
        }

        public static string test() {
            RunspaceConfiguration rconfig = RunspaceConfiguration.Create();
            PSSnapInException Pwarn = new PSSnapInException();
            Collection<PSObject> results = new Collection<PSObject>();
            Runspace runspace = RunspaceFactory.CreateRunspace();

            string test = "Import-Module -Name virtualmachinemanager\r\n";
            runspace = RunspaceFactory.CreateRunspace(rconfig);
            runspace.Open();

            Pipeline pipeline;

            pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(test);


            try {
                results = pipeline.Invoke();
                Console.WriteLine("Worked");
                return "";
            }
            catch (Exception ex) {
                Console.WriteLine("Failed "+ex.Message);
                return ex.Message;
            }
        } 
        
        
    }
}
