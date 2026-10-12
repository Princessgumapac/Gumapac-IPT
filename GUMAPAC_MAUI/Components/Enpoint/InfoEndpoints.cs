using GUMAPAC_MAUI.Components.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace GUMAPAC_MAUI.Components.Enpoint
{
    internal class InfoEndpoints
    {

       
        
            private readonly HttpClient _http;
            private readonly JsonSerializerOptions _options = new()
            {
                PropertyNameCaseInsensitive = true // para mabasa kahit small/capital letter
            };

            public InfoEndpoints(HttpClient http) => _http = http;

            public async Task<MyInfo.Fullname?> GetNameAsync() =>
                await _http.GetFromJsonAsync<MyInfo.Fullname>("api/name", _options);

            public async Task<MyInfo.MyAge?> GetAgeAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyAge>("api/age", _options);

            public async Task<MyInfo.MyBirthDate?> GetBirthDateAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyBirthDate>("api/birthdate", _options);

            public async Task<MyInfo.MyProgram?> GetProgramAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyProgram>("api/program", _options);

            public async Task<MyInfo.MyEmail?> GetEmailAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyEmail>("api/email", _options);

            public async Task<MyInfo.MyAddress?> GetAddressAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyAddress>("api/address", _options);

            public async Task<MyInfo.MyContact?> GetContactAsync() =>
                await _http.GetFromJsonAsync<MyInfo.MyContact>("api/contact", _options);

      

    }
}


