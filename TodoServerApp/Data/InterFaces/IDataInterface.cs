namespace TodoServerApp.Data.InterFaces
{
    public interface IDataInterface
    {
        Task<IEnumerable<Taskitem>> GetTaskItemsAsync();

    }
}
