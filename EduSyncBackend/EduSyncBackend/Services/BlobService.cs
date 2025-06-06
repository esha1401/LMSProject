//using Azure.Storage.Blobs;
//using System;
//using System.IO;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.IO;
//using System.Threading.Tasks;


//namespace EduSyncBackend.Services
//{

//    public class BlobService : IBlobService
//    {
//        private readonly string _connectionString;
//        private readonly string _containerName = "course-media";

//        public BlobService(IConfiguration configuration)
//        {
//            _connectionString = configuration.GetConnectionString("AzureBlobStorage");
//        }

//        public async Task<string> UploadFileAsync(IFormFile file)
//        {
//            var blobServiceClient = new BlobServiceClient(_connectionString);
//            var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
//            await containerClient.CreateIfNotExistsAsync();

//            var blobClient = containerClient.GetBlobClient(Guid.NewGuid() + Path.GetExtension(file.FileName));
//            using var stream = file.OpenReadStream();
//            await blobClient.UploadAsync(stream, true);

//            return blobClient.Uri.ToString();
//        }
//    }
//}