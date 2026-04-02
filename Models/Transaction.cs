using System;

namespace GestionPortefeuille.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public Asset? Asset { get; set; }  // ← Ajoutez ? pour nullable
        public string Type { get; set; } = string.Empty;  // ← Ajoutez = string.Empty
        public decimal Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount => Quantity * PricePerUnit;
    }
}