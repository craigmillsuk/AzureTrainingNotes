using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ServerlessFuncs
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string num1 = req.Query["num1"];
            string num2 = req.Query["num2"];

            string responseMessage = string.IsNullOrEmpty(num1) || string.IsNullOrEmpty( num2 )
                ? "Please pass a num1 and num2 parameter."
                : $"Addition: {Convert.ToInt32(num1) + Convert.ToInt32(num2)}";

            return new OkObjectResult(responseMessage);
        }
    }
}
