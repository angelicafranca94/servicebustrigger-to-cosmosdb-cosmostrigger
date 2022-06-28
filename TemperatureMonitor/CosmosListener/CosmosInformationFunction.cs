using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CosmosListener
{
    public static class CosmosInformationFunction
    {
        [FunctionName("CosmosInformationFunction")]
        public static void Run([CosmosDBTrigger(
            databaseName: "IotInfo",
            collectionName: "TemperatureInfo",
            ConnectionStringSetting = "AzureWebJobsStorage",
            LeaseCollectionName = "leases")]IReadOnlyList<Document> input,
            ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                log.LogInformation("First document Id " + input[0].Id);

                //string path = "C:\\IotInformation.txt";
                //File.WriteAllTextAsync(path, input[0].ToString());

            }
        }
    }
}
