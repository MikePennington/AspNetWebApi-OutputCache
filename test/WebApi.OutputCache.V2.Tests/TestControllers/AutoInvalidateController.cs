using System.Web.Http;

namespace WebApi.OutputCache.V2.Tests.TestControllers
{
    [AutoInvalidateCacheOutput]
    public class AutoInvalidateController : ApiController
    {
        [CacheOutput(ClientTimeSpanInSeconds = 100, ServerTimeSpanInSeconds = 100)]
        public string Get_c100_s100()
        {
            return "test";
        }

        [CacheOutput(ServerTimeSpanInSeconds = 50)]
        public string Get_s50_exclude_fakecallback(int id = 0, string callback = null, string de = null)
        {
            return "test";
        }

        [HttpGet]
        [CacheOutput(AnonymousOnly = true, ClientTimeSpanInSeconds = 50, ServerTimeSpanInSeconds = 50)]
        public string etag_match_304()
        {
            return "value";
        }

        public void Post()
        {
            //do nothing
        }

        public void Put()
        {
            //do nothing
        }

        public void Delete()
        {
            //do nothing
        }
    }
}