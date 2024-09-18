using APIWEBASSEMBLy.Data.DTOs;
using Microsoft.VisualBasic;
using System.Net.Http.Json;

namespace APIWEBASSEMBLy.Data.Services
{
    public class PostProductService
    {
        private readonly HttpClient _httpClient;

        public PostProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("NODE_API");
        }

        public async Task<List<PostProductDTO>> GetPostAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<PostProductDTO>>("productosAMMA");
            return response ?? new List<PostProductDTO>();
        }

        public async Task<PostProductDTO> CreatePostAsync(PostProductDTO post)
        {
            var response = await _httpClient.PostAsJsonAsync("productosAMMA", post);
            response.EnsureSuccessStatusCode();

            var productResult = await response.Content.ReadFromJsonAsync<PostProductDTO>();

            if (productResult != null)
                return productResult;
            else
                return new PostProductDTO();
        }
    }
}