using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlFileServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFolder = @"..\..\myServerFolder";
            //SimpleHTTPServer myServer = new SimpleHTTPServer(myFolder);
            SimpleHTTPServer myServer = new SimpleHTTPServer(myFolder, 8084);
            Console.WriteLine("Server is running on this port: " + myServer.Port.ToString());
            Console.ReadLine();
        }
    }
}
