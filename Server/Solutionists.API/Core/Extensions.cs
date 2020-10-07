using Microsoft.AspNetCore.Http;

namespace Solutionists.API.Core
{
    public static class Extensions
    {
        

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            // CORS
            response.Headers.Add("access-control-expose-headers", "Application-Error");
        }
    }
}
