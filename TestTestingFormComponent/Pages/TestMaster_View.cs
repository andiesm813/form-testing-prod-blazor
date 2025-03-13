using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestingFormComponent.Pages;
using TestingFormComponent.NorthwindSwagger;

namespace TestTestingFormComponent
{
  [Collection("TestingFormComponent")]
  public class TestMaster_View
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbInputModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbSnackbarModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Master_View>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
