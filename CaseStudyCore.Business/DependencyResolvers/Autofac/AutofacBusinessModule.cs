using Autofac;
using CaseStudyCore.Business.Abstract;
using CaseStudyCore.Business.Concrete;
using CaseStudyCore.DataAccess.Abstract;
using CaseStudyCore.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<CourseDal>().As<ICourseDal>();

            builder.RegisterType<StudentManager>().As<IStudentService>();
            builder.RegisterType<StudentDal>().As<IStudentDal>();
            
            //Bağımlılıkları belirtmek için
        }
    }
}
