using System.Web.Http;

namespace WebApi.OutputCache.V2.Tests.TestControllers
{
    public class InlineInvalidateController : ApiController
    {
        [CacheOutput(ClientTimeSpanInSeconds = 100, ServerTimeSpanInSeconds = 100)]
        public string Get_c100_s100()
        {
            return "test";
        }

        [CacheOutput(ClientTimeSpanInSeconds = 100, ServerTimeSpanInSeconds = 100)]
        public string Get_c100_s100_with_param(int id)
        {
            return "test";
        }

        [ActionName("getById")]
        [CacheOutput(ClientTimeSpanInSeconds = 100, ServerTimeSpanInSeconds = 100)]
        public string Get_c100_s100(int id)
        {
            return "test";
        }

        [CacheOutput(ClientTimeSpanInSeconds = 50)]
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
            var cache = Configuration.CacheOutputConfiguration().GetCacheOutputProvider(Request);
            cache.RemoveStartsWith(Configuration.CacheOutputConfiguration().MakeBaseCachekey("InlineInvalidate", "Get_c100_s100"));

            //do nothing
        }

        public void Put()
        {
            var cache = Configuration.CacheOutputConfiguration().GetCacheOutputProvider(Request);
            cache.RemoveStartsWith(Configuration.CacheOutputConfiguration().MakeBaseCachekey((InlineInvalidateController x) => x.Get_c100_s100()));

            //do nothing
        }

        public void Delete_non_standard_name()
        {
            var cache = Configuration.CacheOutputConfiguration().GetCacheOutputProvider(Request);
            cache.RemoveStartsWith(Configuration.CacheOutputConfiguration().MakeBaseCachekey((InlineInvalidateController x) => x.Get_c100_s100(7)));            
        }

        public void Delete_parameterized()
        {
            var cache = Configuration.CacheOutputConfiguration().GetCacheOutputProvider(Request);
            cache.RemoveStartsWith(Configuration.CacheOutputConfiguration().MakeBaseCachekey((InlineInvalidateController x) => x.Get_c100_s100_with_param(7)));

            //do nothing
        }
    }
}