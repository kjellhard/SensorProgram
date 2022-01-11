using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using CoAP.Server.Resources;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

class TempResource : Resource
{
    private int temp = 0;

    public TempResource(String name)
        : base(name)
    {
        string clientId = Guid.NewGuid().ToString();
    }

    protected override void DoGet(CoapExchange exchange) //GET
    {
        Temperature temperature = new Temperature();
        exchange.Respond("Temperature = " + temperature.GetTemp());
    }

    //protected override void DoPost(CoapExchange exchange) //POST
    //{
    //    try
    //    {
    //        temp = Int32.Parse(exchange.Request.PayloadString);
    //        exchange.Respond("Temp is now set to: " + temp);
    //    }
    //    catch (FormatException)
    //    {
    //        exchange.Respond(exchange.Request.PayloadString + " is of incorrect format\nPrev temp was: " + temp);
    //    }
    //}

    //protected override void DoPut(CoapExchange exchange) //PUT
    //{
    //    try
    //    {
    //        temp = Int32.Parse(exchange.Request.PayloadString);
    //        exchange.Respond("Temp is now set to: " + temp);
    //    }
    //    catch (FormatException)
    //    {
    //        exchange.Respond(exchange.Request.PayloadString + " is of incorrect format\nPrev temp was: " + temp);
    //    }
    //}

    //protected override void DoDelete(CoapExchange exchange) //DELETE
    //{
    //    temp = 0;
    //    exchange.Respond("Temp is now set to: " + 0);
    //}
}

