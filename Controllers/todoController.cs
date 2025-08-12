using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using task1.models;
using task1.Repositories;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class todoController : ControllerBase
    {
        private readonly itodorepositories _todoRepository;

        public todoController(itodorepositories todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet("GetAll")]

        public ActionResult GetAll()
        {
            var data = _todoRepository.GetAll();
            return Ok(data);
        }

        [HttpGet("GetById")]

        public ActionResult GetById(int id)
        {
            var data = _todoRepository.GetById(id);
            return Ok(data);
        }

        public ActionResult Add(ToDo todo)
        {
            _todoRepository.Add(todo);
            _todoRepository.Save();
            return Ok("Data added successfully");
        }

        public ActionResult Update(ToDo todo)
        {
            _todoRepository.Update(todo);
            _todoRepository.Save();
            return Ok("Data updated successfully");
        }

        public ActionResult Delete(int id)
        {
            _todoRepository.Delete(id);
            _todoRepository.Save();
            return Ok("Data successfully deleted");
        }



    }
}
