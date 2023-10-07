using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;

        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if (request.UserId == 1)
            {
                output.FirstName = "Hasan";
                output.LastName = "Darwish";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Khalid";
                output.LastName = "Darwish";
            }
            else
            {
                output.FirstName = "Lama";
                output.LastName = "Darwish";
            }

            return Task.FromResult(output);
        }
    }
}
