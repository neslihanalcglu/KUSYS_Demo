using CaseStudyCore.Business.Abstract;
using CaseStudyCore.DataAccess.Abstract;
using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public Course Add(Course entity)
        {
            return _courseDal.Add(entity);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAllList()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }


        public Course Update(Course entity)
        {
            return _courseDal.Update(entity);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
