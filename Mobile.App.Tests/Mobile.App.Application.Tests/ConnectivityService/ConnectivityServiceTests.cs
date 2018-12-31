using Xunit;

namespace Mobile.App.Application.Tests.ConnectivityService
{
    public class ConnectivityServiceTests
    {
        [Fact]
        public void Connected_ReturnsFalse()
        {
            // Arrange
            var connectivity = new Application.ConnectivityService.ConnectivityService();

            // Act

            // Assert
            Assert.False(connectivity.Connected);
        }
    }
}
