using GestionPortefeuille.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionPortefeuille.Services
{
    public class FakePortfolioService : IPortfolioService
    {
        private List<Transaction> _transactions = new();
        private List<Asset> _assets = new();

        public FakePortfolioService()
        {
            // Données factices
            _assets = new List<Asset>
            {
                new Asset { Id = 1, Symbol = "AAPL", Name = "Apple", Type = "Action", CurrentPrice = 150 },
                new Asset { Id = 2, Symbol = "BTC", Name = "Bitcoin", Type = "Crypto", CurrentPrice = 45000 },
                new Asset { Id = 3, Symbol = "GOOGL", Name = "Google", Type = "Action", CurrentPrice = 2800 }
            };

            _transactions = new List<Transaction>
            {
                new Transaction { Id = 1, AssetId = 1, Type = "Achat", Quantity = 10, PricePerUnit = 140, Date = DateTime.Now.AddDays(-10) },
                new Transaction { Id = 2, AssetId = 2, Type = "Achat", Quantity = 0.5m, PricePerUnit = 44000, Date = DateTime.Now.AddDays(-5) },
                new Transaction { Id = 3, AssetId = 1, Type = "Vente", Quantity = 5, PricePerUnit = 155, Date = DateTime.Now.AddDays(-2) }
            };
        }

        public Task<List<Transaction>> GetTransactionsAsync()
        {
            return Task.FromResult(_transactions);
        }

        public Task<List<Asset>> GetAssetsAsync()
        {
            return Task.FromResult(_assets);
        }

        public Task AddTransactionAsync(Transaction transaction)
        {
            transaction.Id = _transactions.Count + 1;
            _transactions.Add(transaction);
            return Task.CompletedTask;
        }

        public Task<PortfolioSummary> GetSummaryAsync()
        {
            // TODO: Implémenter les calculs réels plus tard
            var summary = new PortfolioSummary
            {
                CurrentValue = 0,
                TotalGainLoss = 0,
                Performances = new List<AssetPerformance>(),
                AllocationByType = new Dictionary<string, decimal>()
            };
            return Task.FromResult(summary);
        }
    }
}