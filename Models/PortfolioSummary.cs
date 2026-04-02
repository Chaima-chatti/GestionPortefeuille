using System.Collections.Generic;

namespace GestionPortefeuille.Models
{
    public class PortfolioSummary
    {
        public decimal CurrentValue { get; set; }
        public decimal TotalGainLoss { get; set; }
        public List<AssetPerformance> Performances { get; set; } = new();  // ← Initialisez
        public Dictionary<string, decimal> AllocationByType { get; set; } = new();  // ← Initialisez
    }

    public class AssetPerformance
    {
        public string AssetName { get; set; } = string.Empty;  // ← Ajoutez = string.Empty
        public decimal Invested { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal GainLoss { get; set; }
        public decimal GainLossPercent { get; set; }
    }
}