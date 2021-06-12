using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ClientService.Client
{
    public abstract class BaseClient
    {

        private readonly HttpClient _client;
        private readonly JsonSerializer _jsonSerializer;
        public BaseClient(HttpClient client, JsonSerializer jsonSerializer)
        {
            _client = client;
            _jsonSerializer = jsonSerializer;
        }
        
        public async Task<TResponseType> GetAllSendAsync<TResponseType>(HttpRequestMessage requestMessage)
        {
            var response = await _client.SendAsync(requestMessage);

            response.EnsureSuccessStatusCode();

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    return _jsonSerializer.Deserialize<TResponseType>(jsonTextReader);
                }
            }
        }

        public async Task<TResponseType> GetByIdSendAsync<TResponseType>(HttpRequestMessage requestMessage)
        {
            var response = await _client.SendAsync(requestMessage);

            response.EnsureSuccessStatusCode();

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    return _jsonSerializer.Deserialize<TResponseType>(jsonTextReader);
                }
            }

        }
    }
}
