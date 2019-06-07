using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMF.Data.Interfaces;
using AMF.Data.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMF.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        public readonly ITodoRepository TodoRepository;

        public TodoController(ITodoRepository _todoRepository)
            => 
                TodoRepository = _todoRepository;

        [HttpGet("id:guid")]
        public IActionResult GetTodo(Guid id)
        {
            var todo = TodoRepository.GetById(id);

            return Ok(todo);

        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(TodoRepository.Get());
        }


        [HttpPost]
        public IActionResult AddTodo()
        {
            var todo = new Todo
            {
                Body = "you are looking sad",
                Title = "how are you today"

            };
            TodoRepository.Add(todo);
            TodoRepository.Save();
            return Created("", "created a new todo!");
        }

        [HttpDelete("{id:guid}")]
        public IActionResult RemovedTodo(Guid id)
        {
            TodoRepository.Remove(id);
            TodoRepository.Save();
            return Ok("Removed a todo!");
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateTodo(Guid id)
        {
            var todo = TodoRepository.GetById(id);

            todo.Body = "You still have!";
            todo.Title = "lovely";

            TodoRepository.Update(todo);

            return Ok("to do updated");
        }
    }
}