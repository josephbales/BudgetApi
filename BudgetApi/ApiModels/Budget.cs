using BudgetApi.ApiModels.Base;

namespace BudgetApi.ApiModels
{
    public class Budget : BaseApiModel
    {
        public Guid? Id { get; set; }
        public IEnumerable<Guid> UserIds { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IEnumerable<BudgetItem>? BudgetItems { get; set; }
    }
}
