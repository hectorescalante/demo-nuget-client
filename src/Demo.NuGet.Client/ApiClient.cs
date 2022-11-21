namespace Demo.NuGet.Client
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task HealthCheck()
        {
            await _httpClient.GetAsync("http://localhost/healthz");
        }
    }
}