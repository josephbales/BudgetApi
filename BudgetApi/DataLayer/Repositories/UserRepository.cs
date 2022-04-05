using BudgetApi.DataLayer.DomainEntities;
using BudgetApi.DataLayer.Repositories.Contracts;
using Microsoft.Azure.Cosmos;

namespace BudgetApi.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Container? _container;

        public static string ContainerName => "Users";

        public UserRepository(CosmosClient dbClient, string databaseName)
        {
            _container = dbClient.GetContainer(databaseName, ContainerName);
        }

        public async Task<UserEntity?> Add(UserEntity entity)
        {
            entity.PrepEntity();
            ItemResponse<UserEntity>? response = await _container.CreateItemAsync(entity, new PartitionKey(entity.Id.ToString()));
            if ((int)response.StatusCode < 200 || (int)response.StatusCode > 299)
            {
                return null;
            }
            return response.Resource;
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity?> Get(Guid id)
        {
            try
            {
                ItemResponse<UserEntity> response = await _container.ReadItemAsync<UserEntity>(id.ToString(), new PartitionKey(id.ToString()));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<UserEntity?> GetByEmail(string email)
        {
            QueryDefinition query = new QueryDefinition(
                "select * from Users u where u.email = @email ")
                .WithParameter("@email", email);

            try
            {
                FeedIterator<UserEntity>? resultSet = _container.GetItemQueryIterator<UserEntity>(
                    query, requestOptions: new QueryRequestOptions()
                    {
                        MaxItemCount = 1
                    });
                FeedResponse<UserEntity> response = await resultSet.ReadNextAsync();
                // TODO: catch weird status codes. check for null
                return response.FirstOrDefault();
            } // TODO: how does this work?
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public Task<UserEntity?> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
