using ECommerce.ClientService.Client;
using ECommerce.Service.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
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

            return await GetMethodsSendAsync<List<BookResponse>>(requestMessage);
            
        }

        public async Task<BookResponse> GetByBookId(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"/Book/GetById/{id}");

            return await GetMethodsSendAsync<BookResponse>(requestMessage);
        }


        /// <summary>
        /// Id'ye göre kitap silen API'yi consume eder.
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>Task<HttpStatusCode></returns>
        public async Task<HttpStatusCode> DeleteBook(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"/Book/Delete/{id}");

            return await DeleteMethodsSendAsync(requestMessage);
        }
    }
}
