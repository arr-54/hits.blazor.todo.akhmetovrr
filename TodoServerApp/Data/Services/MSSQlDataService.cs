using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data.Services
{
    public class MSSQlDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<Taskitem>> GetAllAsync()
        {
            return await context.Taskitems.ToArrayAsync();
        }

        public async Task SaveAsync(Taskitem Taskitem)
        {
            await File.WriteAllTextAsync("C:\\logs\\log.log", "Pressed!");
            if (Taskitem.Id == 0)
            {
                Taskitem.CreateDate = DateTime.Now;
                await context.Taskitems.AddAsync(Taskitem);
            }
            else
            {
                context.Taskitems.Update(Taskitem);
            }
            await context.SaveChangesAsync();
        }

        public async Task<Taskitem?> GetTaskAsync(int id)
        {
            return await context.Taskitems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var taskitem = await context.Taskitems.FirstOrDefaultAsync(x => x.Id == id);
            if (taskitem == null)
                return;

            context.Taskitems.Remove(taskitem);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Taskitem>> GetTaskitemsAsync()
        {
            return await context.Taskitems.ToListAsync();
        }
    }
}
