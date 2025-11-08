using System.Net.Http;

namespace RandomUserApi
{
    public class RandomUser
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://randomuser.me/api";
        public RandomUser()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetRandomUser()
        {
            var response = await httpClient.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRandomUsers(int results)
        {
            var response = await httpClient.GetAsync($"{apiUrl}?results={results}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRandomUserByGender(string gender)
        {
            var response = await httpClient.GetAsync($"{apiUrl}?gender={gender}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
