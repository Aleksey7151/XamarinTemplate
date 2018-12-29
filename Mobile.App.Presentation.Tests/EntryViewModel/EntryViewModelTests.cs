using Xunit;

namespace Mobile.App.Presentation.Tests.EntryViewModel
{
    public class EntryViewModelTests
    {
        [Fact]
        public void Add_ReturnsAdditionResult()
        {
            // Arrange
            var entry = new ViewModels.EntryViewModel();

            // Act
            var c = entry.Add(5, 3);

            // Assert
            Assert.True(c == 8);
        }
    }
}
