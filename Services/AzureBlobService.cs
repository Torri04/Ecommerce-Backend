using ASP.NET_API.Dtos;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_API.Services;

public class AzureBlobService : IAzureBlobService
{
    private readonly string connectionString;
    public AzureBlobService(IConfiguration configuration)
    {
        connectionString = configuration["AzureStorage:ConnectionStrings"];
    }

    public async Task<string> UpdateFileAsync(IFormFile file, string urlImage, string containerName)
    {
        var _blobContainerClient = new BlobServiceClient(connectionString).GetBlobContainerClient(containerName);

        if (file == null || file.Length == 0)
            throw new ArgumentException("Invalid file");

        var uri = new Uri(urlImage);
        string blobName = Path.GetFileName(uri.AbsolutePath);

        using var stream = file.OpenReadStream();

        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        await blobClient.UploadAsync(stream, new BlobUploadOptions
        {
            HttpHeaders = new BlobHttpHeaders
            {
                ContentType = file.ContentType
            },
        });

        return blobClient.Uri.ToString();
    }

    public async Task<string> UploadFileAsync(IFormFile file, string containerName)
    {
        var _blobContainerClient = new BlobServiceClient(connectionString).GetBlobContainerClient(containerName);

        if (file == null || file.Length == 0)
            throw new ArgumentException("Invalid file");

        var blobName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        using var stream = file.OpenReadStream();

        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        await blobClient.UploadAsync(stream, new BlobUploadOptions
        {
            HttpHeaders = new BlobHttpHeaders
            {
                ContentType = file.ContentType
            },
        });

        return blobClient.Uri.ToString();
    }
    public async Task DeleteBlobAsync(string urlImage, string containerName)
    {
        var _blobContainerClient = new BlobServiceClient(connectionString).GetBlobContainerClient(containerName);

        var uri = new Uri(urlImage);
        string blobName = Path.GetFileName(uri.AbsolutePath);

        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        await blobClient.DeleteIfExistsAsync();
    }
}
