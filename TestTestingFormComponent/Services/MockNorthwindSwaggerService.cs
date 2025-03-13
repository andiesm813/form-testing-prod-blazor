using TestingFormComponent.Models.NorthwindSwagger;

namespace TestingFormComponent.NorthwindSwagger
{
    public class MockNorthwindSwaggerService : INorthwindSwaggerService
    {
        public Task<CustomerDto> PostCustomerDto(object? data)
        {
            return Task.FromResult<CustomerDto>(new());
        }
    }
}
