using TaskListApp.Entities;
using TaskListApp.Models;

namespace TaskListApp.Services
{
    public interface ITaskListService
    {
        public TaskList Create(TaskListDto taskListDto);
        public TaskList Update(long taskListId, TaskListDto taskListDto);
        public List<TaskList> FindAll();
        public TaskList FindById(long id);
    }
}
