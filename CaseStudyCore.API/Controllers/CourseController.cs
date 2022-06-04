using System.Collections.Generic;
using CaseStudyCore.Business.Abstract;
using CaseStudyCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudyCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        /// <summary>
        ///     Get All Company
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public List<Course> GetList()
        {
            var entity = _courseService.GetAllList();
            return entity;
        }

        [HttpGet("{id}")]
        public Course GetById(int id)
        {
            return _courseService.GetById(id);
        }

        [HttpPost]
        public Course Post([FromBody] Course company)
        {
            return _courseService.Add(company);
        }

        [HttpPut]
        public Course Put([FromBody] Course company)
        {
            return _courseService.Update(company);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _courseService.Delete(id);
        }
    }
}