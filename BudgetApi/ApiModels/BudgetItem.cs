using BudgetApi.ApiModels.Base;
using BudgetApi.Infrastructure;

namespace BudgetApi.ApiModels
{
    public class BudgetItem : BaseApiModel
    {
        public Guid? Id { get; set; }
        public Guid BudgetId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public short? DueDay { get; set; }
        public string? Notes { get; set; }
        public BudgetItemType Type { get; set; }
    }
}
