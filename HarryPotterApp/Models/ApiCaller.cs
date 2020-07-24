using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterApp.Models
{
    public class ApiCaller
    {
        public static string AuthID = "$2a$10$iMmBUmGOdGiE73IA1A04V.5XUZZuYbw5J9ucgFYFX3ozzKo.XoD7u";
        public static async Task<ApiResponse> Get(string url)
        {
            using (var client = new HttpClient())
            {
                //if (!string.IsNullOrWhiteSpace(AuthID))
                //    url += $"&appid={AuthID}";
                
                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                    return new ApiResponse
                    {
                        Response = await request.Content.ReadAsStringAsync()
                    };
                else
                    return new ApiResponse
                    {
                        ErrorMessage = request.ReasonPhrase
                    };
            }
        }
        public static async Task<ApiResponse> GetCharacter()
        {
            string url = "https://www.potterapi.com/v1/characters/?key=" + AuthID;
            using (var client = new HttpClient())
            {
                //if (!string.IsNullOrWhiteSpace(AuthID))
                //    url += $"&appid={AuthID}";

                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                    return new ApiResponse
                    {
                        Response = await request.Content.ReadAsStringAsync()
                    };
                else
                    return new ApiResponse
                    {
                        ErrorMessage = request.ReasonPhrase
                    };
            }
        }

        public static async Task<ApiResponse> GetSpell()
        {
            string url = "https://www.potterapi.com/v1/spells/?key=" + AuthID;
            using (var client = new HttpClient())
            {
                //if (!string.IsNullOrWhiteSpace(AuthID))
                //    url += $"&appid={AuthID}";

                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                    return new ApiResponse
                    {
                        Response = await request.Content.ReadAsStringAsync()
                    };
                else
                    return new ApiResponse
                    {
                        ErrorMessage = request.ReasonPhrase
                    };
            }
        }
    }
}
