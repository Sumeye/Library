using Library.Service.DTO;

namespace Library.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryDto>> GetAllCategory()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CategoryDto>>("Service/GetAllAsync");
            return response;
        }
    }
}
