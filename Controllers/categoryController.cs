using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using task1.models;
using task1.Repositories;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        private readonly icategoryrepositories _categoryRepository;

        public categoryController(icategoryrepositories categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("GetAll")]

        public ActionResult GetAll()
        {
            var data = _categoryRepository.GetAll();

            return Ok(data);
        }

        [HttpGet("GetById")]

        public ActionResult GetById(int id)
        {
            var data = _categoryRepository.GetById(id);
            return Ok(data);
        }

        [HttpPost("Add-Data")]

        public ActionResult Add(Categories cate)
        {
            _categoryRepository.Add(cate);
            _categoryRepository.Save();
            return Ok("Information added successfully");
        }

        public ActionResult Update(Categories cate)
        {
            _categoryRepository.Update(cate);
            _categoryRepository.Save();
            return Ok("Information was successfully updated");
        }

        public ActionResult Delete(int id)
        {
            _categoryRepository.Delete(id);
            _categoryRepository.Save();
            return Ok("Information successfully deleted");
        }

    }
}
