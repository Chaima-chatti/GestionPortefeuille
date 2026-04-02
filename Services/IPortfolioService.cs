using GestionPortefeuille.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionPortefeuille.Services
{
    public interface IPortfolioService
    {
        Task<List<Transaction>> GetTransactionsAsync();
        Task<List<Asset>> GetAssetsAsync();
        Task AddTransactionAsync(Transaction transaction);
        Task<PortfolioSummary> GetSummaryAsync();
    }
}