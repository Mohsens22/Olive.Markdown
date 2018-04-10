using Autofac;
using RazorLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olive.Markdown.Infrastructure
{
    public static class DependencyRegister
    {
        public static IContainer Dependencies;
        internal static void BuildContainer()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<RazorLightEngine>().As<RazorLightEngine>();
            Dependencies = builder.Build();
        }
    }
}
