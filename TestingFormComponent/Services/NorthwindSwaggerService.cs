using System.Net.Http.Json;
using TestingFormComponent.Models.NorthwindSwagger;

namespace TestingFormComponent.NorthwindSwagger
{
    public class NorthwindSwaggerService: INorthwindSwaggerService
    {
        private readonly HttpClient _http;

        public NorthwindSwaggerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<CustomerDto> PostCustomerDto(object? data)
        {
            if (data == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            request.Content = new StringContent(@"{
  ""customerId"": ""string"",
  ""companyName"": ""string"",
  ""contactName"": ""string"",
  ""contactTitle"": ""string"",
  ""address"": {
    ""street"": ""string"",
    ""city"": ""string"",
    ""region"": ""string"",
    ""postalCode"": ""string"",
    ""country"": ""string"",
    ""phone"": ""string""
  }
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }
    }
}
