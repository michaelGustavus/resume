using System.Net.Http;
using System.Runtime.Serialization;

namespace GC.RESUME.WEB.Models
{
    [DataContract]
    public class ApiResult<T> : Base
    {
        public T Object { get; set; }

        public HttpResponseMessage Response { get; set; }

        public string Message { get; set; }
    }
}
