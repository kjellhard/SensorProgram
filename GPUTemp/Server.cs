using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoAP.Server.Resources;
using CoAP.Server;
class Server
{
    public void StartServer()
    {
        CoapServer server = new CoapServer();

        server.Add(new TempResource("temp"));

        try
        {
            server.Start();

            Console.Write("CoAP server [{0}] is listening on", server.Config.Version);

            foreach (var item in server.EndPoints)
            {
                Console.Write(" ");
                Console.Write(item.LocalEndPoint);
            }
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Press any key to stop server");
        Console.ReadKey();

    }
}