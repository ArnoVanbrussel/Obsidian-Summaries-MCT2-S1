[FunctionName("SensorQueue")]
public static async Task SensorQueue([QueueTrigger("sensorLogs", Connection = "StorageConnectionString")] string myQueueItem, ILogger log)
{
    SensorLog temperatureLog = JsonConvert.DeserializeObject<SensorLog>(myQueueItem);
    if (temperatureLog.Temperature > )
    {
        Microsoft.Azure.Cosmos.Table.CloudStorageAccount storageAccount = Microsoft.Azure.Cosmos.Table.CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("StorageConnectionString"));
        Microsoft.Azure.Cosmos.Table.CloudTableClient tableClient = storageAccount.CreateCloudTableClient(new Microsoft.Azure.Cosmos.Table.TableClientConfiguration());
        Microsoft.Azure.Cosmos.Table.CloudTable table = tableClient.GetTableReference("logs");
        SensorLogEntity entity = new SensorLogEntity()
        {
            PartitionKey = temperatureLog.Location,
            RowKey = Guid.NewGuid().ToString(),
            Temperature = temperatureLog.Temperature.ToString(),
        };
        Microsoft.Azure.Cosmos.Table.TableOperation insertOrMergeOperation = Microsoft.Azure.Cosmos.Table.TableOperation.InsertOrMerge(entity);
        Microsoft.Azure.Cosmos.Table.TableResult result = await table.ExecuteAsync(insertOrMergeOperation);
    }
    log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
}
