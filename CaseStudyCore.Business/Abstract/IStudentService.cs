using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface IStudentService
    {
        Student Add(Student entity);
        void Delete(int id);
        Student GetById(int id);
        List<Student> GetAllList();
        Student Update(Student entity);
    }
}
