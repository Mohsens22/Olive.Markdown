using RazorLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Markdown
{
    public class Test
    {
        public static async void RenderBitch()
        {
            


            string result = await engine.CompileRenderAsync("templateKey", File.ReadAllText(@"C:\Users\Mohsen\Documents\Visual Studio 2017\Projects\MDEngineTest\MDEngineTest\Templates\GCop.csmd"), new { Name = "John Doe" });
        }
    }
}
