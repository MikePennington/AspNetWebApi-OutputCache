using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebApi.OutputCache.V2.Tests.TestControllers
{
    public class CacheKeyController : ApiController
    {
        private class UnregisteredCacheKeyGenerator : ICacheKeyGenerator
        {
            public string MakeCacheKey(HttpActionContext context, MediaTypeHeaderValue mediaType, bool excludeQueryString = false)
            {
                return "unregistered";
            }
        }

        [CacheOutput(CacheKeyGenerator = typeof(CacheKeyGeneratorTests.CustomCacheKeyGenerator), ClientTimeSpanInSeconds = 100, ServerTimeSpanInSeconds = 100)]
        public string Get_custom_key()
        {
            return "test";
        }

        [CacheOutput(CacheKeyGenerator = typeof(UnregisteredCacheKeyGenerator))]
        public string Get_unregistered()
        {
            return "test";
        }

        [CacheOutput(CacheKeyGenerator = typeof(CacheKeyGeneratorRegistrationTests.InternalRegisteredCacheKeyGenerator), ServerTimeSpanInSeconds = 100)]
        public string Get_internalregistered()
        {
            return "test";
        }
    }
}
