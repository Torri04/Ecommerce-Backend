using ASP.NET_API.Dtos;

namespace ASP.NET_API.Interfaces
{
    public interface IAzureBlobService
    {
        Task<string> UploadFileAsync(IFormFile file, string containerName);
        Task<string> UpdateFileAsync(IFormFile file, string blobName, string containerName);
        Task DeleteBlobAsync(string blobName, string containerName);
    }
}