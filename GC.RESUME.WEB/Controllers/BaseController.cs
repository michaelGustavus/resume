using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Runtime;
using System.Text;
using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using GC.RESUME.WEB.Models;
using Newtonsoft.Json;

namespace GC.RESUME.WEB.Controllers
{
    public class BaseController : Controller
    {
        private HttpClient _client { get; set; } = new HttpClient();



        public T PostSingleWithoutHeaders<T>(Uri uri, object body, List<(string Name, string Value)> queryParameters)
        {
            if (queryParameters.Count > 0)
            {
                foreach (var param in queryParameters)
                {
                    uri = uri.AddParameter(param.Name, param.Value);
                }
            }

            var requestStringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            using (var response = _client.PostAsync(uri, requestStringContent).Result)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("The HTTP Response status code did not respond with a successful code.", new Exception(response.ReasonPhrase));

                var results = response.Content.ReadAsStringAsync().Result;
                var requestResult = JsonConvert.DeserializeObject<T>(results);

                return requestResult;
            }
        }

        public T GetSingle<T>(Uri uri, List<(string Name, string Value)> queryParameters = null)
        {
            _client = new HttpClient(); //We have to instantiate a new client between calls. I think something screws up with the headers or something.

            if (queryParameters?.Count > 0)
            {
                foreach (var param in queryParameters)
                {
                    uri = uri.AddParameter(param.Name, param.Value);
                }
            }

            using (var response = _client.GetAsync(uri).Result)
            {
                if (!response.IsSuccessStatusCode)
                {
                    //Return null when not found instead of error
                    if (response.ReasonPhrase == "Not Found")
                    {
                        return default;
                    }
                    else
                    {
                        throw new Exception("The HTTP Response status code did not respond with a successful code.", new Exception(response.ReasonPhrase));
                    }
                }

                var results = response.Content.ReadAsStringAsync().Result;
                var requestResult = JsonConvert.DeserializeObject<T>(results);
                return requestResult;

            }

        }


        public List<T> GetList<T>(Uri uri, List<(string Name, string Value)> queryParameters = null)
        {
            var list = GetSingle<List<T>>(uri, queryParameters);
            return list;
        }


        public ApiResult<T> Post<T>(Uri uri, Guid userId, object body)
        {
            _client = new HttpClient();

            var requestStringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            //var response = _client.PostAsync(uri, requestStringContent).Result;
            using (var response = _client.PostAsync(uri, requestStringContent).Result)
            {
                var isException = IsResponseException(response);
                if (!response.IsSuccessStatusCode && isException)
                {

                    var responseErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var exception = new Exception(response.ReasonPhrase, new Exception(responseErrorMessage));

                    throw new Exception("The HTTP Response status code did not respond with a successful code.", exception);
                }

                var result = new ApiResult<T>();
                result.Response = response;
                if (response.IsSuccessStatusCode)
                {
                    var results = response.Content.ReadAsStringAsync().Result;

                    var requestResult = JsonConvert.DeserializeObject<T>(results);

                    result.Object = requestResult;
                }
                else
                {
                    result.Message = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                return result;
            }
        }


        public ApiResult<T> GetWithBody<T>(Uri uri, object body, string newUri = null)
        {
            var _client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage();

            request.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            request.RequestUri = newUri == null ? uri : GetUri(uri, newUri);
            request.Method = HttpMethod.Get;

            var response = _client.SendAsync(request).Result;



            var isException = IsResponseException(response);
            if (!response.IsSuccessStatusCode && isException)
            {

                var responseErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var exception = new Exception(response.ReasonPhrase, new Exception(responseErrorMessage));

                throw new Exception("The HTTP Response status code did not respond with a successful code.", exception);
            }

            var result = new ApiResult<T>();
            result.Response = response;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                var requestResult = JsonConvert.DeserializeObject<T>(results);

                result.Object = requestResult;
            }
            else
            {
                result.Message = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            return result;
        }

        public T Put<T>(Uri uri, object body, string newUri = null)
        {
            _client = new HttpClient();

            var requestStringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            //var response = _client.PutAsync(uri, requestStringContent).Result;
            using (var response = newUri == null ? _client.PutAsync(uri, requestStringContent).Result : _client.PutAsync(GetUri(uri, newUri), requestStringContent).Result)
            {

                if (!response.IsSuccessStatusCode)
                    throw new Exception("The HTTP Response status code did not respond with a successful code.", new Exception(response.ReasonPhrase));

                var results = response.Content.ReadAsStringAsync().Result;
                var requestResult = JsonConvert.DeserializeObject<T>(results);

                return requestResult;
            }
        }

        public ApiResult<T> Delete<T>(Uri uri, string newUri = null)
        {
            _client = new HttpClient();

            var finalUri = GetUri(uri, newUri);
            // var response = _client.DeleteAsync(uri).Result;
            using (var response = newUri == null ? _client.DeleteAsync(uri).Result : _client.DeleteAsync(finalUri).Result)
            {

                var isException = IsResponseException(response);
                if (!response.IsSuccessStatusCode && isException)
                {
                    var responseErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var exception = new Exception(response.ReasonPhrase, new Exception(responseErrorMessage));

                    throw new Exception("The HTTP Response status code did not respond with a successful code.", exception);
                }

                var result = new ApiResult<T>();
                result.Response = response;
                if (response.IsSuccessStatusCode)
                {
                    var results = response.Content.ReadAsStringAsync().Result;
                    var requestResult = JsonConvert.DeserializeObject<T>(results);

                    result.Object = requestResult;
                }
                else
                {
                    result.Message = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                return result;
            }
        }

        private bool IsResponseException(HttpResponseMessage httpResponseMessage)
        {
            return httpResponseMessage.StatusCode == HttpStatusCode.InternalServerError ||
                    httpResponseMessage.StatusCode == HttpStatusCode.NotImplemented ||
                    httpResponseMessage.StatusCode == HttpStatusCode.BadGateway ||
                    httpResponseMessage.StatusCode == HttpStatusCode.ServiceUnavailable ||
                    httpResponseMessage.StatusCode == HttpStatusCode.GatewayTimeout ||
                    httpResponseMessage.StatusCode == HttpStatusCode.VariantAlsoNegotiates ||
                    httpResponseMessage.StatusCode == HttpStatusCode.InsufficientStorage ||
                    httpResponseMessage.StatusCode == HttpStatusCode.LoopDetected ||
                    httpResponseMessage.StatusCode == HttpStatusCode.NotExtended ||
                    httpResponseMessage.StatusCode == HttpStatusCode.NetworkAuthenticationRequired ||
                    httpResponseMessage.StatusCode == HttpStatusCode.BadRequest;
        }

        private Uri GetUri(Uri currentUri, string updatedUri)
        {
            return new Uri(string.Format(currentUri.ToString(), updatedUri));
        }


    }
    public static class extensions
    {
        public static Uri AddParameter(this Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        public static Uri UpdateUriNewUrl(this Uri currentUri, Uri actionUrl)
        {
            var currentUrl = currentUri.ToString();
            if (currentUrl.EndsWith("/"))
            {
                currentUrl = currentUrl.Substring(0, currentUrl.Length - 1);
            }
            return new Uri($"{currentUrl}/{actionUrl}");
        }

    }
}