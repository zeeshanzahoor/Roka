using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ArtifexPay.Boot
{
    public class Bootstraper
    {
        public static void DoTheMagic(ContainerBuilder builder)
        {


            string LibrariesPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);//Path.Combine(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()), "libs");

            Assembly[] CoreAndServiceAssemblies = Directory
                .GetFiles(LibrariesPath, "ArtifexPay.*.dll")
                .Select(m => Assembly.LoadFile(m))
                .ToArray();

            //Assembly[] CoreAndServiceAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(m=>m.FullName.Contains("ArtifexPay")).ToArray();


            builder.RegisterAssemblyModules(CoreAndServiceAssemblies.ToArray());

        }
    }
}
