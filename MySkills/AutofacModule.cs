using Autofac;
using MySkills.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static MySkills.Startup;

namespace MySkills
{
    public class AutofacModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TextWriteLog>().As<ILog>();
        }
    }

}
