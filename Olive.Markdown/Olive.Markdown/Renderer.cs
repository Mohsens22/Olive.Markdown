using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Markdown
{
    public static class Renderer
    {
        public static async Task<string> Render<T>(string templateKey, FileInfo file, T model) => await Settings.RazorEngine.CompileRenderAsync(templateKey, File.ReadAllText(file.FullName), model);
    }
}
