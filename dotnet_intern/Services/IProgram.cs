using dotnet_task;

namespace dotnet_intern.Services
{
    public interface IProgram
    {
        Task<ProgramDetails> GetAsync(int id);
        Task AddAsync(ProgramDetails item);
        Task UpdateAsync(int id, ProgramDetails item);

    }
}
