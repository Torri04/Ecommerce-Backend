using System.Text;
using ASP.NET_API.Interfaces;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

namespace ASP.NET_API.Services;

public class AzureQueueService : IAzureQueueService
{
    private readonly string connectionString;
    public AzureQueueService(IConfiguration configuration)
    {
        connectionString = configuration["AzureStorage:ConnectionStrings"];
    }

    public async Task SendMessageAsync(string message, string queueName)
    {
        var _queueClient = new QueueClient(connectionString, queueName);
        await _queueClient.CreateIfNotExistsAsync();

        await _queueClient.SendMessageAsync(Convert.ToBase64String(Encoding.UTF8.GetBytes(message)));
    }
    public async Task<QueueMessage[]?> ReceiveMessageAsync(string queueName, int maxMessages = 1)
    {
        var _queueClient = new QueueClient(connectionString, queueName);
        await _queueClient.CreateIfNotExistsAsync();

        QueueMessage[] retrievedMessages = await _queueClient.ReceiveMessagesAsync(maxMessages);
        return retrievedMessages.Length > 0 ? retrievedMessages : null;
    }

    public async Task DeleteMessageAsync(string messageId, string popReceipt, string queueName)
    {
        var _queueClient = new QueueClient(connectionString, queueName);
        await _queueClient.CreateIfNotExistsAsync();

        await _queueClient.DeleteMessageAsync(messageId, popReceipt);
    }
}