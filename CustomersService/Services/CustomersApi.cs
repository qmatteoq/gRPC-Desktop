using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CustomersService
{
    public class CustomersApi : CustomersEndpoint.CustomersEndpointBase
    {
        private readonly ILogger<CustomersApi> _logger;
        public CustomersApi(ILogger<CustomersApi> logger)
        {
            _logger = logger;
        }

        public override async Task<SaveCustomerResponse> SaveCustomer(SaveCustomerRequest request, ServerCallContext context)
        {
            await Task.Delay(1000);
            return new SaveCustomerResponse
            {
                Message = $"{request.Name} {request.Surname} - {request.Mail}"
            };
        }
    }
}
