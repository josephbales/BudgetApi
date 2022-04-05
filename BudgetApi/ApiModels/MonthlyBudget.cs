using BudgetApi.ApiModels.Base;

namespace BudgetApi.ApiModels
{
    public class MonthlyBudget : BaseApiModel
    {
        public Guid? Id { get; set; }
        public Guid? BudgetId { get; set; }
        public IEnumerable<Guid> UserIds { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime BudgetMonth { get; set; }
        public decimal BufferAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public IEnumerable<MonthlyBudgetItem>? MonthlyBudgetItems { get; set; }
    }
}
