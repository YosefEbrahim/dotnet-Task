using dotnet_task;
using Microsoft.Azure.Cosmos;

namespace dotnet_intern.Services
{
    public class Program : IProgram
    {
        private Container _container;
        public Program(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }
        public async Task AddAsync(ProgramDetails item)
        {
            await _container.CreateItemAsync(item, new PartitionKey(item.Id));
        }

        public async Task<ProgramDetails> GetAsync(int id)
        {
            try
            {
                var response = await _container.ReadItemAsync<ProgramDetails>(id.ToString(), new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException) //For handling item not found and other exceptions
            {
                return null;
            }
        }

        public async Task UpdateAsync(int id, ProgramDetails item)
        {
            await _container.UpsertItemAsync(item, new PartitionKey(id));
        }
    }
}
