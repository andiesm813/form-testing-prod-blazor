using TestingFormComponent.Models.NorthwindSwagger;

namespace TestingFormComponent.NorthwindSwagger
{
    public interface INorthwindSwaggerService
    {
        Task<CustomerDto> PostCustomerDto(object? data);
    }
}
