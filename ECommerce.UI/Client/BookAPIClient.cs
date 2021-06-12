using ECommerce.UI.Models.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UI.Client
{
    public class BookAPIClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializer _jsonSerializer;
        public BookAPIClient(HttpClient client, JsonSerializer jsonSerializer)
        {
            _client = client;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<List<BookResponse>> GetAllBooks()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "/Book/GetAll");

            var response = await _client.SendAsync(requestMessage);

            response.EnsureSuccessStatusCode();

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    return _jsonSerializer.Deserialize<List<BookResponse>>(jsonTextReader);
                }
            }




        }
    }
}
