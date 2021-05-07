using Razor.Templating.Core;
using System;
using System.Threading.Tasks;

namespace RazorTemplatingTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var html = await RazorTemplateEngine.RenderAsync("~/Views/Home/Index.cshtml");
            Console.WriteLine(html);
        }
    }
}
