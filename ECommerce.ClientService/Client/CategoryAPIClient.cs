using ECommerce.ClientService.Models.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.ClientService.Client
{
    public class CategoryAPIClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializer _jsonSerializer;
        public CategoryAPIClient(HttpClient client,JsonSerializer jsonSerializer)
        {
            _client = client;
            _jsonSerializer = jsonSerializer;
        }
        public async Task< List<CategoryResponse>> GetAllCategories()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "/category/getall");
            var response = await _client.SendAsync(requestMessage);

            response.EnsureSuccessStatusCode();

            using (var responseStream= await response.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    return _jsonSerializer.Deserialize<List<CategoryResponse>>(jsonTextReader);
                }
            }



            
        }
    }
}
