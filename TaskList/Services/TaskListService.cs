using TaskListApp.Entities;
using TaskListApp.Models;
using TaskListApp.Persistence;

namespace TaskListApp.Services
{
    public class TaskListService : ITaskListService
    {
        private readonly TaskListDbContext _dbContext;

        public TaskListService(TaskListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TaskList Create(TaskListDto taskListDto)
        {
            var taskList = new TaskList
            {
                CreatedDate = DateTime.UtcNow,
                Name = taskListDto.Name,
            };

            _dbContext.TaskLists.Add(taskList);
            _dbContext.SaveChanges();

            return taskList;
        }

        public TaskList Update(long taskListId, TaskListDto taskListDto)
        {
            var taskList = _dbContext.TaskLists.Find(taskListId);
            if (taskList == null)
            {
                throw new EntityNotFoundException($"Cannot find TaskList with an ID of {taskListId}");
            }
            taskList.Name = taskListDto.Name;
            _dbContext.SaveChanges();
            return taskList;
        }

        public List<TaskList> FindAll()
        {
            return _dbContext.TaskLists.ToList();
        }

        public TaskList FindById(long id)
        {
            var taskList = _dbContext.TaskLists.Find(id);
            if (taskList == null)
            {
                throw new EntityNotFoundException($"Cannot find TaskList with an ID of {id}");
            }

            return taskList;
        }
    }
}
