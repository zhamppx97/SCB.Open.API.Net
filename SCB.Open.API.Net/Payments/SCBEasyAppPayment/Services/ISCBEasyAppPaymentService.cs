using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Services
{
    public interface ISCBEasyAppPaymentService
    {
        DeepLinkTransactionsResponseData GetDeepLinkTransactions(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody);
        Task<DeepLinkTransactionsResponseData> GetDeepLinkTransactionsAsync(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody);
        TransactionsResponseData GetTransactions(TransactionsRequestHeader transactionsRequestHeader, string transactionId);
        Task<TransactionsResponseData> GetTransactionsAsync(TransactionsRequestHeader transactionsRequestHeader, string transactionId);
    }
}
