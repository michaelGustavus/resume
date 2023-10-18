using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace GC.RESUME.WEB.Models
{

    public abstract class Base
    {
        [JsonProperty("HttpResponse_Message", ItemConverterType = typeof(HttpResponseMessage))]
        public HttpResponseMessage HttpResponse_Message { get; set; }
        public string ResultMessage { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public Base()
        {
            StatusCode = HttpStatusCode.InternalServerError;
            ResultMessage = string.Empty;
            HttpResponse_Message = null;
        }
    }
}

