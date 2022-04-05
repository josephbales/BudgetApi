using BudgetApi.ApiModels;
using BudgetApi.DataLayer.DomainEntities;
using BudgetApi.DataLayer.Repositories.Contracts;
using BudgetApi.RequestHandlers.Contracts;

namespace BudgetApi.RequestHandlers
{
    public class UserRequestHandler : IUserRequestHandler
    {
        private readonly IUserRepository _userRepository;

        public UserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> Create(User model)
        {
            // TODO: how do we do validation on minimal APIs
            UserEntity userEntity = User.ApiModelToEntity(model);
            UserEntity? response = await _userRepository.Add(userEntity);
            // TODO: handle null response
            return User.EntityToApiModel(response);
        }

        public Task<User?> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> Update(User model)
        {
            throw new NotImplementedException();
        }

        public Task<Guid?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmail(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
