using System.Threading.Tasks;

namespace Mobile.App.Presentation.ViewModels
{
    public class HomeViewModel
    {
        public Task SomeMethodAsync()
        {
            return Task.CompletedTask;
        }

        public Task GetDescriptionAsync()
        {
            return Task.CompletedTask;
        }
    }
}
