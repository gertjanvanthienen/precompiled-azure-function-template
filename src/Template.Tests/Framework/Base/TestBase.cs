using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Template.Tests.Framework.Helpers;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace Template.Tests.Framework.Base
{
    public class TestBase
    {
        protected TraceWriter GetTestTraceWriter()
        {
            return new TestTraceWriter(System.Diagnostics.TraceLevel.Info);
        }

        protected HttpRequestMessage CreateHttpRequestWith(object jsonObject)
        {
            string jsonContent = JsonConvert.SerializeObject(jsonObject);

            var request = new HttpRequestMessage()
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };

            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            return request;
        }
    }
}