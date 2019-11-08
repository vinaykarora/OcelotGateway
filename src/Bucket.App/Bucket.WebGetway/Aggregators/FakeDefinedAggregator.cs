using Ocelot.Middleware;
using Ocelot.Middleware.Multiplexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.WebGetway.Aggregators
{
    public class FakeDefinedAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<DownstreamContext> responses)
        {
            var contentBuilder = new StringBuilder();
            contentBuilder.Append("{");
            foreach (var response in responses)
            {
                var responseContent = await response.DownstreamResponse.Content.ReadAsStringAsync();

                contentBuilder.AppendFormat("\"{0}\":{1}", response.DownstreamReRoute.Key, responseContent);
                contentBuilder.Append(",");
            }

            var responseClub = contentBuilder.ToString();
            if (responseClub.EndsWith(","))
            {
                responseClub = responseClub.Remove(responseClub.Length - 1);
            }
            contentBuilder = new StringBuilder(responseClub);
            contentBuilder.Append("}");
            var stringContent = new StringContent(contentBuilder.ToString())
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
            };

            return new DownstreamResponse(stringContent, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), HttpStatusCode.OK.ToString());
        }
    }
}
