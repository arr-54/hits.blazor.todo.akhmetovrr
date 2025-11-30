using Microsoft.AspNetCore.Cors.Infrastructure;

namespace TodoServerApp.Data
{
    public interface IDataService
    {
        Task<IEnumerable<Taskitem>> GetTaskitemsAsync();
        Task SaveAsync(Taskitem item);
        Task<Taskitem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
        Task<IEnumerable<Taskitem>> GetAllAsync();
    }
}