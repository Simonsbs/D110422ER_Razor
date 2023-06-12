using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace MyShop.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClient;
        public Dictionary<string, object> GitHubData { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClient) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IActionResult> OnGet() {
            _logger.LogWarning("This is a warning message");
            _logger.LogCritical("This is a Critical message");

            try {
                var client = _httpClient.CreateClient();
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1")); // set your own values here

                var response = await client.GetAsync("https://api.github.com/users/simonsbs");

                var rawData = await response.Content.ReadAsStringAsync();
                GitHubData = JsonSerializer.Deserialize<Dictionary<string, object>>(rawData) ??
                    new Dictionary<string, object>();
            } catch (Exception ex) {
                throw ex;
            }

            return Page();

        }
    }
}