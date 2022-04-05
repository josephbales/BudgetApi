using BudgetApi.ApiModels.Base;
using BudgetApi.Infrastructure;

namespace BudgetApi.ApiModels
{
    public class MonthlyBudgetItem : BaseApiModel
    {
        public Guid? Id { get; set; }
        public Guid MonthlyBudgetId { get; set; }
        public Guid? BudgetItemId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public short? DueDay { get; set; }
        public bool IsPaid { get; set; }
        public string? Notes { get; set; }
        public BudgetItemType Type { get; set; }
    }
}
