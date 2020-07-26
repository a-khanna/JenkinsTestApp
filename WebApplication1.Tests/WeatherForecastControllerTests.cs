using Moq;
using WebApplication1.Controllers;
using WebApplication1.Logic;
using Xunit;

namespace WebApplication1.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ShouldCallWeatherLogic()
        {
            // Arrange
            var logicMock = new Mock<IWeatherLogic>();
            var controller = new WeatherForecastController(logicMock.Object);

            // Act
            controller.Get();

            // Assert
            logicMock.Verify(l => l.GetWeather(), Times.Once);
        }
    }
}
