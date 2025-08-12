using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using task1.models;
using task1.Repositories;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly iuserrepositories _userRepository;

        public userController(iuserrepositories userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet("GetAllData")]

        public ActionResult GetAll()
        {
            var data = _userRepository.GetAll();
            return Ok(data);
        }

        [HttpGet("GetById")]

        public ActionResult GetById(int id)
        {
            var data = _userRepository.GetById(id);
            return Ok(data);
        }


        [HttpPost("Add-Data")]

        public ActionResult Add(Users user)
        {
            _userRepository.Add(user);
            _userRepository.Save();
            return Ok("Information added successfully.");
        }


        [HttpPut("update")]

        public ActionResult Update(Users user)
        {
            _userRepository.Update(user);
            _userRepository.Save();
            return Ok("Information was successfully updated.");
        }

        [HttpDelete("delete")]

        public ActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            _userRepository.Save();
            return Ok("Information successfully deleted.");
        }


    }
}
