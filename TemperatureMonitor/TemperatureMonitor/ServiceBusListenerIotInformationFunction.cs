
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace TemperatureControlFunction;

public class ServiceBusListenerIotInformationFunction
{
    [FunctionName(nameof(ServiceBusListenerIotInformationFunction))]
    public static void Run(
        [ServiceBusTrigger(
        "%MessageQueueName%", 
        Connection = "ServiceBusConnectionString")] string message,
        [CosmosDB(
        databaseName: "IotInfo",
        collectionName: "TemperatureInfo",
        ConnectionStringSetting = "myCosmosDB")] out dynamic document, 
        ILogger log)
    {
        log.LogInformation($"IotInformationFunction trigger function started.");
        
        document = new {Description = message, id = Guid.NewGuid()};

        log.LogInformation($"IotInformationFunction trigger function finished.");

    }
}
