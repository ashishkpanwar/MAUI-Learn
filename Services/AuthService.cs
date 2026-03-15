using MyApp.Models;

namespace MyApp.Services;

public class AuthService
{
    private readonly ApiService _apiService;

    public AuthService(ApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<LoginResponse> LoginAsync(string username, string password)
    {
        var loginData = new { Username = username, Password = password };
        var response = await _apiService.PostAsync<LoginResponse>("auth/login", loginData);
        if (response.Token != null)
        {
            _apiService.SetAuthToken(response.Token);
            // Store token securely
            await SecureStorage.SetAsync("auth_token", response.Token);
        }
        return response;
    }

    public void LogoutAsync()
    {
        SecureStorage.Remove("auth_token");
        _apiService.SetAuthToken(null);
    }

    public async Task<string> GetStoredTokenAsync()
    {
        return await SecureStorage.GetAsync("auth_token");
    }
}