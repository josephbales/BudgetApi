using BudgetApi.DataLayer.Repositories;
using BudgetApi.DataLayer.Repositories.Contracts;
using Microsoft.Azure.Cosmos;

namespace BudgetApi
{
    public static class ServiceExtensions
    {
        private static readonly Type[] _repositoryTypes = 
        {
            typeof(UserRepository),
        };

        /// <summary>
        /// Creates a Cosmos DB database and containers with the specified partition keys. 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configurationSection"></param>
        public static void AddDbRepositories(this IServiceCollection services, IConfigurationSection configurationSection)
        {
            string databaseName = configurationSection.GetSection("DatabaseName").Value;
            string account = configurationSection.GetSection("Account").Value;
            string key = configurationSection.GetSection("Key").Value;
            CosmosClient client = null!;
            //CosmosClient client = new(account, key, new CosmosClientOptions
            //{
            //    SerializerOptions = new CosmosSerializationOptions
            //    {
            //        PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
            //    }
            //});

            //// Create Database
            //DatabaseResponse database = client.CreateDatabaseIfNotExistsAsync(databaseName).GetAwaiter().GetResult();

            //// Create Containers
            //database.Database.CreateContainerIfNotExistsAsync(UserRepository.ContainerName, "/id").GetAwaiter().GetResult();

            // Add repositories
            services.AddSingleton<IUserRepository, UserRepository>(provider => new(client, databaseName));
        }
    }
}
