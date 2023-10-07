using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // gRPC Client could be any type of project: console, web, api ...

            //var input = new HelloRequest() { Name = "Hasan" };


            //var channel = GrpcChannel.ForAddress("https://localhost:7187");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            var channel = GrpcChannel.ForAddress("https://localhost:7187");
            var customerClient = new Customer.CustomerClient(channel);

            var input = new CustomerLookupModel { UserId = 1 };


            var customer = await customerClient.GetCustomerInfoAsync(input);
            Console.WriteLine($" {customer.FirstName}  {customer.LastName}");


            Console.ReadKey();
        }
    }
}