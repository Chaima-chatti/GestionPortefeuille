namespace GestionPortefeuille.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Symbol { get; set; }       // "AAPL", "BTC-USD"
        public string Name { get; set; }         // "Apple Inc.", "Bitcoin"
        public string Type { get; set; }         // "Action", "Crypto"
        public decimal CurrentPrice { get; set; } // Prix actuel
    }
}