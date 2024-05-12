using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WinFormsAppGameVerse
{
    internal class UserClient
    {
        readonly HttpClient _httpClient;

        public UserClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<User[]?> GetUsers()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("http://127.0.0.1:8000/api/v1/users");
                response.EnsureSuccessStatusCode();
                string resData = await response.Content.ReadAsStringAsync();

                ApiResponse<User> user = JsonConvert.DeserializeObject<ApiResponse<User>>(resData)!;

                return user.data;
            }
            catch(HttpRequestException exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }
    }
}
