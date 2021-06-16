using ECommerce.Service.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
<<<<<<< HEAD

            return await GetMethodsSendAsync<List<CategoryResponse>>(requestMessage);
        }

=======

            return await GetAllSendAsync<List<CategoryResponse>>(requestMessage);
        }
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b

        /// <summary>
        /// Id'ye göre kategoriyi getiren API'yi consume eder.  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task<CategoryResponse></returns>
        public async Task<CategoryResponse> GetByCategoryId(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"/category/getbyid/{id}");

<<<<<<< HEAD
            return await GetMethodsSendAsync<CategoryResponse>(requestMessage);

        }

        /// <summary>
        /// Id'ye göre kategoriyi silen API'yi consume eder.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> DeleteCategory(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"/Category/Delete/{id}");
            return await DeleteMethodsSendAsync(requestMessage);
=======
        /// <summary>
        /// Id'ye göre categoriyi getiren API'yi consume eder.  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task<CategoryResponse></returns>
        public async Task<CategoryResponse> GetByCategoryId(int id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"/category/getbyid/{id}");

            return await GetByIdSendAsync<CategoryResponse>(requestMessage);
>>>>>>> df3c8afce25b87a713b989fee67f9aca24b4298b
        }
       
    }
}
