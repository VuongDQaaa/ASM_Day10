using ASM_Day10.DTO;
using ASM_Day10.Entities;
using ASM_Day10.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASM_Day10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost("/add")]
        public async Task AddStudent([FromBody]StudentDTO student)
        {
            await _service.AddStudent(student);
        }

        [HttpGet("/get-all")]
        public async Task<List<Student>> GetAllStudent()
        {
            return await _service.GetAllStudent();
        }

        [HttpGet("/get-by-id")]
        public async Task<Student> GetStudentbyId(int id)
        {
            return await _service.GetStudentById(id);
        }

        [HttpDelete("/delete")]
        public async Task DeleteStudent(int id)
        {
            await _service.DeleteStudent(id);
        }

        [HttpPost("/update")]
        public async Task UpdateStudent([FromBody]Student student)
        {
            await _service.UpdateStudent(student);
        }
    }
}