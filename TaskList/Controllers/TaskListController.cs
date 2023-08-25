using Microsoft.AspNetCore.Mvc;
using TaskListApp.Entities;
using TaskListApp.Models;
using TaskListApp.Services;

namespace TaskListApp.Controllers
{
    [Route("api/tasklist")]
    [ApiController]
    public class TaskListController : ControllerBase
    {
        private readonly ITaskListService _taskListService;

        public TaskListController(ITaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        [HttpGet]
        public List<TaskList> FindAll()
        {
            Console.WriteLine("FindAll()");
            return _taskListService.FindAll();
        }

        [HttpPost]
        public TaskList Create([FromQuery] TaskListDto taskListDto)
        {
            Console.WriteLine("Create()");
            return _taskListService.Create(taskListDto);
        }

        [HttpGet("{id:long}")]
        public TaskList GetById(long taskListId)
        {
            Console.WriteLine("GetById()");
            return _taskListService.FindById(taskListId);
        }
    }
}
