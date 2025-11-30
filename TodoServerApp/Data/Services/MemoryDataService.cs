using TodoServerApp.Data.InterFaces;

namespace TodoServerApp.Data
{
    public class MemoryDataService : IDataService
    {
        public static IEnumerable<Taskitem> Tasks { get; } = [
             new() {Id = 1, Title="Задача 1", Description="Описание задачи 1", CreateDate=DateTime.Now},
             new() {Id = 2, Title="Задача 2", Description="Описание задачи 2", CreateDate=DateTime.Now},
             new() {Id = 3, Title="Задача 3", Description="Описание задачи 3", CreateDate=DateTime.Now},
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Taskitem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Taskitem>> GetTaskitemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }

        public Task SaveAsync(Taskitem item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Taskitem>> GetAllAsync()
        {
            return Task.FromResult(Tasks);
        }
    }
}
