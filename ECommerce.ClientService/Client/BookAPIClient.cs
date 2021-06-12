using ECommerce.ClientService.Client;
using ECommerce.Service.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UI.Client
{
    public class BookAPIClient :BaseClient
    {
       
        public BookAPIClient(HttpClient client, JsonSerializer jsonSerializer):base(client,jsonSerializer)
        {
            
        }
        /// <summary>
        /// Bütün kitapları getiren API'yi consume eder.
        /// </summary>
        /// <returns>Task<List<BookResponse>></returns>
        public async Task<List<BookResponse>> GetAllBooks()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "/Book/GetAll");

            return await GetAllSendAsync<List<BookResponse>>(requestMessage);
            
        }
    }
}
