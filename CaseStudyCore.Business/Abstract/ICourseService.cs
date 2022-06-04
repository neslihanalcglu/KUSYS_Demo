using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface ICourseService
    {
        Course Add(Course entity);
        void Delete(int id);
        Course GetById(int id);
        List<Course> GetAllList();
        Course Update(Course entity);
    }
}
