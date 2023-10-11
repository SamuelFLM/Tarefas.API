using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task.API.Entities;
using Task.API.Models;
using Task.API.Persistence.Repositories;

namespace Task.API.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _repository;

        public TaskController(ITaskRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var task = _repository.GetAll();
            return Ok(task);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _repository.GetById(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post(AddTaskInputModel model)
        {
            var task = new Tasks(
                model.Title,
                model.Description,
                model.Status,
                model.DeadLine
            );

            if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Description))
                return BadRequest();

            if (model.DeadLine == DateTime.MinValue)
                return BadRequest();

            _repository.Post(task);

            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateTaskInputModel model)
        {
            var task = _repository.GetById(id);

            task.Update(model.Status);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var task = _repository.GetById(id);

            if (task is null)
                return NotFound();

            _repository.Delete(task);

            return NoContent();
        }

    }
}