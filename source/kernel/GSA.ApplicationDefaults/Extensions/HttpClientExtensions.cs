using System.Text;
using System.Text.Json;

namespace GSA.ApplicationDefaults.Extensions;

public static class HttpClientExtensions
{
    private static readonly JsonSerializerOptions defaultJsonDeserializerOptions = new() { PropertyNameCaseInsensitive = true };

    public static async Task<HttpResponseMessage> Get(this HttpClient httpClient, string relativeUri, Dictionary<string, string>? customHeaders = null)
    {
        try
        {
            HttpRequestMessage request = new(HttpMethod.Get, relativeUri);

            AddHeaders(request, customHeaders);

            return await httpClient.SendAsync(request);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static async Task<HttpResponseMessage> SendAsJson<TRequestBody>(this HttpClient httpClient, string relativeUri, HttpMethod httpMethod, TRequestBody requestBody, Dictionary<string, string>? customHeaders = null)
    {
        try
        {
            string jsonRequest = JsonSerializer.Serialize(requestBody);
            StringContent requestContent = new(jsonRequest, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(httpMethod, relativeUri) { Content = requestContent };

            AddHeaders(request, customHeaders);

            return await httpClient.SendAsync(request);
        }
        catch (Exception)
        {
            throw;
        }
    }


    public static async Task<TResponse?> ReadContentAsJson<TResponse>(this HttpResponseMessage httpResponseMessage)
    {
        try
        {
            return await JsonSerializer.DeserializeAsync<TResponse>(await httpResponseMessage.Content.ReadAsStreamAsync(), defaultJsonDeserializerOptions);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static void AddHeaders(HttpRequestMessage request, Dictionary<string, string>? customHeaders)
    {
        if (customHeaders is not null)
        {
            foreach (KeyValuePair<string, string> header in customHeaders)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }
    }
}
