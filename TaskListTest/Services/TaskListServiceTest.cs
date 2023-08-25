using Microsoft.EntityFrameworkCore;
using TaskListApp.Controllers;
using TaskListApp.Entities;
using TaskListApp.Persistence;
using TaskListApp.Services;

namespace TaskListTest.Services;

[TestClass]
public class TaskListServiceTest
{
    private readonly TaskListService _taskListService;
    private readonly TaskListDbContext _taskListDbContext;

    public TaskListServiceTest()
    {
        var dbContextOptions = new DbContextOptionsBuilder<TaskListDbContext>()
            .UseInMemoryDatabase("TaskListDb")
            .Options;
        _taskListDbContext = new TaskListDbContext(dbContextOptions);
        _taskListService = new TaskListService(_taskListDbContext);
    }

    [TestMethod]
    public void TestFindById()
    {
        var taskName = "Arbitrary task list";
        
        _taskListDbContext.TaskLists.Attach(new TaskList
        {
            Id = 10,
            Name = taskName,
        });

        var foundTask = _taskListService.FindById(10);
        
        Assert.AreEqual(foundTask?.Name, taskName);
    }
}