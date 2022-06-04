using System.Collections.Generic;
using CaseStudyCore.Business.Abstract;
using CaseStudyCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudyCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getall")]
        public List<Student> GetList()
        {
            var entity = _studentService.GetAllList();
            return entity;
        }

        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _studentService.GetById(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student service)
        {
            return _studentService.Add(service);
        }

        [HttpPut]
        public Student Put([FromBody] Student service)
        {
            return _studentService.Update(service);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}