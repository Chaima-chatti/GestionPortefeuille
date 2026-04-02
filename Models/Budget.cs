namespace GestionPortefeuille.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal RemainingBudget { get; set; }
    }
}