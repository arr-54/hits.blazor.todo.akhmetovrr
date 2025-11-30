
namespace TodoServerApp.Data
{
    public interface IDataService1
    {
        Task DeleteAsync(int id);
        Task<Taskitem> GetTaskAsync(int id);
        Task<IEnumerable<Taskitem>> GetTaskitemsAsync();
        Task SaveAsync(Taskitem item);
    }
}