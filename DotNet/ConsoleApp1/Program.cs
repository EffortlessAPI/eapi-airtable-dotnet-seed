using EffortlessApi.SassyMQ.Lib;
using GwPlatform.Lib.DataClasses;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var amqps = "amqps://smqPublic:smqPublic@effortlessapi-rmq.ssot.me/jmillar-gw-platform";
            var guest = new SMQGuest(amqps);
            var payload = guest.CreatePayload();
            payload.EmailAddress = "test@test.com";
            payload.DemoPassword = "password123";
            var waiting = false;
            guest.ValidateTemporaryAccessToken(payload, (reply, bdea) =>
            {
                var admin = new SMQAdmin(amqps);
                admin.AccessToken = reply.AccessToken;
                payload = admin.CreatePayload();

                admin.GetGNodes(payload, (nsReply, nsBdea) =>
                {
                    Console.WriteLine(JsonConvert.SerializeObject(nsReply.GNodes, Formatting.Indented));
                    waiting = false;
                }, (error, ebdea) =>
                {
                    Console.WriteLine("ERROR: {0}", error.ErrorMessage);
                    waiting = false;
                });
            }, (error, ebdea) =>
            {
                Console.WriteLine("ERROR: {0}", error.ErrorMessage);
                    waiting = false;
            });
            Task.Factory.StartNew(() =>
            {
                while (waiting)
                {
                    Thread.Sleep(10);
                }
            }).Wait();
        }
    }
}
