using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using CoAP.Server.Resources;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

class RTTResource : Resource
{
    private int temp = 0;

    public RTTResource(String name)
        : base(name)
    {
        string clientId = Guid.NewGuid().ToString();
    }

    protected override void DoGet(CoapExchange exchange) //GET
    {
        DateTime time = DateTime.Now;
        Temperature temperature = new Temperature();
        temperature.GetTemp();
        exchange.Respond(DateTime.Now.Subtract(time).ToString());
        Console.WriteLine(DateTime.Now.Subtract(time).ToString());
    }

 
}

