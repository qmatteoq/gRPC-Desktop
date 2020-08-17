using CustomersService;
using CustomersServiceLibrary.Model;
using Grpc.Net.Client;
using System.Threading.Tasks;

namespace CustomersServiceLibrary
{
public class CustomersApi
{
    public async Task<string> SaveCustomerAsync(Customer customer)
    {
        SaveCustomerRequest request = new SaveCustomerRequest
        {
            Name = customer.Name,
            Surname = customer.Surname,
            Mail = customer.Mail
        };

        var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new CustomersEndpoint.CustomersEndpointClient(channel);

        var response = await client.SaveCustomerAsync(request);
        return response.Message;
    }
}
}
