using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
<<<<<<< HEAD
using System.Net;
=======
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
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
<<<<<<< HEAD

        public async Task<TResponseType> GetMethodsSendAsync<TResponseType>(HttpRequestMessage requestMessage)
=======
        
        public async Task<TResponseType> GetAllSendAsync<TResponseType>(HttpRequestMessage requestMessage)
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
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

<<<<<<< HEAD
        public async Task<HttpStatusCode> DeleteMethodsSendAsync(HttpRequestMessage requestMessage)
        {
            var response = await _client.SendAsync(requestMessage);
            return response.StatusCode;
=======
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

>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
        }
    }
}
