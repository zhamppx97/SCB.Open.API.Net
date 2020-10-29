using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Services
{
    public interface ISCBEasyAppPaymentService
    {
        public DeepLinkTransactionsResponseData GetDeepLinkTransactions(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody);
        public Task<DeepLinkTransactionsResponseData> GetDeepLinkTransactionsAsync(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody);
        public TransactionsResponseData GetTransactions(TransactionsRequestHeader transactionsRequestHeader, string transactionId);
        public Task<TransactionsResponseData> GetTransactionsAsync(TransactionsRequestHeader transactionsRequestHeader, string transactionId);
    }
}
