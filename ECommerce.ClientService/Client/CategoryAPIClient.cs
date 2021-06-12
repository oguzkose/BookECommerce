using ECommerce.Service.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.ClientService.Client
{
    public class CategoryAPIClient:BaseClient
    {
       
        public CategoryAPIClient(HttpClient client, JsonSerializer jsonSerializer):base(client,jsonSerializer)
        {
           
        }


        /// <summary>
        /// Bütün kategorileri getiren API'yi consume eder.
        /// </summary>
        /// <returns>Task<List<CategoryResponse>></returns>
        public async Task<List<CategoryResponse>> GetAllCategories()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "/category/getall");

            return await GetAllSendAsync<List<CategoryResponse>>(requestMessage);
        }


        /// <summary>
        /// Id'ye göre categoriyi getiren API'yi consume eder.  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task<CategoryResponse></returns>
        public async Task<CategoryResponse> GetByCategoryId(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"/category/getbyid/{id}");

            return await GetByIdSendAsync<CategoryResponse>(requestMessage);
        }
       
    }
}
