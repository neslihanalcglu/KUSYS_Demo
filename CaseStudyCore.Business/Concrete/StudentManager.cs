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
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public Student Add(Student entity)
        {
            return _studentDal.Add(entity);
        }

        public void Delete(int id)
        {
            _studentDal.Delete(id);
        }

        public List<Student> GetAllList()
        {
            return _studentDal.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public Student Update(Student entity)
        {
            return _studentDal.Update(entity);
        }
    }
}
