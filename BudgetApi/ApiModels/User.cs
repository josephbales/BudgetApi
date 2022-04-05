using BudgetApi.ApiModels.Base;
using BudgetApi.DataLayer.DomainEntities;

namespace BudgetApi.ApiModels
{
    public class User : BaseApiModel
    {
        public Guid? Id { get; set; }
        public string Email { get; set; } = null!;
        public string? DisplayName { get; set; }
        public DateTime JoinDate { get; set; }

        public static UserEntity ApiModelToEntity(User model, UserEntity entity = null!)
        {
            entity ??= new();

            if (model.Id.HasValue) entity.Id = model.Id.Value;
            entity.Email = model.Email;
            entity.DisplayName = model.DisplayName;
            entity.JoinDate = model.JoinDate;

            return entity;
        }

        public static User EntityToApiModel(UserEntity entity, User model = null!)
        {
            model ??= new();

            model.Id = entity.Id;
            model.Email = entity.Email;
            model.DisplayName = entity.DisplayName;
            model.JoinDate = entity.JoinDate;

            return model;
        }
    }
}
