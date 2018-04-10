using RazorLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olive.Markdown
{
    public static class MarkdownEngine
    {
        internal static readonly RazorLightEngineBuilder Engine;
        public static void Build()
        {
            Settings.RazorEngine  = new RazorLightEngineBuilder()
              .UseMemoryCachingProvider()
              .Build();
        }
    }
}
