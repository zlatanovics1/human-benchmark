using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Configuration;

namespace WinFormsAppGameVerse
{
    internal class UserClient
    {
        readonly HttpClient _httpClient;

        string apiUrl = ConfigurationManager.AppSettings["apiUrl"]!;
        public UserClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<User[]?> GetUsers()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiUrl}/users");
                response.EnsureSuccessStatusCode();

                string resData = await response.Content.ReadAsStringAsync();

                ApiResponse<User[]> resObject = JsonConvert.DeserializeObject<ApiResponse<User[]>>(resData)!;

                return resObject.data;
            }
            catch(HttpRequestException exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }

       public async Task<User?> GetUser(string id)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiUrl}/tours/{id}");
                response.EnsureSuccessStatusCode();

                string resData = await response.Content.ReadAsStringAsync();
                MessageBox.Show(resData);

                ApiResponse<User> resObject = JsonConvert.DeserializeObject<ApiResponse<User>>(resData)!;

                return resObject.data;
            }
            catch (HttpRequestException exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }
    }
}
