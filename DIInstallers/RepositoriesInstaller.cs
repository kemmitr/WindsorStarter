using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using APILegacy.Repository;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace APILegacy.DIInstallers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ITeacher>().ImplementedBy<TeacherRepository>().LifestyleTransient());
            container.Register(
                Component.For<IStudent>().ImplementedBy<StudentRepository>().LifestyleTransient());
        }
    }
}