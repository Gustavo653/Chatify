﻿using Google.Cloud.Storage.V1;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using Google;

namespace Chatify.Service
{
    public class GoogleCloudStorageService : IGoogleCloudStorageService
    {
        private readonly StorageClient _storageClient;
        private readonly string _bucketName;

        public GoogleCloudStorageService()
        {
            _bucketName = Environment.GetEnvironmentVariable("GCS_BUCKET_NAME")!;
            string jsonCredentialsPath = Environment.GetEnvironmentVariable("GCS_JSON_CREDENTIALS_PATH")!;

            if (string.IsNullOrEmpty(_bucketName) || string.IsNullOrEmpty(jsonCredentialsPath))
            {
                throw new ApplicationException("As variáveis de ambiente GCS_BUCKET_NAME e GCS_JSON_CREDENTIALS_PATH devem ser definidas.");
            }

            GoogleCredential credential;

            using (var stream = new FileStream(jsonCredentialsPath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream);
            }

            _storageClient = StorageClient.Create(credential);
        }

        public async Task<string> UploadFileToGcsAsync(IFormFile file, string objectName)
        {
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Seek(0, SeekOrigin.Begin);
            await _storageClient.UploadObjectAsync(_bucketName, objectName, null, stream);
            return $"https://storage.googleapis.com/{_bucketName}/{objectName}";
        }

        public async Task DeleteFileFromGcsAsync(string? objectName)
        {
            if (!string.IsNullOrEmpty(objectName))
            {
                if (objectName.StartsWith($"https://storage.googleapis.com/{_bucketName}/"))
                {
                    try
                    {
                        await _storageClient.DeleteObjectAsync(_bucketName, objectName.Substring(objectName.LastIndexOf('/') + 1));
                    }
                    catch (GoogleApiException ex)
                    {
                        if (ex.HttpStatusCode == System.Net.HttpStatusCode.NotFound)
                        { }
                        else
                            throw;
                    }
                }
            }
        }
    }
}
