using Library.Service.DTO;

namespace Library.Web.Services
{
    public class BooksApiService
    {
        private readonly HttpClient _httpClient;
        public BooksApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<BooksDto>> GetAllBooks()
        {
            var response = await _httpClient.GetFromJsonAsync<List<BooksDto>>("Service/GetAllAsync");
            return response;
        }

        public async Task<int> SaveAsync(BooksSaveDto newBook)
        {
            var response = await _httpClient.PostAsJsonAsync("books", newBook);
            //if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<int>();
            return responseBody;
        }
    }
}
