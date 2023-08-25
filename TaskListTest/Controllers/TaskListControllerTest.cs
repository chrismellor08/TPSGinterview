using Microsoft.EntityFrameworkCore;
using TaskListApp.Controllers;
using TaskListApp.Entities;
using TaskListApp.Models;
using TaskListApp.Persistence;
using TaskListApp.Services;

namespace TaskListTest.Controllers
{
    [TestClass]
    public class TaskListControllerTest
    {
        private readonly TaskListController _taskListController;

        public TaskListControllerTest()
        {
            var dbContextOptions = new DbContextOptionsBuilder<TaskListDbContext>()
                .UseInMemoryDatabase("TaskListDb")
                .Options;
            var taskListDbContext = new TaskListDbContext(dbContextOptions);
            var taskListService = new TaskListService(taskListDbContext);
            _taskListController = new TaskListController(taskListService);
        }

        [TestMethod]
        public void TestCreateTaskList()
        {
            var taskListName = "Some Task List";

            var taskListDto = new TaskListDto
            {
                Name = taskListName
            };

            var taskList = _taskListController.Create(taskListDto);
            Assert.AreEqual(taskList, new TaskList
            {
                Name = taskListName,
            });
        }
    }
}