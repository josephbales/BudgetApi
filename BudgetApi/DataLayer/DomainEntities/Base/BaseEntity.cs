namespace BudgetApi.DataLayer.DomainEntities.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }

        public void PrepEntity()
        {
            if (Id == default) Id = Guid.NewGuid();
            if (CreatedOn == default) CreatedOn = DateTime.UtcNow;
            if (ModifiedOn == default) ModifiedOn = DateTime.UtcNow;
        }
    }
}
