namespace Mobile.App.Application.ConnectivityService
{
    public class ConnectivityService : IConnectivityService
    {
        public ConnectivityService()
        {
            Connected = false;
        }

        public bool Connected { get; private set; }
    }
}
