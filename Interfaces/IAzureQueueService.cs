using ASP.NET_API.Dtos;
using Azure.Storage.Queues.Models;

namespace ASP.NET_API.Interfaces
{
    public interface IAzureQueueService
    {
        Task SendMessageAsync(string message, string queueName);
        Task<QueueMessage[]?> ReceiveMessageAsync(string queueName, int maxMessages = 1);
        Task DeleteMessageAsync(string messageId, string popReceipt, string queueName);
    }
}