using RazorLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olive.Markdown
{
    public class MarkdownEngine
    {
        internal static readonly RazorLightEngineBuilder Engine;
        public void Build()
        {
            Engine = new RazorLightEngineBuilder()
              .UseMemoryCachingProvider()
              .Build();
        }
    }
}
