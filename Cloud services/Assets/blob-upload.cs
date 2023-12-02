// Define a function named "FileUpload"
[FunctionName("FileUpload")]
public static async Task<IActionResult> FileUpload(

    // This function is triggered by an HTTP POST request. The filename is provided as a parameter in the URL.
    [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "upload/{filename}")] HttpRequest req, string filename, ILogger log)
{
    try
    {
        // Log the start of the upload process
        log.LogInformation("Upload start");
        
        // Connect to the storage account using the connection string stored in localsettings.json
        CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("BlobStorage"));
        // Create a blob client for interacting with the blob service
        CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
        // Get a reference to a container named "uploads"
        CloudBlobContainer container = blobClient.GetContainerReference("uploads");
        // Get a reference to a block blob (a type of blob suitable for large file uploads) with the provided filename
        CloudBlockBlob blockBlob = container.GetBlockBlobReference(filename);
        // Upload the file from the request body to the blob
        await blockBlob.UploadFromStreamAsync(req.Body);
        // Log the completion of the upload process
        log.LogInformation("Upload done");
        // Return a 200 OK response
        return new OkObjectResult("");
    }
    catch (Exception ex)
    {
        // If there's an error, log it and return a 500 Internal Server Error response
        log.LogError(ex.Message);
        return new StatusCodeResult(500);
    }
}

