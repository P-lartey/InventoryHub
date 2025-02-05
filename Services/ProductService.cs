using System.Net.Http.Json;

public class ProductService
{
    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _http.GetFromJsonAsync<List<Product>>("product");
    }

    public async Task AddProductAsync(Product product)
    {
        await _http.PostAsJsonAsync("product", product);
    }
}
